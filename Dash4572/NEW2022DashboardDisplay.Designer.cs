namespace Dash4572
{
    partial class DashboardDisplay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.performanceTab = new System.Windows.Forms.TabPage();
            this.roboRioProcessingChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.visionProcessingTab = new System.Windows.Forms.TabPage();
            this.mainTab = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.objectDetectionCheckBox = new System.Windows.Forms.CheckBox();
            this.cameraSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.connectToServerButton = new System.Windows.Forms.Button();
            this.serverTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.videoPanel = new Dash4572.DoubleBufferedPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pathAllianceSelectTab = new System.Windows.Forms.TabPage();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBoxLarge = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.performanceTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roboRioProcessingChart)).BeginInit();
            this.mainTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.pathAllianceSelectTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLarge)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // performanceTab
            // 
            this.performanceTab.Controls.Add(this.roboRioProcessingChart);
            this.performanceTab.Location = new System.Drawing.Point(4, 29);
            this.performanceTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.performanceTab.Name = "performanceTab";
            this.performanceTab.Size = new System.Drawing.Size(1435, 903);
            this.performanceTab.TabIndex = 2;
            this.performanceTab.Text = "Performance";
            this.performanceTab.UseVisualStyleBackColor = true;
            // 
            // roboRioProcessingChart
            // 
            chartArea1.Name = "ChartArea1";
            this.roboRioProcessingChart.ChartAreas.Add(chartArea1);
            this.roboRioProcessingChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.roboRioProcessingChart.Legends.Add(legend1);
            this.roboRioProcessingChart.Location = new System.Drawing.Point(0, 0);
            this.roboRioProcessingChart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roboRioProcessingChart.Name = "roboRioProcessingChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Frame Time";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Loop Time";
            this.roboRioProcessingChart.Series.Add(series1);
            this.roboRioProcessingChart.Series.Add(series2);
            this.roboRioProcessingChart.Size = new System.Drawing.Size(1435, 903);
            this.roboRioProcessingChart.TabIndex = 0;
            this.roboRioProcessingChart.Text = "Robo-Rio Processing Rate";
            // 
            // visionProcessingTab
            // 
            this.visionProcessingTab.Location = new System.Drawing.Point(4, 29);
            this.visionProcessingTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.visionProcessingTab.Name = "visionProcessingTab";
            this.visionProcessingTab.Size = new System.Drawing.Size(1435, 903);
            this.visionProcessingTab.TabIndex = 1;
            this.visionProcessingTab.Text = "Vision Processing";
            this.visionProcessingTab.UseVisualStyleBackColor = true;
            // 
            // mainTab
            // 
            this.mainTab.BackColor = System.Drawing.Color.White;
            this.mainTab.Controls.Add(this.label5);
            this.mainTab.Controls.Add(this.label2);
            this.mainTab.Controls.Add(this.pictureBox1);
            this.mainTab.Controls.Add(this.label3);
            this.mainTab.Controls.Add(this.objectDetectionCheckBox);
            this.mainTab.Controls.Add(this.cameraSelectionComboBox);
            this.mainTab.Controls.Add(this.connectToServerButton);
            this.mainTab.Controls.Add(this.serverTextBox);
            this.mainTab.Controls.Add(this.label15);
            this.mainTab.Controls.Add(this.videoPanel);
            this.mainTab.Controls.Add(this.label1);
            this.mainTab.Location = new System.Drawing.Point(4, 29);
            this.mainTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainTab.Name = "mainTab";
            this.mainTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainTab.Size = new System.Drawing.Size(1435, 903);
            this.mainTab.TabIndex = 0;
            this.mainTab.Text = "Main";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(33, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 36);
            this.label5.TabIndex = 35;
            this.label5.Text = "   ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(33, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 41);
            this.label2.TabIndex = 34;
            this.label2.Text = "Robot State:";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Dash4572.Properties.Resources.nopath;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(32, 550);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 322);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(27, 522);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Selected Path:";
            // 
            // objectDetectionCheckBox
            // 
            this.objectDetectionCheckBox.AutoSize = true;
            this.objectDetectionCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.objectDetectionCheckBox.Location = new System.Drawing.Point(32, 203);
            this.objectDetectionCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.objectDetectionCheckBox.Name = "objectDetectionCheckBox";
            this.objectDetectionCheckBox.Size = new System.Drawing.Size(237, 29);
            this.objectDetectionCheckBox.TabIndex = 30;
            this.objectDetectionCheckBox.Text = "Show Object Detection";
            this.objectDetectionCheckBox.UseVisualStyleBackColor = true;
            this.objectDetectionCheckBox.CheckedChanged += new System.EventHandler(this.objectDetectionCheckBox_CheckedChanged);
            this.objectDetectionCheckBox.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
            // 
            // cameraSelectionComboBox
            // 
            this.cameraSelectionComboBox.FormattingEnabled = true;
            this.cameraSelectionComboBox.Items.AddRange(new object[] {
            "Driver Cam",
            "Alignment Cam"});
            this.cameraSelectionComboBox.Location = new System.Drawing.Point(32, 289);
            this.cameraSelectionComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cameraSelectionComboBox.Name = "cameraSelectionComboBox";
            this.cameraSelectionComboBox.Size = new System.Drawing.Size(180, 28);
            this.cameraSelectionComboBox.TabIndex = 28;
            this.cameraSelectionComboBox.SelectedIndexChanged += new System.EventHandler(this.cameraSelectionComboBox_SelectedIndexChanged);
            this.cameraSelectionComboBox.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // connectToServerButton
            // 
            this.connectToServerButton.Location = new System.Drawing.Point(82, 128);
            this.connectToServerButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.connectToServerButton.Name = "connectToServerButton";
            this.connectToServerButton.Size = new System.Drawing.Size(112, 35);
            this.connectToServerButton.TabIndex = 27;
            this.connectToServerButton.Text = "Connect";
            this.connectToServerButton.UseVisualStyleBackColor = true;
            this.connectToServerButton.Click += new System.EventHandler(this.connectToServerButton_Click);
            // 
            // serverTextBox
            // 
            this.serverTextBox.Enabled = false;
            this.serverTextBox.Location = new System.Drawing.Point(33, 88);
            this.serverTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.serverTextBox.Name = "serverTextBox";
            this.serverTextBox.Size = new System.Drawing.Size(228, 26);
            this.serverTextBox.TabIndex = 26;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label15.Location = new System.Drawing.Point(28, 62);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(171, 25);
            this.label15.TabIndex = 25;
            this.label15.Text = "Server IP Address";
            // 
            // videoPanel
            // 
            this.videoPanel.BackColor = System.Drawing.Color.Black;
            this.videoPanel.Location = new System.Drawing.Point(363, 28);
            this.videoPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.videoPanel.Name = "videoPanel";
            this.videoPanel.Size = new System.Drawing.Size(1054, 774);
            this.videoPanel.TabIndex = 24;
            this.videoPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.videoPanel_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(28, 262);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "Camera Selection";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.mainTab);
            this.tabControl1.Controls.Add(this.visionProcessingTab);
            this.tabControl1.Controls.Add(this.performanceTab);
            this.tabControl1.Controls.Add(this.pathAllianceSelectTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1443, 936);
            this.tabControl1.TabIndex = 2;
            // 
            // pathAllianceSelectTab
            // 
            this.pathAllianceSelectTab.BackColor = System.Drawing.Color.White;
            this.pathAllianceSelectTab.Controls.Add(this.comboBox2);
            this.pathAllianceSelectTab.Controls.Add(this.label6);
            this.pathAllianceSelectTab.Controls.Add(this.pictureBoxLarge);
            this.pathAllianceSelectTab.Controls.Add(this.label4);
            this.pathAllianceSelectTab.Controls.Add(this.comboBox1);
            this.pathAllianceSelectTab.Location = new System.Drawing.Point(4, 29);
            this.pathAllianceSelectTab.Name = "pathAllianceSelectTab";
            this.pathAllianceSelectTab.Size = new System.Drawing.Size(1435, 903);
            this.pathAllianceSelectTab.TabIndex = 3;
            this.pathAllianceSelectTab.Text = "Path/Alliance Selection";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Red",
            "Blue"});
            this.comboBox2.Location = new System.Drawing.Point(62, 85);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 28);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(57, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Select an alliance:";
            // 
            // pictureBoxLarge
            // 
            this.pictureBoxLarge.BackgroundImage = global::Dash4572.Properties.Resources.nopath;
            this.pictureBoxLarge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLarge.Location = new System.Drawing.Point(416, 63);
            this.pictureBoxLarge.Name = "pictureBoxLarge";
            this.pictureBoxLarge.Size = new System.Drawing.Size(661, 829);
            this.pictureBoxLarge.TabIndex = 2;
            this.pictureBoxLarge.TabStop = false;
            this.pictureBoxLarge.Click += new System.EventHandler(this.pictureBoxLarge_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(57, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Select a path:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0_TarmacB1_to_BBallD",
            "2_TarmacB2_to_BBallB",
            "4_TarmacB2_to_BBallC",
            "1_TarmacB1_to_BBallD_BBallC",
            "3_TarmacB2_to_BBallB_BBallC",
            "5_TarmacB2_to_BBallC_BBallB",
            "6_TarmacB2_to_BBallC_BBallD",
            "7_TarmacR1_to_RBallD",
            "9_TarmacR1_to_RBallE",
            "11_TarmacR2_to_RBallF",
            "8_TarmacR1_to_RBallD_RBallE",
            "10_TarmacR1_to_RBallE_RBallF",
            "12_TarmacR2_to_RBallF_RBallE",
            "20_TarmacB1_Back_Off_Tarmac",
            "21_TarmacB1_to_BBallD_Vicinity",
            "22_TarmacR1_Back_Off_Tarmac",
            "23_TarmacB2_to_BBallB_Vicinity",
            "24_TarmacB2_to_BBallC_Vicinity",
            "25_TarmacR1_to_RBallD_Vicinity",
            "26_TarmacR1_to_RBallE_Vicinity",
            "27_TarmacR2_to_RBallF_Vicinity"});
            this.comboBox1.Location = new System.Drawing.Point(62, 181);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(266, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // DashboardDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 936);
            this.Controls.Add(this.tabControl1);
            this.Name = "DashboardDisplay";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DashboardDisplay_FormClosing);
            this.performanceTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roboRioProcessingChart)).EndInit();
            this.mainTab.ResumeLayout(false);
            this.mainTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.pathAllianceSelectTab.ResumeLayout(false);
            this.pathAllianceSelectTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLarge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.TabPage performanceTab;
        private System.Windows.Forms.DataVisualization.Charting.Chart roboRioProcessingChart;
        private System.Windows.Forms.TabPage visionProcessingTab;
        private System.Windows.Forms.TabPage mainTab;
        private System.Windows.Forms.Button connectToServerButton;
        private System.Windows.Forms.TextBox serverTextBox;
        private System.Windows.Forms.Label label15;
        private DoubleBufferedPanel videoPanel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cameraSelectionComboBox;
        private System.Windows.Forms.CheckBox objectDetectionCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage pathAllianceSelectTab;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBoxLarge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label6;
    }
}

