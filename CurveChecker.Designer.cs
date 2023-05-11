namespace MattScerri.Fanatec.V3.PedalCurve
{
    partial class CurveChecker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurveChecker));
            this.tbInput = new System.Windows.Forms.TrackBar();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblInputMinValue = new System.Windows.Forms.Label();
            this.tbInputMinVal = new System.Windows.Forms.TextBox();
            this.tbInputMaxVal = new System.Windows.Forms.TextBox();
            this.lblInputMaxValue = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.tbOutput = new System.Windows.Forms.TrackBar();
            this.tbOutputMaxVal = new System.Windows.Forms.TextBox();
            this.lblOutputMaxValue = new System.Windows.Forms.Label();
            this.tbOutputMinVal = new System.Windows.Forms.TextBox();
            this.lblOutputMinValue = new System.Windows.Forms.Label();
            this.btnSetParams = new System.Windows.Forms.Button();
            this.cbCurve = new System.Windows.Forms.ComboBox();
            this.lblInputVal = new System.Windows.Forms.Label();
            this.lblOutputVal = new System.Windows.Forms.Label();
            this.tbFactor = new System.Windows.Forms.TextBox();
            this.cbThrottleInverted = new System.Windows.Forms.CheckBox();
            this.cbBrakeInverted = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(50, 7);
            this.tbInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(501, 45);
            this.tbInput.TabIndex = 0;
            this.tbInput.ValueChanged += new System.EventHandler(this.tbInput_ValueChanged);
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(8, 13);
            this.lblInput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(35, 15);
            this.lblInput.TabIndex = 1;
            this.lblInput.Text = "Input";
            // 
            // lblInputMinValue
            // 
            this.lblInputMinValue.AutoSize = true;
            this.lblInputMinValue.Location = new System.Drawing.Point(50, 43);
            this.lblInputMinValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInputMinValue.Name = "lblInputMinValue";
            this.lblInputMinValue.Size = new System.Drawing.Size(93, 15);
            this.lblInputMinValue.TabIndex = 2;
            this.lblInputMinValue.Text = "Input Min. Value";
            // 
            // tbInputMinVal
            // 
            this.tbInputMinVal.Location = new System.Drawing.Point(153, 41);
            this.tbInputMinVal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbInputMinVal.Name = "tbInputMinVal";
            this.tbInputMinVal.Size = new System.Drawing.Size(106, 23);
            this.tbInputMinVal.TabIndex = 3;
            this.tbInputMinVal.Text = "0";
            // 
            // tbInputMaxVal
            // 
            this.tbInputMaxVal.Location = new System.Drawing.Point(377, 41);
            this.tbInputMaxVal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbInputMaxVal.Name = "tbInputMaxVal";
            this.tbInputMaxVal.Size = new System.Drawing.Size(106, 23);
            this.tbInputMaxVal.TabIndex = 5;
            this.tbInputMaxVal.Text = "65535";
            // 
            // lblInputMaxValue
            // 
            this.lblInputMaxValue.AutoSize = true;
            this.lblInputMaxValue.Location = new System.Drawing.Point(275, 43);
            this.lblInputMaxValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInputMaxValue.Name = "lblInputMaxValue";
            this.lblInputMaxValue.Size = new System.Drawing.Size(95, 15);
            this.lblInputMaxValue.TabIndex = 4;
            this.lblInputMaxValue.Text = "Input Max. Value";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(8, 113);
            this.lblOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(45, 15);
            this.lblOutput.TabIndex = 7;
            this.lblOutput.Text = "Output";
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(50, 107);
            this.tbOutput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(501, 45);
            this.tbOutput.TabIndex = 6;
            // 
            // tbOutputMaxVal
            // 
            this.tbOutputMaxVal.Location = new System.Drawing.Point(390, 149);
            this.tbOutputMaxVal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbOutputMaxVal.Name = "tbOutputMaxVal";
            this.tbOutputMaxVal.Size = new System.Drawing.Size(106, 23);
            this.tbOutputMaxVal.TabIndex = 11;
            this.tbOutputMaxVal.Text = "255";
            // 
            // lblOutputMaxValue
            // 
            this.lblOutputMaxValue.AutoSize = true;
            this.lblOutputMaxValue.Location = new System.Drawing.Point(275, 151);
            this.lblOutputMaxValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOutputMaxValue.Name = "lblOutputMaxValue";
            this.lblOutputMaxValue.Size = new System.Drawing.Size(105, 15);
            this.lblOutputMaxValue.TabIndex = 10;
            this.lblOutputMaxValue.Text = "Output Max. Value";
            // 
            // tbOutputMinVal
            // 
            this.tbOutputMinVal.Location = new System.Drawing.Point(163, 149);
            this.tbOutputMinVal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbOutputMinVal.Name = "tbOutputMinVal";
            this.tbOutputMinVal.Size = new System.Drawing.Size(106, 23);
            this.tbOutputMinVal.TabIndex = 9;
            this.tbOutputMinVal.Text = "0";
            // 
            // lblOutputMinValue
            // 
            this.lblOutputMinValue.AutoSize = true;
            this.lblOutputMinValue.Location = new System.Drawing.Point(50, 151);
            this.lblOutputMinValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOutputMinValue.Name = "lblOutputMinValue";
            this.lblOutputMinValue.Size = new System.Drawing.Size(103, 15);
            this.lblOutputMinValue.TabIndex = 8;
            this.lblOutputMinValue.Text = "Output Min. Value";
            // 
            // btnSetParams
            // 
            this.btnSetParams.Location = new System.Drawing.Point(8, 199);
            this.btnSetParams.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSetParams.Name = "btnSetParams";
            this.btnSetParams.Size = new System.Drawing.Size(78, 20);
            this.btnSetParams.TabIndex = 12;
            this.btnSetParams.Text = "Set Params";
            this.btnSetParams.UseVisualStyleBackColor = true;
            this.btnSetParams.Click += new System.EventHandler(this.btnSetParams_Click);
            // 
            // cbCurve
            // 
            this.cbCurve.FormattingEnabled = true;
            this.cbCurve.Items.AddRange(new object[] {
            "Linear",
            "Exponential",
            //"Logarithmic",
            "Butterfly"});
            this.cbCurve.Location = new System.Drawing.Point(90, 200);
            this.cbCurve.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbCurve.Name = "cbCurve";
            this.cbCurve.Size = new System.Drawing.Size(129, 23);
            this.cbCurve.TabIndex = 13;
            this.cbCurve.SelectionChangeCommitted += new System.EventHandler(this.cbCurve_SelectionChangeCommitted);
            // 
            // lblInputVal
            // 
            this.lblInputVal.AutoSize = true;
            this.lblInputVal.Location = new System.Drawing.Point(45, 68);
            this.lblInputVal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInputVal.Name = "lblInputVal";
            this.lblInputVal.Size = new System.Drawing.Size(38, 15);
            this.lblInputVal.TabIndex = 14;
            this.lblInputVal.Text = "label1";
            // 
            // lblOutputVal
            // 
            this.lblOutputVal.AutoSize = true;
            this.lblOutputVal.Location = new System.Drawing.Point(45, 173);
            this.lblOutputVal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOutputVal.Name = "lblOutputVal";
            this.lblOutputVal.Size = new System.Drawing.Size(38, 15);
            this.lblOutputVal.TabIndex = 15;
            this.lblOutputVal.Text = "label1";
            // 
            // tbFactor
            // 
            this.tbFactor.Location = new System.Drawing.Point(222, 201);
            this.tbFactor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbFactor.Name = "tbFactor";
            this.tbFactor.Size = new System.Drawing.Size(106, 23);
            this.tbFactor.TabIndex = 16;
            this.tbFactor.Text = "1.2";
            // 
            // cbThrottleInverted
            // 
            this.cbThrottleInverted.AutoSize = true;
            this.cbThrottleInverted.Location = new System.Drawing.Point(377, 68);
            this.cbThrottleInverted.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbThrottleInverted.Name = "cbThrottleInverted";
            this.cbThrottleInverted.Size = new System.Drawing.Size(69, 19);
            this.cbThrottleInverted.TabIndex = 17;
            this.cbThrottleInverted.Text = "Inverted";
            this.cbThrottleInverted.UseVisualStyleBackColor = true;
            // 
            // cbBrakeInverted
            // 
            this.cbBrakeInverted.AutoSize = true;
            this.cbBrakeInverted.Location = new System.Drawing.Point(377, 173);
            this.cbBrakeInverted.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbBrakeInverted.Name = "cbBrakeInverted";
            this.cbBrakeInverted.Size = new System.Drawing.Size(69, 19);
            this.cbBrakeInverted.TabIndex = 18;
            this.cbBrakeInverted.Text = "Inverted";
            this.cbBrakeInverted.UseVisualStyleBackColor = true;
            // 
            // CurveChecker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 270);
            this.Controls.Add(this.cbBrakeInverted);
            this.Controls.Add(this.cbThrottleInverted);
            this.Controls.Add(this.tbFactor);
            this.Controls.Add(this.lblOutputVal);
            this.Controls.Add(this.lblInputVal);
            this.Controls.Add(this.cbCurve);
            this.Controls.Add(this.btnSetParams);
            this.Controls.Add(this.tbOutputMaxVal);
            this.Controls.Add(this.lblOutputMaxValue);
            this.Controls.Add(this.tbOutputMinVal);
            this.Controls.Add(this.lblOutputMinValue);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.tbInputMaxVal);
            this.Controls.Add(this.lblInputMaxValue);
            this.Controls.Add(this.tbInputMinVal);
            this.Controls.Add(this.lblInputMinValue);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.tbInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CurveChecker";
            this.Text = "CurveChecker";
            ((System.ComponentModel.ISupportInitialize)(this.tbInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TrackBar tbInput;
        private Label lblInput;
        private Label lblInputMinValue;
        private TextBox tbInputMinVal;
        private TextBox tbInputMaxVal;
        private Label lblInputMaxValue;
        private Label lblOutput;
        private TrackBar tbOutput;
        private TextBox tbOutputMaxVal;
        private Label lblOutputMaxValue;
        private TextBox tbOutputMinVal;
        private Label lblOutputMinValue;
        private Button btnSetParams;
        private ComboBox cbCurve;
        private Label lblInputVal;
        private Label lblOutputVal;
        private TextBox tbFactor;
        private CheckBox cbThrottleInverted;
        private CheckBox cbBrakeInverted;
    }
}