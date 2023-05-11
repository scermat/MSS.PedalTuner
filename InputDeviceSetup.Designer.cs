namespace MattScerri.Fanatec.V3.PedalCurve
{
    partial class InputDeviceSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputDeviceSetup));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.gbControlParams = new System.Windows.Forms.GroupBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblControllerProps = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lblCalibrate = new System.Windows.Forms.Label();
            this.btnCalibrate = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.tbBrakeSignal = new System.Windows.Forms.TrackBar();
            this.btnApplySignal = new System.Windows.Forms.Button();
            this.lblSignal = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.chkInvertSignal = new System.Windows.Forms.CheckBox();
            this.tbMaxValue = new System.Windows.Forms.TextBox();
            this.lblMaxValue = new System.Windows.Forms.Label();
            this.tbMinValue = new System.Windows.Forms.TextBox();
            this.lblMinValue = new System.Windows.Forms.Label();
            this.cbProperties = new System.Windows.Forms.ComboBox();
            this.lblControllerProperty = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbInputDevices = new System.Windows.Forms.ComboBox();
            this.lblInputDevice = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkScanForWheelsOnly = new System.Windows.Forms.CheckBox();
            this.btnLoadInputDevices = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveGameInputProfile = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.gbControlParams.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBrakeSignal)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 419);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(666, 384);
            this.panel3.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.gbControlParams);
            this.panel6.Controls.Add(this.panel10);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 33);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.panel6.Size = new System.Drawing.Size(666, 268);
            this.panel6.TabIndex = 4;
            // 
            // gbControlParams
            // 
            this.gbControlParams.Controls.Add(this.panel7);
            this.gbControlParams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbControlParams.Location = new System.Drawing.Point(10, 39);
            this.gbControlParams.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.gbControlParams.Name = "gbControlParams";
            this.gbControlParams.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.gbControlParams.Size = new System.Drawing.Size(646, 220);
            this.gbControlParams.TabIndex = 0;
            this.gbControlParams.TabStop = false;
            this.gbControlParams.Text = "Controller Parameters";
            // 
            // panel7
            // 
            this.panel7.AutoScroll = true;
            this.panel7.Controls.Add(this.lblControllerProps);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(10, 25);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(626, 186);
            this.panel7.TabIndex = 3;
            // 
            // lblControllerProps
            // 
            this.lblControllerProps.AutoSize = true;
            this.lblControllerProps.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblControllerProps.Location = new System.Drawing.Point(0, 0);
            this.lblControllerProps.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblControllerProps.Name = "lblControllerProps";
            this.lblControllerProps.Size = new System.Drawing.Size(145, 15);
            this.lblControllerProps.TabIndex = 1;
            this.lblControllerProps.Text = "Please select a controller...";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.lblCalibrate);
            this.panel10.Controls.Add(this.btnCalibrate);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(10, 9);
            this.panel10.Margin = new System.Windows.Forms.Padding(5);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(646, 30);
            this.panel10.TabIndex = 1;
            // 
            // lblCalibrate
            // 
            this.lblCalibrate.AutoSize = true;
            this.lblCalibrate.Location = new System.Drawing.Point(81, 8);
            this.lblCalibrate.Name = "lblCalibrate";
            this.lblCalibrate.Size = new System.Drawing.Size(63, 15);
            this.lblCalibrate.TabIndex = 1;
            this.lblCalibrate.Text = "Calibrate...";
            // 
            // btnCalibrate
            // 
            this.btnCalibrate.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCalibrate.Location = new System.Drawing.Point(0, 0);
            this.btnCalibrate.Name = "btnCalibrate";
            this.btnCalibrate.Size = new System.Drawing.Size(75, 30);
            this.btnCalibrate.TabIndex = 0;
            this.btnCalibrate.Text = "Calibrate";
            this.btnCalibrate.UseVisualStyleBackColor = true;
            this.btnCalibrate.Click += new System.EventHandler(this.btnCalibrate_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 301);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.panel5.Size = new System.Drawing.Size(666, 83);
            this.panel5.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.tbBrakeSignal);
            this.panel9.Controls.Add(this.btnApplySignal);
            this.panel9.Controls.Add(this.lblSignal);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(10, 39);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel9.Size = new System.Drawing.Size(646, 35);
            this.panel9.TabIndex = 2;
            // 
            // tbBrakeSignal
            // 
            this.tbBrakeSignal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBrakeSignal.Enabled = false;
            this.tbBrakeSignal.Location = new System.Drawing.Point(57, 3);
            this.tbBrakeSignal.Margin = new System.Windows.Forms.Padding(2);
            this.tbBrakeSignal.Name = "tbBrakeSignal";
            this.tbBrakeSignal.Size = new System.Drawing.Size(507, 29);
            this.tbBrakeSignal.TabIndex = 1;
            // 
            // btnApplySignal
            // 
            this.btnApplySignal.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnApplySignal.Location = new System.Drawing.Point(564, 3);
            this.btnApplySignal.Margin = new System.Windows.Forms.Padding(2);
            this.btnApplySignal.Name = "btnApplySignal";
            this.btnApplySignal.Size = new System.Drawing.Size(78, 29);
            this.btnApplySignal.TabIndex = 0;
            this.btnApplySignal.Text = "Test";
            this.btnApplySignal.UseVisualStyleBackColor = true;
            this.btnApplySignal.Click += new System.EventHandler(this.btnApplySignal_Click);
            // 
            // lblSignal
            // 
            this.lblSignal.AutoSize = true;
            this.lblSignal.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSignal.Location = new System.Drawing.Point(4, 3);
            this.lblSignal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSignal.Name = "lblSignal";
            this.lblSignal.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lblSignal.Size = new System.Drawing.Size(53, 27);
            this.lblSignal.TabIndex = 0;
            this.lblSignal.Text = "Signal";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.chkInvertSignal);
            this.panel8.Controls.Add(this.tbMaxValue);
            this.panel8.Controls.Add(this.lblMaxValue);
            this.panel8.Controls.Add(this.tbMinValue);
            this.panel8.Controls.Add(this.lblMinValue);
            this.panel8.Controls.Add(this.cbProperties);
            this.panel8.Controls.Add(this.lblControllerProperty);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(10, 9);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel8.Size = new System.Drawing.Size(646, 30);
            this.panel8.TabIndex = 1;
            // 
            // chkInvertSignal
            // 
            this.chkInvertSignal.AutoSize = true;
            this.chkInvertSignal.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkInvertSignal.Location = new System.Drawing.Point(523, 6);
            this.chkInvertSignal.Margin = new System.Windows.Forms.Padding(2);
            this.chkInvertSignal.Name = "chkInvertSignal";
            this.chkInvertSignal.Size = new System.Drawing.Size(91, 18);
            this.chkInvertSignal.TabIndex = 6;
            this.chkInvertSignal.Text = "Invert Signal";
            this.chkInvertSignal.UseVisualStyleBackColor = true;
            // 
            // tbMaxValue
            // 
            this.tbMaxValue.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbMaxValue.Location = new System.Drawing.Point(453, 6);
            this.tbMaxValue.Margin = new System.Windows.Forms.Padding(2);
            this.tbMaxValue.Name = "tbMaxValue";
            this.tbMaxValue.Size = new System.Drawing.Size(70, 23);
            this.tbMaxValue.TabIndex = 5;
            // 
            // lblMaxValue
            // 
            this.lblMaxValue.AutoSize = true;
            this.lblMaxValue.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblMaxValue.Location = new System.Drawing.Point(392, 6);
            this.lblMaxValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaxValue.Name = "lblMaxValue";
            this.lblMaxValue.Size = new System.Drawing.Size(61, 15);
            this.lblMaxValue.TabIndex = 4;
            this.lblMaxValue.Text = "Max Value";
            // 
            // tbMinValue
            // 
            this.tbMinValue.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbMinValue.Location = new System.Drawing.Point(322, 6);
            this.tbMinValue.Margin = new System.Windows.Forms.Padding(2);
            this.tbMinValue.Name = "tbMinValue";
            this.tbMinValue.Size = new System.Drawing.Size(70, 23);
            this.tbMinValue.TabIndex = 3;
            // 
            // lblMinValue
            // 
            this.lblMinValue.AutoSize = true;
            this.lblMinValue.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblMinValue.Location = new System.Drawing.Point(263, 6);
            this.lblMinValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMinValue.Name = "lblMinValue";
            this.lblMinValue.Size = new System.Drawing.Size(59, 15);
            this.lblMinValue.TabIndex = 2;
            this.lblMinValue.Text = "Min Value";
            // 
            // cbProperties
            // 
            this.cbProperties.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbProperties.FormattingEnabled = true;
            this.cbProperties.Location = new System.Drawing.Point(115, 6);
            this.cbProperties.Margin = new System.Windows.Forms.Padding(2);
            this.cbProperties.Name = "cbProperties";
            this.cbProperties.Size = new System.Drawing.Size(148, 23);
            this.cbProperties.TabIndex = 1;
            this.cbProperties.SelectedIndexChanged += new System.EventHandler(this.cbProperties_SelectedIndexChanged);
            // 
            // lblControllerProperty
            // 
            this.lblControllerProperty.AutoSize = true;
            this.lblControllerProperty.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblControllerProperty.Location = new System.Drawing.Point(7, 6);
            this.lblControllerProperty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblControllerProperty.Name = "lblControllerProperty";
            this.lblControllerProperty.Size = new System.Drawing.Size(108, 15);
            this.lblControllerProperty.TabIndex = 0;
            this.lblControllerProperty.Text = "Controller Property";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbInputDevices);
            this.panel4.Controls.Add(this.lblInputDevice);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel4.Size = new System.Drawing.Size(666, 33);
            this.panel4.TabIndex = 0;
            // 
            // cbInputDevices
            // 
            this.cbInputDevices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbInputDevices.FormattingEnabled = true;
            this.cbInputDevices.Location = new System.Drawing.Point(80, 6);
            this.cbInputDevices.Margin = new System.Windows.Forms.Padding(2);
            this.cbInputDevices.Name = "cbInputDevices";
            this.cbInputDevices.Size = new System.Drawing.Size(579, 23);
            this.cbInputDevices.TabIndex = 1;
            this.cbInputDevices.SelectionChangeCommitted += new System.EventHandler(this.cbInputDevices_SelectionChangeCommitted);
            // 
            // lblInputDevice
            // 
            this.lblInputDevice.AutoSize = true;
            this.lblInputDevice.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblInputDevice.Location = new System.Drawing.Point(7, 6);
            this.lblInputDevice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInputDevice.Name = "lblInputDevice";
            this.lblInputDevice.Size = new System.Drawing.Size(73, 15);
            this.lblInputDevice.TabIndex = 0;
            this.lblInputDevice.Text = "Input Device";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chkScanForWheelsOnly);
            this.panel2.Controls.Add(this.btnLoadInputDevices);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSaveGameInputProfile);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 384);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel2.Size = new System.Drawing.Size(666, 35);
            this.panel2.TabIndex = 0;
            // 
            // chkScanForWheelsOnly
            // 
            this.chkScanForWheelsOnly.AutoSize = true;
            this.chkScanForWheelsOnly.Checked = true;
            this.chkScanForWheelsOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkScanForWheelsOnly.Dock = System.Windows.Forms.DockStyle.Right;
            this.chkScanForWheelsOnly.Location = new System.Drawing.Point(187, 6);
            this.chkScanForWheelsOnly.Margin = new System.Windows.Forms.Padding(2);
            this.chkScanForWheelsOnly.Name = "chkScanForWheelsOnly";
            this.chkScanForWheelsOnly.Size = new System.Drawing.Size(176, 23);
            this.chkScanForWheelsOnly.TabIndex = 3;
            this.chkScanForWheelsOnly.Text = "Scan for Wheel Devices Only";
            this.chkScanForWheelsOnly.UseVisualStyleBackColor = true;
            // 
            // btnLoadInputDevices
            // 
            this.btnLoadInputDevices.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLoadInputDevices.Location = new System.Drawing.Point(363, 6);
            this.btnLoadInputDevices.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLoadInputDevices.Name = "btnLoadInputDevices";
            this.btnLoadInputDevices.Size = new System.Drawing.Size(140, 23);
            this.btnLoadInputDevices.TabIndex = 2;
            this.btnLoadInputDevices.Text = "Load Input Devices";
            this.btnLoadInputDevices.UseVisualStyleBackColor = true;
            this.btnLoadInputDevices.Click += new System.EventHandler(this.btnLoadInputDevices_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Location = new System.Drawing.Point(503, 6);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveGameInputProfile
            // 
            this.btnSaveGameInputProfile.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSaveGameInputProfile.Location = new System.Drawing.Point(581, 6);
            this.btnSaveGameInputProfile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSaveGameInputProfile.Name = "btnSaveGameInputProfile";
            this.btnSaveGameInputProfile.Size = new System.Drawing.Size(78, 23);
            this.btnSaveGameInputProfile.TabIndex = 0;
            this.btnSaveGameInputProfile.Text = "Save";
            this.btnSaveGameInputProfile.UseVisualStyleBackColor = true;
            this.btnSaveGameInputProfile.Click += new System.EventHandler(this.btnSaveGameInputProfile_Click);
            // 
            // InputDeviceSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 419);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InputDeviceSetup";
            this.Text = "InputDeviceSetup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InputDeviceSetup_FormClosing);
            this.Load += new System.EventHandler(this.InputDeviceSetup_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.gbControlParams.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBrakeSignal)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel6;
        private GroupBox gbControlParams;
        private Panel panel5;
        private Label lblSignal;
        private Panel panel4;
        private ComboBox cbInputDevices;
        private Label lblInputDevice;
        private Panel panel2;
        private Button btnLoadInputDevices;
        private Button btnCancel;
        private Button btnSaveGameInputProfile;
        private Panel panel7;
        private Label lblControllerProps;
        private Panel panel8;
        private CheckBox chkInvertSignal;
        private TextBox tbMaxValue;
        private Label lblMaxValue;
        private TextBox tbMinValue;
        private Label lblMinValue;
        private ComboBox cbProperties;
        private Label lblControllerProperty;
        private Panel panel9;
        private TrackBar tbBrakeSignal;
        private Button btnApplySignal;
        private Panel panel10;
        private Label lblCalibrate;
        private Button btnCalibrate;
        private CheckBox chkScanForWheelsOnly;
    }
}