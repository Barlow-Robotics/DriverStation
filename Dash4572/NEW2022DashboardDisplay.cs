using FRC.NetworkTables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using AForge.Video;
using System.Windows.Forms.DataVisualization.Charting;
using System.Linq;


namespace Dash4572 {
    public partial class DashboardDisplay : Form {

        NetworkTableInstance inst;

        NetworkTableEntry frameRateEntry;
        NetworkTableEntry loopTimeEntry;
        NetworkTableEntry frameTimeEntry;

        Bitmap staticBuffer = null;
        MJPEGStream videoStream;
        Bitmap latestFrame = null;
        Bitmap videoStaticBuffer = null;

        Series frameTimeSeries;
        Series loopTimeSeries;

        bool videoStreamStarted = false;


        public DashboardDisplay() {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void VideoStream_NewFrame(object sender, NewFrameEventArgs eventArgs) {
            try {
                latestFrame = new Bitmap(eventArgs.Frame);
                this.videoPanel.Invalidate();
            } catch (Exception ex) {
                System.Console.WriteLine($"{ex.Message}");
            }
        }


        private void LoadData() {

            frameTimeSeries = this.roboRioProcessingChart.Series["Frame Time"];
            loopTimeSeries = this.roboRioProcessingChart.Series["Loop Time"];
            for (int i = 0; i < 500; i++) {
                frameTimeSeries.Points.AddXY(i + 1, 0);
                loopTimeSeries.Points.AddXY(i + 1, 0);
            }

            foreach (NetworkInterface netInterface in NetworkInterface.GetAllNetworkInterfaces()) {
                IPInterfaceProperties ipProps = netInterface.GetIPProperties();
                foreach (UnicastIPAddressInformation addr in ipProps.UnicastAddresses) {
                    if (addr.Address.ToString().Contains("10.45.72")) {
                        inst.GetTable("performance").GetEntry("IP_Address").SetString(addr.Address.ToString());
                    }
                }
            }
        }




        private void Form1_Load(object sender, EventArgs e) {

            LoadData();

            string serverIP = serverTextBox.Text;
            inst.StartClient(serverIP);
            this.cameraSelectionComboBox.SelectedIndex = 0;


            Timer timer = new Timer();
            timer.Interval = (33); // mSecs
            timer.Tick += Timer_Tick;

            timer.Start();
        }

        private void connectToServerButton_Click(object sender, EventArgs e) {
            string serverIP = serverTextBox.Text;
            inst.StartClient(serverIP);
            System.Threading.Thread.Sleep(500);
        }




        private void Timer_Tick(object sender, EventArgs e) {
            try {

                //frameRateTextBox.Text = frameRateEntry.GetDouble(0.0).ToString();

                DataPoint lastPoint = frameTimeSeries.Points.Last();
                frameTimeSeries.Points.AddXY(lastPoint.XValue + 1, frameTimeEntry.GetDouble(0.0));
                frameTimeSeries.Points.RemoveAt(0);

                DataPoint lastLoopTimePoint = loopTimeSeries.Points.Last();
                loopTimeSeries.Points.AddXY(lastPoint.XValue + 1, loopTimeEntry.GetDouble(0.0));
                loopTimeSeries.Points.RemoveAt(0);

                this.roboRioProcessingChart.ChartAreas[0].RecalculateAxesScale();

                if (!videoStreamStarted) {
                    string ip = this.inst.GetEntry("robot_cam/server_ip").GetString("none");
                    if (ip != "none") {
                        videoStream = new MJPEGStream($"http://{ip}:1180");
                        videoStream.NewFrame += VideoStream_NewFrame;
                        videoStream.Start();
                        videoStreamStarted = true;
                    }
                }

                this.Invalidate();

            } catch {

            }
        }


        public string ServerIP {
            get { return this.serverTextBox.Text; }
            set { this.serverTextBox.Text = value; }
        }


        public NetworkTableInstance NTINstance {
            get { return inst; }
            set { inst = value; }
        }

        private void videoPanel_Paint(object sender, PaintEventArgs e) {
            Graphics g;
            if (videoStaticBuffer == null) {
                videoStaticBuffer = new Bitmap(this.videoPanel.Width, this.videoPanel.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            }
            g = Graphics.FromImage(videoStaticBuffer);
            if (latestFrame != null) {
                g.DrawImage(latestFrame, 0, 0, this.videoPanel.Width, this.videoPanel.Height);
            }
            e.Graphics.DrawImageUnscaled(videoStaticBuffer, 0, 0);

        }

        private void DashboardDisplay_FormClosing(object sender, FormClosingEventArgs e) {
            this.videoStream.Stop();
        }
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e) {
            int cameraNumber = this.cameraSelectionComboBox.SelectedIndex;
            inst.GetEntry("robot_cam/camera_number").SetDouble((double)cameraNumber);
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e) {
            inst.GetEntry("robot_cam/perform_object_detection").SetBoolean(this.objectDetectionCheckBox.Checked);
        }

        private void objectDetectionCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cameraSelectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (this.comboBox1.GetItemText(this.comboBox1.SelectedItem) == "1_TarmacB1_to_BBallD_BBallC")
            {
                inst.GetEntry("pathSelected").SetString("1_TarmacB1_to_BBallD_BBallC");
                pictureBox1.BackgroundImage = Properties.Resources.Graph_1_TarmacB1_to_BBallD_BBallC;
                pictureBoxLarge.BackgroundImage = Properties.Resources.Graph_1_TarmacB1_to_BBallD_BBallC;
            }
           else if (this.comboBox1.GetItemText(this.comboBox1.SelectedItem) == "0_TarmacB1_to_BBallD")
            {
                inst.GetEntry("pathSelected").SetString("0_TarmacB1_to_BBallD");
                pictureBox1.BackgroundImage = Properties.Resources.Graph_0_TarmacB1_to_BBallD;
                pictureBoxLarge.BackgroundImage = Properties.Resources.Graph_0_TarmacB1_to_BBallD;
            }
            else if (this.comboBox1.GetItemText(this.comboBox1.SelectedItem) == "2_TarmacB2_to_BBallB")
            {
                inst.GetEntry("pathSelected").SetString("2_TarmacB2_to_BBallB");
                pictureBox1.BackgroundImage = Properties.Resources.Graph_2_TarmacB2_to_BBallB;
                pictureBoxLarge.BackgroundImage = Properties.Resources.Graph_2_TarmacB2_to_BBallB;
            }
            else if (this.comboBox1.GetItemText(this.comboBox1.SelectedItem) == "2_TarmacB2_to_BBallB")
            {
                inst.GetEntry("pathSelected").SetString("2_TarmacB2_to_BBallB");
                pictureBox1.BackgroundImage = Properties.Resources.Graph_2_TarmacB2_to_BBallB;
                pictureBoxLarge.BackgroundImage = Properties.Resources.Graph_2_TarmacB2_to_BBallB;
            }
            else if (this.comboBox1.GetItemText(this.comboBox1.SelectedItem) == "4_TarmacB2_to_BBallC")
            {
                inst.GetEntry("pathSelected").SetString("4_TarmacB2_to_BBallC");
                pictureBox1.BackgroundImage = Properties.Resources.Graph_4_TarmacB2_to_BBallC;
                pictureBoxLarge.BackgroundImage = Properties.Resources.Graph_4_TarmacB2_to_BBallC;
            }
            else if (this.comboBox1.GetItemText(this.comboBox1.SelectedItem) == "1_TarmacB1_to_BBallD_BBallC")
            {
                inst.GetEntry("pathSelected").SetString("1_TarmacB1_to_BBallD_BBallC");
                pictureBox1.BackgroundImage = Properties.Resources.Graph_1_TarmacB1_to_BBallD_BBallC;
                pictureBoxLarge.BackgroundImage = Properties.Resources.Graph_1_TarmacB1_to_BBallD_BBallC;
            }
            else if (this.comboBox1.GetItemText(this.comboBox1.SelectedItem) == "3_TarmacB2_to_BBallB_BBallC")
            {
                inst.GetEntry("pathSelected").SetString("3_TarmacB2_to_BBallB_BBallC");
                pictureBox1.BackgroundImage = Properties.Resources.Graph_3_TarmacB2_to_BBallB_BBallC;
                pictureBoxLarge.BackgroundImage = Properties.Resources.Graph_3_TarmacB2_to_BBallB_BBallC;
            }
            else if (this.comboBox1.GetItemText(this.comboBox1.SelectedItem) == "4_TarmacB2_to_BBallC")
            {
                inst.GetEntry("pathSelected").SetString("4_TarmacB2_to_BBallC");
                pictureBox1.BackgroundImage = Properties.Resources.Graph_4_TarmacB2_to_BBallC;
                pictureBoxLarge.BackgroundImage = Properties.Resources.Graph_4_TarmacB2_to_BBallC;
            }
            else if (this.comboBox1.GetItemText(this.comboBox1.SelectedItem) == "5_TarmacB2_to_BBallC_BBallC")
            {
                inst.GetEntry("pathSelected").SetString("5_TarmacB2_to_BBallC_BBallC");
                pictureBox1.BackgroundImage = Properties.Resources.Graph_5_TarmacB2_to_BBallC_BBallC;
                pictureBoxLarge.BackgroundImage = Properties.Resources.Graph_5_TarmacB2_to_BBallC_BBallC;
            }
            else if (this.comboBox1.GetItemText(this.comboBox1.SelectedItem) == "6_TarmacB2_to_BBallC_BBallD")
            {
                inst.GetEntry("pathSelected").SetString("6_TarmacB2_to_BBallC_BBallD");
                pictureBox1.BackgroundImage = Properties.Resources.Graph_6_TarmacB2_to_BBallC_BBallD;
                pictureBoxLarge.BackgroundImage = Properties.Resources.Graph_6_TarmacB2_to_BBallC_BBallD;
            }
            else if (this.comboBox1.GetItemText(this.comboBox1.SelectedItem) == "7_TarmacR1_to_RBallD")
            {
                inst.GetEntry("pathSelected").SetString("7_TarmacR1_to_RBallD");
                pictureBox1.BackgroundImage = Properties.Resources.Graph_7_TarmacR1_to_RBallD;
                pictureBoxLarge.BackgroundImage = Properties.Resources.Graph_7_TarmacR1_to_RBallD;
            }
            else if (this.comboBox1.GetItemText(this.comboBox1.SelectedItem) == "8_TarmacR1_to_RBallD_RBallE")
            {
                inst.GetEntry("pathSelected").SetString("8_TarmacR1_to_RBallD_RBallE");
                pictureBox1.BackgroundImage = Properties.Resources.Graph_8_TarmacR1_to_RBallD_RBallE;
                pictureBoxLarge.BackgroundImage = Properties.Resources.Graph_8_TarmacR1_to_RBallD_RBallE;
            }
            else if (this.comboBox1.GetItemText(this.comboBox1.SelectedItem) == "9_TarmacR1_to_RBallE")
            {
                inst.GetEntry("pathSelected").SetString("9_TarmacR1_to_RBallE");
                pictureBox1.BackgroundImage = Properties.Resources.Graph_9_TarmacR1_to_RBallE;
                pictureBoxLarge.BackgroundImage = Properties.Resources.Graph_9_TarmacR1_to_RBallE;
            }
            else if (this.comboBox1.GetItemText(this.comboBox1.SelectedItem) == "10_TarmacR1_to_RBallE_RBallF")
            {
                inst.GetEntry("pathSelected").SetString("10_TarmacR1_to_RBallE_RBallF");
                pictureBox1.BackgroundImage = Properties.Resources.Graph_10_TarmacR1_to_RBallE_RBallF;
                pictureBoxLarge.BackgroundImage = Properties.Resources.Graph_10_TarmacR1_to_RBallE_RBallF;
            }
            else if (this.comboBox1.GetItemText(this.comboBox1.SelectedItem) == "11_TarmacR2_to_RBallF")
            {
                inst.GetEntry("pathSelected").SetString("11_TarmacR2_to_RBallF");
                pictureBox1.BackgroundImage = Properties.Resources.Graph_11_TarmacR2_to_RBallF;
                pictureBoxLarge.BackgroundImage = Properties.Resources.Graph_11_TarmacR2_to_RBallF;
            }
            else if (this.comboBox1.GetItemText(this.comboBox1.SelectedItem) == "12_TarmacR2_to_RBallF_RBallE")
            {
                inst.GetEntry("pathSelected").SetString("12_TarmacR2_to_RBallF_RBallE");
                pictureBox1.BackgroundImage = Properties.Resources.Graph_12_TarmacR2_to_RBallF_RBallE;
                pictureBoxLarge.BackgroundImage = Properties.Resources.Graph_12_TarmacR2_to_RBallF_RBallE;
            }
            else if (this.comboBox1.GetItemText(this.comboBox1.SelectedItem) == "20_TarmacB1_Back_Off_Tarmac")
            {
                inst.GetEntry("pathSelected").SetString("20_TarmacB1_Back_Off_Tarmac");
                pictureBox1.BackgroundImage = Properties.Resources.Graph_20_TarmacB1_Back_Off_Tarmac;
                pictureBoxLarge.BackgroundImage = Properties.Resources.Graph_20_TarmacB1_Back_Off_Tarmac;
            }
            else if (this.comboBox1.GetItemText(this.comboBox1.SelectedItem) == "21_TarmacB1_to_BBallD_Vicinity")
            {
                inst.GetEntry("pathSelected").SetString("21_TarmacB1_to_BBallD_Vicinity");
                pictureBox1.BackgroundImage = Properties.Resources.Graph_21_TarmacB1_to_BBallD_Vicinity;
                pictureBoxLarge.BackgroundImage = Properties.Resources.Graph_21_TarmacB1_to_BBallD_Vicinity;
            }
            else if (this.comboBox1.GetItemText(this.comboBox1.SelectedItem) == "22_TarmacR1_Back_Off_Tarmac")
            {
                inst.GetEntry("pathSelected").SetString("22_TarmacR1_Back_Off_Tarmac");
                pictureBox1.BackgroundImage = Properties.Resources.Graph_22_TarmacR1_Back_Off_Tarmac;
                pictureBoxLarge.BackgroundImage = Properties.Resources.Graph_22_TarmacR1_Back_Off_Tarmac;
            }
            else if (this.comboBox1.GetItemText(this.comboBox1.SelectedItem) == "23_TarmacB2_to_BBallB_Vicinity")
            {
                inst.GetEntry("pathSelected").SetString("23_TarmacB2_to_BBallB_Vicinity");
                pictureBox1.BackgroundImage = Properties.Resources.Graph_23_TarmacB2_to_BBallB_Vicinity;
                pictureBoxLarge.BackgroundImage = Properties.Resources.Graph_23_TarmacB2_to_BBallB_Vicinity;
            }
            else if (this.comboBox1.GetItemText(this.comboBox1.SelectedItem) == "24_TarmacB2_to_BBallC_Vicinity")
            {
                inst.GetEntry("pathSelected").SetString("24_TarmacB2_to_BBallC_Vicinity");
                pictureBox1.BackgroundImage = Properties.Resources.Graph_24_TarmacB2_to_BBallC_Vicinity;
                pictureBoxLarge.BackgroundImage = Properties.Resources.Graph_24_TarmacB2_to_BBallC_Vicinity;
            }
            else if (this.comboBox1.GetItemText(this.comboBox1.SelectedItem) == "25_TarmacR1_to_RBallD_Vicinity")
            {
                inst.GetEntry("pathSelected").SetString("25_TarmacR1_to_RBallD_Vicinity");
                pictureBox1.BackgroundImage = Properties.Resources.Graph_25_TarmacR1_to_RBallD_Vicinity;
                pictureBoxLarge.BackgroundImage = Properties.Resources.Graph_25_TarmacR1_to_RBallD_Vicinity;
            }
            else if (this.comboBox1.GetItemText(this.comboBox1.SelectedItem) == "26_TarmacR1_to_RBallE_Vicinity")
            {
                inst.GetEntry("pathSelected").SetString("26_TarmacR1_to_RBallE_Vicinity");
                pictureBox1.BackgroundImage = Properties.Resources.Graph_26_TarmacR1_to_RBallE_Vicinity;
                pictureBoxLarge.BackgroundImage = Properties.Resources.Graph_26_TarmacR1_to_RBallE_Vicinity;
            }
            else if (this.comboBox1.GetItemText(this.comboBox1.SelectedItem) == "27_TarmacR2_to_RBallF_Vicinity")
            {
                inst.GetEntry("pathSelected").SetString("27_TarmacR2_to_RBallF_Vicinity");
                pictureBox1.BackgroundImage = Properties.Resources.Graph_27_TarmacR2_to_RBallF_Vicinity;
                pictureBoxLarge.BackgroundImage = Properties.Resources.Graph_27_TarmacR2_to_RBallF_Vicinity;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBoxLarge_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Text = inst.GetEntry("driverStation/state").GetString("");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.comboBox2.GetItemText(this.comboBox2.SelectedItem) == "Blue")
            {
                comboBox1.Items.Remove("7_TarmacR1_to_RBallD");
                comboBox1.Items.Remove("9_TarmacR1_to_RBallE");
                comboBox1.Items.Remove("11_TarmacR2_to_RBallF");
                comboBox1.Items.Remove("10_TarmacR1_to_RBallE_RBallF");
                comboBox1.Items.Remove("8_TarmacR1_to_RBallD_RBallE");
                comboBox1.Items.Remove("12_TarmacR2_to_RBallF_RBallE");
                comboBox1.Items.Remove("22_TarmacR1_Back_Off_Tarmac");
                comboBox1.Items.Remove("25_TarmacR1_to_RBallD_Vicinity");
                comboBox1.Items.Remove("26_TarmacR1_to_RBallE_Vicinity");
                comboBox1.Items.Remove("27_TarmacR2_to_RBallF_Vicinity");
            }
            if (this.comboBox2.GetItemText(this.comboBox2.SelectedItem) == "Red")
            {
                comboBox1.Items.Remove("0_TarmacB1_to_BBallD");
                comboBox1.Items.Remove("2_TarmacB2_to_BBallB");
                comboBox1.Items.Remove("4_TarmacB2_to_BBallC");
                comboBox1.Items.Remove("1_TarmacB1_to_BBallD_BBallC");
                comboBox1.Items.Remove("3_TarmacB2_to_BBallB_BBallC");
                comboBox1.Items.Remove("5_TarmacB2_to_BBallC_BBallB");
                comboBox1.Items.Remove("6_TarmacB2_to_BBallC_BBallD");
                comboBox1.Items.Remove("20_TarmacB1_Back_Off_Tarmac");
                comboBox1.Items.Remove("21_TarmacB1_to_BBallD_Vicinity");
                comboBox1.Items.Remove("23_TarmacB2_to_BBallB_Vicinity");
                comboBox1.Items.Remove("24_TarmacB2_to_BBallC_Vicinity");
            }
        }
    }
}

