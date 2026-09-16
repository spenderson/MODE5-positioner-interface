using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Serial
{
    public partial class MainForm : Form
    {
        #region Both Receiver and Transmitter
        private readonly int[] baudrate = { 9600, 19200, 38400, 115200, 230400, 460800, 921600, 3860000 };
        
        private readonly int MODE5_PACKET_SIZE = 24;
        
        private readonly byte MODE5_SYNC_CHAR = 0xAA;

        private SerialPort Serial = new SerialPort();
        
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
        
        public MainForm()
        {
            InitializeComponent();


            // have each slider/textbox pair on the TX interface be tagged to eachother
            // this is to allow generic handlers to use tags to decide which other UI elements to update

            azPosSlider.Tag = azPosTextBoxTx;
            azPosTextBoxTx.Tag = azPosSlider;

            elPosSlider.Tag = elPosTextBoxTx;
            elPosTextBoxTx.Tag = elPosSlider;

            azVelSlider.Tag = azVelTextBoxTx;
            azVelTextBoxTx.Tag = azVelSlider;

            elVelSlider.Tag = elVelTextBoxTx;
            elVelTextBoxTx.Tag = elVelSlider;

            azAccSlider.Tag = azAccTextBoxTx;
            azAccTextBoxTx.Tag = azAccSlider;

            elAccSlider.Tag = elAccTextBoxTx;
            elAccTextBoxTx.Tag = elAccSlider;


            // make sure the text boxes are populated upon startup

            azPosTextBoxTx.Text = azPosSlider.Value.ToString();
            elPosTextBoxTx.Text = elPosSlider.Value.ToString();

            azVelTextBoxTx.Text = azVelSlider.Value.ToString();
            elVelTextBoxTx.Text = elVelSlider.Value.ToString();

            azAccTextBoxTx.Text = azAccSlider.Value.ToString();
            elAccTextBoxTx.Text = elAccSlider.Value.ToString();

            sendMode.SelectedIndex = 0;
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
                }
                ;


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

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }
        #endregion


        #region Receiver
        private List<byte> rxBuffer = new List<byte>();

        private int packetCounter = 0;

        public delegate void UPDATE_OUTPUT_TEXT(String Str);

        public void UpdateOutputText(String Str)
        {
            packetCounter++;

            // keep the output log at a maximum of 10 lines
            if (packetCounter > 9)
            {
                int lastNewlineIndex = tboxReceive.Text.LastIndexOf("\r\n");
                tboxReceive.Text = tboxReceive.Text.Substring(0, lastNewlineIndex);
            }

            int index = packetCounter % 1000;
            tboxReceive.Text = index.ToString("D3") + ": " + Str + tboxReceive.Text; // reversed to keep recent data at the top
            tboxReceive.ScrollToCaret();
        }

        public void UpdateTextBoxes(float azPos, float elPos, float azVel, float elVel, float azAcc, float elAcc)
        {
            // full precision for MODE5 can go up 21 decimal spots for position values
            azPosTextBox.Text = azPos.ToString("0.00");
            elPosTextBox.Text = elPos.ToString("0.00");

            // G9 is apparently tailored to displaying floats
            azVelTextBox.Text = azVel.ToString("G9");
            elVelTextBox.Text = elVel.ToString("G9");
            azAccTextBox.Text = azAcc.ToString("G9");
            elAccTextBox.Text = elAcc.ToString("G9");
        }

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


        #region Transmitter
        private bool updatingControls = false; // to prevent feedback loops (to be safe)
        private CancellationTokenSource continuousCancellationTokenSource;
        private Task continuousSendTask;
        private bool isSending = false;

        private void Slider_Scroll(object sender, EventArgs e)
        {
            TrackBar slider = (TrackBar)sender;
            TextBox textBox = (TextBox)slider.Tag;

            if (updatingControls)
                return;

            updatingControls = true;
            textBox.Text = slider.Value.ToString();
            updatingControls = false;
        }

        private void TextBoxTx_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            TrackBar slider = (TrackBar)textBox.Tag;

            if (updatingControls)
                return;

            float value;

            if (float.TryParse(textBox.Text, out value) &&
                value >= slider.Minimum &&
                value <= slider.Maximum)
            {
                updatingControls = true;
                slider.Value = (int)Math.Round(value);
                updatingControls = false;
            }
        }

        private void ValidateInput(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            TrackBar slider = (TrackBar)textBox.Tag;

            float value;

            if (!float.TryParse(textBox.Text, out value))
            {
                MessageBox.Show("Invalid input");
                textBox.Text = slider.Value.ToString();
            }
            else if (value < slider.Minimum ||
                     value > slider.Maximum)
            {
                MessageBox.Show("Input out of range");
                textBox.Text = slider.Value.ToString();
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && ActiveControl is TextBox)
            {
                TextBox textBox = (TextBox)ActiveControl;

                ValidateInput(textBox, EventArgs.Empty);

                textBox.Focus();

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void UpdateSendButton()
        {
            if (isSending)
            {
                btnSend.Text = "Stop";
            }
            else if (sendMode.Text == "Single Packet")
            {
                btnSend.Text = "Send";
            }
            else
            {
                btnSend.Text = "Start";
            }
        }

        private void StopSending()
        {
            sendTimer.Stop();

            if (continuousCancellationTokenSource != null)
            {
                continuousCancellationTokenSource.Cancel();
            }

            isSending = false;

            UpdateSendButton();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (null != Serial)
            {
                if (true == Serial.IsOpen)
                {
                    if (!isSending)
                    {
                        if (sendMode.Text == "Single Packet")
                        {
                            ConstructAndSendPacket();
                        }
                        else
                        {
                            if (sendMode.Text == "1 Hz")
                            {
                                sendTimer.Interval = 1000;
                                sendTimer.Start();
                            }
                            else if (sendMode.Text == "10 Hz")
                            {
                                sendTimer.Interval = 100;
                                sendTimer.Start();
                            }
                            else if (sendMode.Text == "50 Hz")
                            {
                                sendTimer.Interval = 20;
                                sendTimer.Start();
                            }
                            else if (sendMode.Text == "100 Hz")
                            {
                                sendTimer.Interval = 10;
                                sendTimer.Start();
                            }
                            else if (sendMode.Text == "Continuous")
                            {
                                byte[] packet = ConstructPacket();
                                continuousCancellationTokenSource = new CancellationTokenSource();
                                CancellationToken token = continuousCancellationTokenSource.Token;
                                continuousSendTask = Task.Run(() => ContinuousSend(packet, token), token);
                            }
                            isSending = true;
                        }
                    }
                    else
                    {
                        StopSending();
                    }
                    UpdateSendButton();
                }
                else
                {
                    MessageBox.Show("COM port is not opened");
                }
            }
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

        private byte[] ConstructPacket()
        {

            byte[] packet = new byte[MODE5_PACKET_SIZE];

            // Sync char

            packet[0] = MODE5_SYNC_CHAR;

            // Positions

            float.TryParse(azPosTextBoxTx.Text, out float azDegrees);
            float.TryParse(elPosTextBoxTx.Text, out float elDegrees);

            int azPos = (int)(azDegrees * 16777216.0 / 360.0);

            packet[1] = (byte)((azPos >> 16) & 0xFF);
            packet[2] = (byte)((azPos >> 8) & 0xFF);
            packet[3] = (byte)((azPos) & 0xFF);

            if (elDegrees < 0)
            {
                elDegrees = (elDegrees % 360) + 360;
            }

            int elPos = (int)(elDegrees * 16777216.0 / 360.0);

            packet[4] = (byte)((elPos >> 16) & 0xFF);
            packet[5] = (byte)((elPos >> 8) & 0xFF);
            packet[6] = (byte)((elPos) & 0xFF);

            // Velocities and Accelerations

            float.TryParse(azVelTextBoxTx.Text, out float azVel);
            float.TryParse(elVelTextBoxTx.Text, out float elVel);
            float.TryParse(azAccTextBoxTx.Text, out float azAcc);
            float.TryParse(elAccTextBoxTx.Text, out float elAcc);

            AddFloatToPacket(packet, azVel, 7);
            AddFloatToPacket(packet, elVel, 11);
            AddFloatToPacket(packet, azAcc, 15);
            AddFloatToPacket(packet, elAcc, 19);

            // Checksum

            int bytesToSum = MODE5_PACKET_SIZE - 1;
            int sum = 0;
            for (int i = 0; i < bytesToSum; i++)
            {
                sum += packet[i];
            }
            packet[bytesToSum] = (byte)(sum % 256);

            // Return it

            return packet;
        }

        private void SendPacket(byte[] packet)
        {
            Serial.Write(packet, 0, packet.Length);
        }

        private void ConstructAndSendPacket()
        {
            // these two methods are separate because the Continuous send mode requires
            // constructing the packet and then repeatedly sending it as fast as possible

            byte[] packet = ConstructPacket();
            SendPacket(packet);

        }

        private void sendTimer_Tick(object sender, EventArgs e)
        {
            ConstructAndSendPacket();
        }

        private void sendMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            StopSending();
        }

        private void ContinuousSend(byte[] packet, CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                SendPacket(packet);
            }
        }
        #endregion
    }
}
