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

namespace New_App
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

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
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            // autopopulate COM port and Baud rate dropdowns
            UpdateRS232Options();
            cboxBaudrate.SelectedIndex = 1; // manually setting to 19200 while testing
            if (cboxComport.Items.Count > 0)
            {
                cboxComport.SelectedIndex = 0;
            }

            // focus the Connect button so user can just hit ENTER to right after startup
            ActiveControl = btnConnect;

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // repopulate COM port and Baud rate dropdowns
            UpdateRS232Options();

            // select the first one
            cboxBaudrate.SelectedIndex = 0;
            if (cboxComport.Items.Count > 0)
            {
                cboxComport.SelectedIndex = 0;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void btnSendRdf_Click(object sender, EventArgs e)
        {
            // Make sure the COM port is connected.
            if (!Serial.IsOpen)
            {
                MessageBox.Show("Please connect to a COM port first.");
                return;
            }

            // Let the user choose an RDF file.
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "RDF files (*.rdf)|*.rdf|All files (*.*)|*.*";
                openFileDialog.Title = "Select RDF File";

                if (openFileDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                try
                {
                    // Read the entire file as bytes.
                    byte[] fileData = File.ReadAllBytes(openFileDialog.FileName);

                    // Send the entire file through the existing serial connection.
                    Serial.Write(fileData, 0, fileData.Length);

                    MessageBox.Show(
                        $"Sent {fileData.Length:N0} bytes.",
                        "RDF Transfer");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        $"Failed to send RDF file:\n{ex.Message}",
                        "Transfer Error");
                }
            }
        }

        #endregion

        #region Methods
        private void UpdateRS232Options()
        {
            // clear the lists
            cboxComport.Items.Clear();
            cboxBaudrate.Items.Clear();

            // populate port names
            string[] Ports = System.IO.Ports.SerialPort.GetPortNames();
            foreach (var item in Ports)
            {
                cboxComport.Items.Add(item);
            }

            // populate baud rates
            foreach (var baud in baudrate)
            {
                cboxBaudrate.Items.Add(baud.ToString());
            }

        }


        #endregion
    }
}
