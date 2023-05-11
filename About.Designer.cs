namespace MattScerri.Fanatec.V3.PedalCurve
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.btnCloseAbout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbAbout = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCloseAbout
            // 
            this.btnCloseAbout.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCloseAbout.Location = new System.Drawing.Point(535, 9);
            this.btnCloseAbout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCloseAbout.Name = "btnCloseAbout";
            this.btnCloseAbout.Size = new System.Drawing.Size(78, 22);
            this.btnCloseAbout.TabIndex = 1;
            this.btnCloseAbout.Text = "Close";
            this.btnCloseAbout.UseVisualStyleBackColor = true;
            this.btnCloseAbout.Click += new System.EventHandler(this.btnCloseAbout_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCloseAbout);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 316);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.panel1.Size = new System.Drawing.Size(623, 40);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbAbout);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.panel2.Size = new System.Drawing.Size(623, 316);
            this.panel2.TabIndex = 3;
            // 
            // tbAbout
            // 
            this.tbAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAbout.Location = new System.Drawing.Point(10, 9);
            this.tbAbout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbAbout.Multiline = true;
            this.tbAbout.Name = "tbAbout";
            this.tbAbout.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbAbout.Size = new System.Drawing.Size(603, 298);
            this.tbAbout.TabIndex = 0;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 356);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "About";
            this.Text = "About";
            this.Load += new System.EventHandler(this.About_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnCloseAbout;
        private Panel panel1;
        private Panel panel2;
        private TextBox tbAbout;
    }
}