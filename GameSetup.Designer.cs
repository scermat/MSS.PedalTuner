namespace MattScerri.Fanatec.V3.PedalCurve
{
    partial class GameSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameSetup));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSetMax = new System.Windows.Forms.Button();
            this.btnSetMin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 68);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.panel1.Size = new System.Drawing.Size(560, 44);
            this.panel1.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOK.Location = new System.Drawing.Point(472, 9);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(78, 26);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSetMax);
            this.panel2.Controls.Add(this.btnSetMin);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.panel2.Size = new System.Drawing.Size(560, 49);
            this.panel2.TabIndex = 1;
            // 
            // btnSetMax
            // 
            this.btnSetMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSetMax.Location = new System.Drawing.Point(389, 9);
            this.btnSetMax.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSetMax.Name = "btnSetMax";
            this.btnSetMax.Size = new System.Drawing.Size(161, 31);
            this.btnSetMax.TabIndex = 1;
            this.btnSetMax.Text = "Set Maximum";
            this.btnSetMax.UseVisualStyleBackColor = true;
            this.btnSetMax.Click += new System.EventHandler(this.btnSetMax_Click);
            // 
            // btnSetMin
            // 
            this.btnSetMin.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSetMin.Location = new System.Drawing.Point(10, 9);
            this.btnSetMin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSetMin.Name = "btnSetMin";
            this.btnSetMin.Size = new System.Drawing.Size(161, 31);
            this.btnSetMin.TabIndex = 0;
            this.btnSetMin.Text = "Set Minimum";
            this.btnSetMin.UseVisualStyleBackColor = true;
            this.btnSetMin.Click += new System.EventHandler(this.btnSetMin_Click);
            // 
            // GameSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 112);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GameSetup";
            this.Text = "GameSetup";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnOK;
        private Panel panel2;
        private Button btnSetMax;
        private Button btnSetMin;
    }
}