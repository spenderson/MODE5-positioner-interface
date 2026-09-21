using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Net;
using static System.Net.Mime.MediaTypeNames;

namespace MODE5_Tester
{
    public partial class MainForm : Form
    {
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

            sendRate.SelectedIndex = 0;
            sendMode.SelectedIndex = 0;

        }

        #region Globals
        private readonly int[] baudrate = { 9600, 19200, 38400, 115200, 230400, 460800, 921600, 3860000 };
        
        private readonly int MODE5_PACKET_SIZE = 24;
        
        private readonly byte MODE5_SYNC_CHAR = 0xAA;

        private SerialPort Serial = new SerialPort();

        private bool updatingControls = false; // to prevent feedback loops (to be safe)

        private bool isSending = false;

        private bool prevWasSweep = false;

        private CancellationTokenSource backgroundCancellationTokenSource;

        private Task backgroundSendTask;

        // variables used for sweep function
        private int sweepMinAz = 0;

        private int sweepMaxAz = 359;

        private int sweepMinEl = -38;

        private int sweepMaxEl = 83;

        float sweepAzDegrees = 0, sweepElDegrees = 0;

        int sweepAzDirection = 1, sweepElDirection = 1;

        // variables to remember the inputs when sweep mode started
        string memoryAzPos, memoryElPos, memoryAzVel, memoryElVel, memoryAzAcc, memoryElAcc;

        // sent packet counters, for displays
        int validCounter = 0, shortCounter = 0, longCounter = 0, syncCounter = 0;
        #endregion

        #region Handlers

        private void btnConnect_Click(object sender, EventArgs e)
        {
            // If user click disconnect
            if ("Disconnect" == btnConnect.Text.ToString())
            {

                StopSending();

                if (true == Serial.IsOpen)
                {
                    Serial.Close();
                }

                btnConnect.Text = "Connect";
                cboxComport.Enabled = true;
                cboxBaudrate.Enabled = true;
                btnRefresh.Enabled = true;

                UpdateInputEnabled();

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
                    UpdateInputEnabled();
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateRS232Options();

            // Autopopulate COM port and Baud rate dropdowns
            cboxBaudrate.SelectedIndex = 1; // manually setting to 19200 while testing
            if (cboxComport.Items.Count > 0)
            {
                cboxComport.SelectedIndex = 0;
            }

            UpdateInputEnabled();
            RememberInputs();
            checkControlSend.Checked = true;
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // We need to update all lists again if user requested
            UpdateRS232Options();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

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
            //MessageBox.Show("ValidateInput called"); // debug line

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


            if (checkControlSend.Checked)
            {
                ConstructAndSendPacket();
                UpdatePacketCounter();
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

        private void sweepTimer_Tick(object sender, EventArgs e)
        {

            // update AZ
            if (sweepAzDirection > 0 && sweepAzDegrees < sweepMaxAz)
            {
                sweepAzDegrees++;
            }
            else if (sweepAzDirection > 0 && sweepAzDegrees >= sweepMaxAz)
            {
                sweepAzDirection = -1;
                sweepAzDegrees--;
            }
            else if (sweepAzDirection < 0 && sweepAzDegrees > sweepMinAz)
            {
                sweepAzDegrees--;
            }
            else if (sweepAzDirection < 0 && sweepAzDegrees <= sweepMinAz)
            {
                sweepAzDirection = 1;
                sweepAzDegrees++;
            }

            // update EL
            if (sweepElDirection > 0 && sweepElDegrees < sweepMaxEl)
            {
                sweepElDegrees++;
            }
            else if (sweepElDirection > 0 && sweepElDegrees >= sweepMaxEl)
            {
                sweepElDirection = -1;
                sweepElDegrees--;
            }
            else if (sweepElDirection < 0 && sweepElDegrees > sweepMinEl)
            {
                sweepElDegrees--;
            }
            else if (sweepElDirection < 0 && sweepElDegrees <= sweepMinEl)
            {
                sweepElDirection = 1;
                sweepElDegrees++;
            }

            // updated input display
            azPosTextBoxTx.Text = sweepAzDegrees.ToString();
            elPosTextBoxTx.Text = sweepElDegrees.ToString();

            // send it
            ConstructAndSendPacket();
            UpdatePacketCounter();
        }

        private void sendTimer_Tick(object sender, EventArgs e)
        {
            ConstructAndSendPacket();
            UpdatePacketCounter();
        }

        private void sendSettingChanged(object sender, EventArgs e)
        {

            if (!prevWasSweep)
            {
                // commit previous settings to memory
                RememberInputs();
            }

            if (sendMode.Text == "Sweep")
            {
                SetupSweep();
            }
            else
            {
                // recall previous non-sweep settings
                azPosTextBoxTx.Text = memoryAzPos;
                elPosTextBoxTx.Text = memoryElPos;
                azVelTextBoxTx.Text = memoryAzVel;
                elVelTextBoxTx.Text = memoryElVel;
                azAccTextBoxTx.Text = memoryAzAcc;
                elAccTextBoxTx.Text = memoryElAcc;
                sendRate.Enabled = true;
                prevWasSweep = false;
            }

            UpdateInputEnabled();
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
                        if (sendMode.Text == "Use Position Controls")
                        {
                            if (sendRate.Text == "Single Packet")
                            {
                                ConstructAndSendPacket();
                                UpdatePacketCounter();
                            }
                            else
                            {
                                if (sendRate.Text == "1 Hz")
                                {
                                    sendTimer.Interval = 1000;
                                    sendTimer.Start();
                                }
                                else if (sendRate.Text == "10 Hz")
                                {
                                    sendTimer.Interval = 100;
                                    sendTimer.Start();
                                }
                                else if (sendRate.Text == "50 Hz")
                                {
                                    sendTimer.Interval = 20;
                                    sendTimer.Start();
                                }
                                else if (sendRate.Text == "100 Hz")
                                {
                                    sendTimer.Interval = 10;
                                    sendTimer.Start();
                                }
                                else if (sendRate.Text == "Continuous")
                                {

                                    // construct packet from textbox values on UI

                                    float.TryParse(azPosTextBoxTx.Text, out float azDegrees);
                                    float.TryParse(elPosTextBoxTx.Text, out float elDegrees);
                                    float.TryParse(azVelTextBoxTx.Text, out float azVel);
                                    float.TryParse(elVelTextBoxTx.Text, out float elVel);
                                    float.TryParse(azAccTextBoxTx.Text, out float azAcc);
                                    float.TryParse(elAccTextBoxTx.Text, out float elAcc);
                                    byte[] packet = ConstructPacket(azDegrees, elDegrees, azVel, elVel, azAcc, elAcc);

                                    // pass the packet off to the ContinuousSend method that runs in the background

                                    backgroundCancellationTokenSource = new CancellationTokenSource();
                                    CancellationToken token = backgroundCancellationTokenSource.Token;
                                    backgroundSendTask = Task.Run(() => ContinuousSend(packet, token), token);

                                    updateCounterTimer.Interval = 100;
                                    updateCounterTimer.Start();

                                }
                                SetSweepInput();
                                sendMode.Enabled = false;
                                isSending = true;
                            }
                        }
                        else if (sendMode.Text == "Sweep")
                        {
                            ConstructAndSendPacket();
                            UpdatePacketCounter();
                            sweepTimer.Start();
                            sendMode.Enabled = false;
                            isSending = true;
                        }
                    }
                    else
                    {
                        StopSending();
                        UpdatePacketCounter();
                    }
                    UpdateSendButton();
                }
                else
                {
                    MessageBox.Show("COM port is not opened");
                }
            }
        }

        private void btnShort_Click(object sender, EventArgs e)
        {
            byte[] validPacket = ConstructPacket(0f, 1f, 2f, 3f, 4f, 5f);

            byte[] shortPacket = new byte[MODE5_PACKET_SIZE - 1];
            for (int i = 0; i < shortPacket.Length; i++)
            {
                shortPacket[i] = validPacket[i];
            }

            SendPacket(shortPacket);
            shortCounter++;
            shortCountDisplay.Text = shortCounter.ToString();
        }

        private void btnLong_Click(object sender, EventArgs e)
        {
            byte[] validPacket = ConstructPacket(0f, 1f, 2f, 3f, 4f, 5f);

            byte[] longPacket = new byte[MODE5_PACKET_SIZE + 1];
            for (int i = 0; i < MODE5_PACKET_SIZE - 1; i++)
            {
                longPacket[i] = validPacket[i];
            }
            longPacket[MODE5_PACKET_SIZE - 1] = 0xF5;
            longPacket[MODE5_PACKET_SIZE] = validPacket[MODE5_PACKET_SIZE - 1];

            SendPacket(longPacket);
            longCounter++;
            longCountDisplay.Text = longCounter.ToString();
        }

        private void btnAllSync_Click(object sender, EventArgs e)
        {
            byte[] allSyncs = new byte[MODE5_PACKET_SIZE];
            for (int i = 0; i < MODE5_PACKET_SIZE; i++)
            {
                allSyncs[i] = MODE5_SYNC_CHAR;
            }

            SendPacket(allSyncs);
            syncCounter++;
            syncCountDisplay.Text = syncCounter.ToString();
        }

        private void updateCounterTimer_Tick(object sender, EventArgs e)
        {
            UpdatePacketCounter();
        }

        private void Slider_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && checkControlSend.Checked)
            {
                ConstructAndSendPacket();
                UpdatePacketCounter();
            }
        }

        #endregion

        #region Methods
        private void UpdateRS232Options()
        {
            // Get all existing Com Port names
            string[] Ports = System.IO.Ports.SerialPort.GetPortNames();
            cboxComport.Items.Clear();
            cboxBaudrate.Items.Clear();
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

        private void UpdateSendButton()
        {
            if (isSending)
            {
                btnSend.Text = "Stop";
            }
            else if (sendRate.Text == "Single Packet" && sendMode.Text == "Use Position Controls")
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

            // stop continuous mode
            if (backgroundCancellationTokenSource != null)
            {
                backgroundCancellationTokenSource.Cancel();
            }
            updateCounterTimer.Stop();

            // stop Hz mode
            sendTimer.Stop();

            // stop sweep mode
            sweepTimer.Stop();
            if (sendMode.Text == "Sweep")
            {
                // need to reset the sweep vars here, because they get initiated when Sweep is selected, not what it starts
                SetupSweep();
            }

            // update the GUI
            isSending = false;
            UpdateSendButton();
            UpdateInputEnabled();
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

        private byte[] ConstructPacket(float azDegrees, float elDegrees, float azVel, float elVel, float azAcc, float elAcc)
        {

            byte[] packet = new byte[MODE5_PACKET_SIZE];

            // Sync char

            packet[0] = MODE5_SYNC_CHAR;

            // Positions

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

        private void SendValidPacket(byte[] packet)
        {
            validCounter++;
            Serial.Write(packet, 0, packet.Length);
        }

        private void ConstructAndSendPacket()
        {

            float.TryParse(azPosTextBoxTx.Text, out float azDegrees);
            float.TryParse(elPosTextBoxTx.Text, out float elDegrees);
            float.TryParse(azVelTextBoxTx.Text, out float azVel);
            float.TryParse(elVelTextBoxTx.Text, out float elVel);
            float.TryParse(azAccTextBoxTx.Text, out float azAcc);
            float.TryParse(elAccTextBoxTx.Text, out float elAcc);
            byte[] packet = ConstructPacket(azDegrees, elDegrees, azVel, elVel, azAcc, elAcc);

            SendValidPacket(packet);

        }

        private void ContinuousSend(byte[] packet, CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                SendValidPacket(packet);
            }
        }

        private void UpdatePacketCounter()
        {
            validCounterDisplay.Text = validCounter.ToString("N0"); // "N0" adds commas, e.g. "12,349" instead of "12349"
        }

        private void SetInputEnabled(bool enabled)
        {
            azPosTextBoxTx.Enabled = enabled;
            elPosTextBoxTx.Enabled = enabled;
            azVelTextBoxTx.Enabled = enabled;
            elVelTextBoxTx.Enabled = enabled;
            azAccTextBoxTx.Enabled = enabled;
            elAccTextBoxTx.Enabled = enabled;

            azPosSlider.Enabled = enabled;
            elPosSlider.Enabled = enabled;
            azVelSlider.Enabled = enabled;
            elVelSlider.Enabled = enabled;
            azAccSlider.Enabled = enabled;
            elAccSlider.Enabled = enabled;

            btnShort.Enabled = enabled;
            btnLong.Enabled = enabled;
            btnAllSync.Enabled = enabled;

            btnSend.Enabled = enabled;
            sendRate.Enabled = enabled;
            sendMode.Enabled = enabled;
            checkControlSend.Enabled = enabled;
        }

        private void SetSweepInput()
        {
            // when setting to sweep mode

            // enable all controls...
            SetInputEnabled(true);

            // ...except:
            azPosTextBoxTx.Enabled = false;
            elPosTextBoxTx.Enabled = false;
            azVelTextBoxTx.Enabled = false;
            elVelTextBoxTx.Enabled = false;
            azAccTextBoxTx.Enabled = false;
            elAccTextBoxTx.Enabled = false;

            azPosSlider.Enabled = false;
            elPosSlider.Enabled = false;
            azVelSlider.Enabled = false;
            elVelSlider.Enabled = false;
            azAccSlider.Enabled = false;
            elAccSlider.Enabled = false;

            sendRate.Enabled = false;
            checkControlSend.Enabled = false;
        }

        private void UpdateInputEnabled()
        {
            if (btnConnect.Text == "Connect")
            {
                SetInputEnabled(false);
            }
            else if (sendMode.Text == "Sweep")
            {
                SetSweepInput();
            }
            else if (btnSend.Text == "Stop")
            {
                SetSweepInput();
                MessageBox.Show("[DEBUG] inputs should be disabled now"); // debug line, it shouldn't reach this
            }
            else
            {
                SetInputEnabled(true);
            }
        }

        private void RememberInputs()
        {
            memoryAzPos = azPosTextBoxTx.Text;
            memoryElPos = elPosTextBoxTx.Text;
            memoryAzVel = azVelTextBoxTx.Text;
            memoryElVel = elVelTextBoxTx.Text;
            memoryAzAcc = azAccTextBoxTx.Text;
            memoryElAcc = elAccTextBoxTx.Text;
        }

        private void SetupSweep()
        {
            azPosTextBoxTx.Text = "0";
            elPosTextBoxTx.Text = "0";
            azVelTextBoxTx.Text = "2";
            elVelTextBoxTx.Text = "2";
            azAccTextBoxTx.Text = "1";
            elAccTextBoxTx.Text = "1";
            sweepAzDirection = 1;
            sweepElDirection = 1;
            sweepAzDegrees = 0;
            sweepElDegrees = 0;
            sweepTimer.Interval = 500;
            prevWasSweep = true;
        }


        #endregion
    }
}
