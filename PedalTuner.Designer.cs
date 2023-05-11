﻿namespace MattScerri.Fanatec.V3.PedalCurve
{
    partial class PedalTuner
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PedalTuner));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.chartPedalCurve = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnMonitor = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbFilterType = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tbFactor = new System.Windows.Forms.TextBox();
            this.lblFactor = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tbInterval = new System.Windows.Forms.TextBox();
            this.lblInterval = new System.Windows.Forms.Label();
            this.btnSetParams = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbOutput = new System.Windows.Forms.TrackBar();
            this.lblDst = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbSource = new System.Windows.Forms.TrackBar();
            this.lblSource = new System.Windows.Forms.Label();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.tsLabelInputDevice = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsLabelProfile = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPedalCurve)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbOutput)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSource)).BeginInit();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(564, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputDeviceToolStripMenuItem,
            this.gameSetupToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // inputDeviceToolStripMenuItem
            // 
            this.inputDeviceToolStripMenuItem.Name = "inputDeviceToolStripMenuItem";
            this.inputDeviceToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.inputDeviceToolStripMenuItem.Text = "Input Device";
            this.inputDeviceToolStripMenuItem.Click += new System.EventHandler(this.inputDeviceToolStripMenuItem_Click);
            // 
            // gameSetupToolStripMenuItem
            // 
            this.gameSetupToolStripMenuItem.Name = "gameSetupToolStripMenuItem";
            this.gameSetupToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.gameSetupToolStripMenuItem.Text = "Game setup";
            this.gameSetupToolStripMenuItem.Click += new System.EventHandler(this.gameSetupToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Controls.Add(this.statusBar);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 24);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(564, 479);
            this.pnlMain.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.panel1.Size = new System.Drawing.Size(564, 457);
            this.panel1.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.chartPedalCurve);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(10, 189);
            this.panel9.Margin = new System.Windows.Forms.Padding(15);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(544, 237);
            this.panel9.TabIndex = 4;
            // 
            // chartPedalCurve
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPedalCurve.ChartAreas.Add(chartArea1);
            this.chartPedalCurve.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartPedalCurve.Location = new System.Drawing.Point(0, 0);
            this.chartPedalCurve.Name = "chartPedalCurve";
            this.chartPedalCurve.Size = new System.Drawing.Size(544, 237);
            this.chartPedalCurve.TabIndex = 0;
            this.chartPedalCurve.Text = "chart1";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnMonitor);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(10, 426);
            this.panel8.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(544, 22);
            this.panel8.TabIndex = 3;
            // 
            // btnMonitor
            // 
            this.btnMonitor.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMonitor.Location = new System.Drawing.Point(466, 0);
            this.btnMonitor.Margin = new System.Windows.Forms.Padding(2);
            this.btnMonitor.Name = "btnMonitor";
            this.btnMonitor.Size = new System.Drawing.Size(78, 22);
            this.btnMonitor.TabIndex = 0;
            this.btnMonitor.Text = "Monitor";
            this.btnMonitor.UseVisualStyleBackColor = true;
            this.btnMonitor.Click += new System.EventHandler(this.btnMonitor_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(10, 110);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.panel4.Size = new System.Drawing.Size(544, 79);
            this.panel4.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.23166F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.76834F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 157F));
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSetParams, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 9);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(524, 61);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cbFilterType);
            this.panel5.Controls.Add(this.lblFilter);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(2, 2);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(217, 28);
            this.panel5.TabIndex = 0;
            // 
            // cbFilterType
            // 
            this.cbFilterType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbFilterType.FormattingEnabled = true;
            this.cbFilterType.Location = new System.Drawing.Point(39, 0);
            this.cbFilterType.Margin = new System.Windows.Forms.Padding(2);
            this.cbFilterType.Name = "cbFilterType";
            this.cbFilterType.Size = new System.Drawing.Size(178, 23);
            this.cbFilterType.TabIndex = 1;
            this.cbFilterType.SelectionChangeCommitted += new System.EventHandler(this.cbFilterType_SelectionChangeCommitted);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblFilter.Location = new System.Drawing.Point(0, 0);
            this.lblFilter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(39, 15);
            this.lblFilter.TabIndex = 0;
            this.lblFilter.Text = "Filter: ";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tbFactor);
            this.panel6.Controls.Add(this.lblFactor);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(223, 2);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(141, 28);
            this.panel6.TabIndex = 1;
            // 
            // tbFactor
            // 
            this.tbFactor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbFactor.Location = new System.Drawing.Point(40, 0);
            this.tbFactor.Margin = new System.Windows.Forms.Padding(2);
            this.tbFactor.Name = "tbFactor";
            this.tbFactor.Size = new System.Drawing.Size(101, 23);
            this.tbFactor.TabIndex = 1;
            this.tbFactor.Text = "2";
            this.tbFactor.TextChanged += new System.EventHandler(this.tbFactor_TextChanged);
            // 
            // lblFactor
            // 
            this.lblFactor.AutoSize = true;
            this.lblFactor.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblFactor.Location = new System.Drawing.Point(0, 0);
            this.lblFactor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFactor.Name = "lblFactor";
            this.lblFactor.Size = new System.Drawing.Size(40, 15);
            this.lblFactor.TabIndex = 0;
            this.lblFactor.Text = "Factor";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.tbInterval);
            this.panel7.Controls.Add(this.lblInterval);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(368, 2);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(154, 28);
            this.panel7.TabIndex = 2;
            // 
            // tbInterval
            // 
            this.tbInterval.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbInterval.Location = new System.Drawing.Point(46, 0);
            this.tbInterval.Margin = new System.Windows.Forms.Padding(2);
            this.tbInterval.Name = "tbInterval";
            this.tbInterval.Size = new System.Drawing.Size(106, 23);
            this.tbInterval.TabIndex = 1;
            this.tbInterval.Text = "25";
            this.tbInterval.TextChanged += new System.EventHandler(this.tbInterval_TextChanged);
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblInterval.Location = new System.Drawing.Point(0, 0);
            this.lblInterval.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(46, 15);
            this.lblInterval.TabIndex = 0;
            this.lblInterval.Text = "Interval";
            // 
            // btnSetParams
            // 
            this.btnSetParams.Location = new System.Drawing.Point(2, 34);
            this.btnSetParams.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetParams.Name = "btnSetParams";
            this.btnSetParams.Size = new System.Drawing.Size(78, 20);
            this.btnSetParams.TabIndex = 3;
            this.btnSetParams.Text = "Set Params";
            this.btnSetParams.UseVisualStyleBackColor = true;
            this.btnSetParams.Click += new System.EventHandler(this.btnSetParams_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbOutput);
            this.panel3.Controls.Add(this.lblDst);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(10, 58);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.panel3.Size = new System.Drawing.Size(544, 52);
            this.panel3.TabIndex = 1;
            // 
            // tbOutput
            // 
            this.tbOutput.AutoSize = false;
            this.tbOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbOutput.Location = new System.Drawing.Point(37, 9);
            this.tbOutput.Margin = new System.Windows.Forms.Padding(2);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(497, 34);
            this.tbOutput.TabIndex = 1;
            // 
            // lblDst
            // 
            this.lblDst.AutoSize = true;
            this.lblDst.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDst.Location = new System.Drawing.Point(10, 9);
            this.lblDst.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDst.Name = "lblDst";
            this.lblDst.Size = new System.Drawing.Size(27, 15);
            this.lblDst.TabIndex = 0;
            this.lblDst.Text = "Out";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbSource);
            this.panel2.Controls.Add(this.lblSource);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 9);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.panel2.Size = new System.Drawing.Size(544, 49);
            this.panel2.TabIndex = 0;
            // 
            // tbSource
            // 
            this.tbSource.AutoSize = false;
            this.tbSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSource.Location = new System.Drawing.Point(36, 9);
            this.tbSource.Margin = new System.Windows.Forms.Padding(2);
            this.tbSource.Name = "tbSource";
            this.tbSource.Size = new System.Drawing.Size(498, 31);
            this.tbSource.TabIndex = 1;
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSource.Location = new System.Drawing.Point(10, 9);
            this.lblSource.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(26, 15);
            this.lblSource.TabIndex = 0;
            this.lblSource.Text = "In   ";
            // 
            // statusBar
            // 
            this.statusBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLabelInputDevice,
            this.tsLabelProfile,
            this.lblStatus});
            this.statusBar.Location = new System.Drawing.Point(0, 457);
            this.statusBar.Name = "statusBar";
            this.statusBar.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusBar.Size = new System.Drawing.Size(564, 22);
            this.statusBar.TabIndex = 0;
            this.statusBar.Text = "statusStrip1";
            // 
            // tsLabelInputDevice
            // 
            this.tsLabelInputDevice.Name = "tsLabelInputDevice";
            this.tsLabelInputDevice.Size = new System.Drawing.Size(156, 17);
            this.tsLabelInputDevice.Text = "Connected To: <No Device>";
            // 
            // tsLabelProfile
            // 
            this.tsLabelProfile.Name = "tsLabelProfile";
            this.tsLabelProfile.Size = new System.Drawing.Size(131, 17);
            this.tsLabelProfile.Text = "Filter: <None Selected>";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(26, 17);
            this.lblStatus.Text = "Idle";
            // 
            // PedalTuner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 503);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PedalTuner";
            this.Text = "PedalTuner";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartPedalCurve)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbOutput)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSource)).EndInit();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem inputDeviceToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Panel pnlMain;
        private StatusStrip statusBar;
        private ToolStripMenuItem gameSetupToolStripMenuItem;
        private ToolStripStatusLabel tsLabelInputDevice;
        private ToolStripStatusLabel tsLabelProfile;
        private Panel panel1;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel5;
        private ComboBox cbFilterType;
        private Label lblFilter;
        private Panel panel6;
        private TextBox tbFactor;
        private Label lblFactor;
        private Panel panel3;
        private TrackBar tbOutput;
        private Label lblDst;
        private Panel panel2;
        private TrackBar tbSource;
        private Label lblSource;
        private Panel panel8;
        private Button btnMonitor;
        private Panel panel7;
        private TextBox tbInterval;
        private Label lblInterval;
        private ToolStripStatusLabel lblStatus;
        private Button btnSetParams;
        private Panel panel9;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPedalCurve;
    }
}