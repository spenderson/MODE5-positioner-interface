using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace Serial
{
    public partial class MainForm : Form
    {
        #region Constant
        private readonly int[] baudrate = { 9600, 19200, 38400, 115200, 230400, 460800, 921600, 3860000 };
        private readonly int MODE5_PACKET_SIZE = 24;
        private readonly byte MODE5_SYNC_CHAR = 0xAA;
        //private readonly byte MODE5_SYNC_CHAR = 0x41; // typable sync char "A", for testing
        #endregion

        private SerialPort Serial = new SerialPort();
        private List<byte> rxBuffer = new List<byte>();

        #region Local Helpers
        private void UpdateCOMPortList()
        {
            // Get all existing Com Port names
            string[] Ports = System.IO.Ports.SerialPort.GetPortNames();
            cboxComport.Items.Clear();
            cboxBaudrate.Items.Clear();

            // Append existing COM to the cboxComport list
            foreach (var item in Ports)
            {
                cboxComport.Items.Add(item);
            }

            // Append possible Baudrate to the cboxBaudrate list
            foreach (var baud in baudrate)
            {
                cboxBaudrate.Items.Add(baud.ToString());
            }
        }
        #endregion

        #region Delegates
        public delegate void UPDATE_OUTPUT_TEXT(String Str);
        public void UpdateOutputText(String Str)
        {
            tboxReceive.Text = Str + tboxReceive.Text; // reversed to keep recent data at the top
            tboxReceive.ScrollToCaret();
        }
        public void UpdateTextBoxes(float azPos, float elPos, float azVel, float elVel, float azAcc, float elAcc)
        {
            azPosTextBox.Text = azPos.ToString("0.##");
            elPosTextBox.Text = elPos.ToString("0.##");

            azVelTextBox.Text = azVel.ToString("0.##");
            elVelTextBox.Text = elVel.ToString("0.##");

            azAccTextBox.Text = azAcc.ToString("0.##");
            elAccTextBox.Text = elAcc.ToString("0.##");
        }
        #endregion
        private float PullFloatFromPacket(List<byte> packetBuffer, int startingIndex)
        {
            byte[] bytes = new byte[4];

            bytes[0] = packetBuffer[startingIndex];
            bytes[1] = packetBuffer[startingIndex + 1];
            bytes[2] = packetBuffer[startingIndex + 2];
            bytes[3] = packetBuffer[startingIndex + 3];

            Array.Reverse(bytes); // matches AddFloatToPacket()

            return BitConverter.ToSingle(bytes, 0);
        }


        #region Handlers
        void SerialOnReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            // Add received bytes to buffer
            int busRxMax = 100;
            byte[] rxBufferLocal = new byte[busRxMax];
            int numBytesReceived = Serial.Read(rxBufferLocal, 0, busRxMax);
            for (int i = 0; i < numBytesReceived; i++)
            {
                rxBuffer.Add(rxBufferLocal[i]);
            }

            int firstSyncChar;
            while (true)
            {
                firstSyncChar = -1;

                // Loop through all bytes within buffer, from left to right: if current byte is a sync char, assign that byte's position number to firstSyncChar.
                for (int i = 0; i < rxBuffer.Count; i++)
                {
                    if (rxBuffer[i] == MODE5_SYNC_CHAR)
                    {
                        firstSyncChar = i;
                        break;
                    }
                }

                // If firstSyncChar is still -1, clear buffer and exit SerialOnReceivedHandler.
                if (firstSyncChar == -1)
                {
                    rxBuffer.Clear();
                    return;
                }

                // Remove all bytes before the first sync char.
                if (firstSyncChar > 0)
                {
                    rxBuffer.RemoveRange(0, firstSyncChar);
                }

                // If there aren't 23 bytes after the first sync char, exit SerialOnReceivedHandler.
                if (rxBuffer.Count < MODE5_PACKET_SIZE)
                {
                    return;
                }

                // Check the 23rd byte for checksum logic
                int sum = 0;
                for (int i = 0; i < MODE5_PACKET_SIZE - 1; i++)
                {
                    sum += rxBuffer[i];
                }

                if (sum % 256 == rxBuffer[MODE5_PACKET_SIZE - 1]) // it checks out
                {
                    // output those 24 bytes to big text box

                    string str = "";
                    List<int> spaces = new List<int> { 1, 4, 7, 11, 15, 19, 23 };

                    for (int i = 0; i < MODE5_PACKET_SIZE; i++)
                    {
                        if (spaces.Contains(i))
                        {
                            str += " ";
                        }
                        str += rxBuffer[i].ToString("X2");
                    }
                    str += "\r\n";

                    Invoke(new UPDATE_OUTPUT_TEXT(UpdateOutputText), str);

                    // output the data to their dedicated little text boxes

                    int azInt = (rxBuffer[1]  << 16) | (rxBuffer[2]  << 8)  | rxBuffer[3];
                    int elInt = (rxBuffer[4]  << 16) | (rxBuffer[5]  << 8)  | rxBuffer[6];
                    float azPos = azInt * 360.0f / 16777216.0f;
                    float elPos = elInt * 360.0f / 16777216.0f;

                    float azVel = PullFloatFromPacket(rxBuffer, 7);
                    float elVel = PullFloatFromPacket(rxBuffer, 11);
                    float azAcc = PullFloatFromPacket(rxBuffer, 15);
                    float elAcc = PullFloatFromPacket(rxBuffer, 19);

                    Invoke((Action)(() => UpdateTextBoxes(azPos, elPos, azVel, elVel, azAcc, elAcc)));

                    // clear them from the receive buffer. 

                    rxBuffer.RemoveRange(0, MODE5_PACKET_SIZE);
                } 
                else // it doesn't
                {
                    // remove first byte (sync char) from receive buffer.
                    rxBuffer.RemoveRange(0, 1);
                }
            }
            
        }
        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            // If user click disconnect
            if ("Disconnect" == btnConnect.Text.ToString())
            {
                if (true == Serial.IsOpen)
                {
                    Serial.Close();
                }

                btnConnect.Text = "Connect";
                cboxComport.Enabled = true;
                cboxBaudrate.Enabled = true;
                btnRefresh.Enabled = true;

                return;
            }

            // else we gonna open the desired COM port
            // Get user comport from cbox
            try
            {
                Serial.PortName = cboxComport.Text;
            }
            catch
            {
                MessageBox.Show("Error! No COM Port selected");
                return;
            }

            // Get user baudrate from cbox
            try
            {
                Serial.BaudRate = int.Parse(cboxBaudrate.Text.ToString());
            }
            catch
            {
                MessageBox.Show("Error! No Baudrate selected");
                return;
            }

            // Serial Port Configuration
            Serial.Parity = Parity.None;
            Serial.DataBits = 8;
            Serial.ReceivedBytesThreshold = 1;
            Serial.StopBits = StopBits.One;
            Serial.Handshake = Handshake.None;
            Serial.WriteTimeout = 3000;

            // Check if com port is opened by other application
            if (false == Serial.IsOpen)
            {
                try
                {
                    // Com port available
                    Serial.Open();
                }
                catch
                {
                    MessageBox.Show("The COM port is not accessible", "Error");
                    return;
                };


                // double comform it is opened
                if (true == Serial.IsOpen)
                {
                    btnConnect.Text = "Disconnect";
                    cboxComport.Enabled = false;
                    cboxBaudrate.Enabled = false;
                    btnRefresh.Enabled = false;

                    // Add callback handler for receiving
                    Serial.DataReceived += new SerialDataReceivedEventHandler(SerialOnReceivedHandler);

                }

            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // We need to populate the lists during mainform is loading
            UpdateCOMPortList();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // We need to update all lists again if user requested
            UpdateCOMPortList();
        }

        private void AddFloatToPacket(byte[] packet, float value, int startIndex)
        {
            byte[] bytes = BitConverter.GetBytes(value);
            Array.Reverse(bytes); // Since this is a Windows Forms .NET Framework 4.8 application, GetBytes() returns little-endian

            packet[startIndex] = bytes[0];
            packet[startIndex + 1] = bytes[1];
            packet[startIndex + 2] = bytes[2];
            packet[startIndex + 3] = bytes[3];
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(null != Serial)
            {
                if(true == Serial.IsOpen)
                {
                    // Construct packet based on slider values

                    byte[] packet = new byte[MODE5_PACKET_SIZE];

                    // Sync char

                    packet[0] = MODE5_SYNC_CHAR;

                    // Positions

                    int azPos = (int)(azPosSlider.Value * 16777216.0 / 360.0);

                    packet[1] = (byte)((azPos >> 16) & 0xFF);
                    packet[2] = (byte)((azPos >> 8)  & 0xFF);
                    packet[3] = (byte)((azPos)       & 0xFF);

                    double elDegrees = elPosSlider.Value;

                    if (elDegrees < 0)
                    {
                        elDegrees = (elDegrees % 360) + 360;
                    }

                    int elPos = (int)(elDegrees * 16777216.0 / 360.0);

                    packet[4] = (byte)((elPos >> 16) & 0xFF);
                    packet[5] = (byte)((elPos >> 8)  & 0xFF);
                    packet[6] = (byte)((elPos)       & 0xFF);

                    // Velocities and Accellerations

                    AddFloatToPacket(packet, azVelSlider.Value, 7);
                    AddFloatToPacket(packet, elVelSlider.Value, 11);
                    AddFloatToPacket(packet, azAccelSlider.Value, 15);
                    AddFloatToPacket(packet, elAccelSlider.Value, 19);

                    // Checksum

                    int bytesToSum = MODE5_PACKET_SIZE - 1;
                    int sum = 0;
                    for (int i = 0; i < bytesToSum; i++)
                    {
                        sum += packet[i];
                    }
                    packet[bytesToSum] = (byte)(sum % 256);

                    Serial.Write(packet, 0, packet.Length);
                }
                else
                {
                    MessageBox.Show("COM Port is not Opened");
                }
            }
        }

        private bool updatingControls = false; // flag used to prevent feedback loops (to be safe)

        private void azPosSlider_Scroll(object sender, EventArgs e)
        {
            if (updatingControls)
                return;
            updatingControls = true;
            azPosTextBoxTx.Text = azPosSlider.Value.ToString();
            updatingControls = false;
        }

        private void azPosTextBoxTx_TextChanged(object sender, EventArgs e)
        {
            if (updatingControls)
                return;

            int value;

            if (int.TryParse(azPosTextBoxTx.Text, out value) &&
                value >= azPosSlider.Minimum &&
                value <= azPosSlider.Maximum)
            {
                updatingControls = true;
                azPosSlider.Value = value;
                updatingControls = false;
            }
        }

        private void azPosTextBoxTx_Leave(object sender, EventArgs e)
        {
            azPosTextBoxTx.Text = azPosSlider.Value.ToString();
        }
    }
}
