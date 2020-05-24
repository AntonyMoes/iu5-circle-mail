namespace WahChat
{
    partial class Setup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setup));
            this.incomePortBox = new System.Windows.Forms.ComboBox();
            this.outcomePortBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // incomePortBox
            // 
            this.incomePortBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(112)))), ((int)(((byte)(129)))));
            resources.ApplyResources(this.incomePortBox, "incomePortBox");
            this.incomePortBox.ForeColor = System.Drawing.Color.White;
            this.incomePortBox.FormattingEnabled = true;
            this.incomePortBox.Name = "incomePortBox";
            // 
            // outcomePortBox
            // 
            this.outcomePortBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(112)))), ((int)(((byte)(129)))));
            resources.ApplyResources(this.outcomePortBox, "outcomePortBox");
            this.outcomePortBox.ForeColor = System.Drawing.Color.White;
            this.outcomePortBox.FormattingEnabled = true;
            this.outcomePortBox.Name = "outcomePortBox";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // connectButton
            // 
            this.connectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(112)))), ((int)(((byte)(129)))));
            resources.ApplyResources(this.connectButton, "connectButton");
            this.connectButton.Name = "connectButton";
            this.connectButton.UseVisualStyleBackColor = false;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // checkBox
            // 
            resources.ApplyResources(this.checkBox, "checkBox");
            this.checkBox.Name = "checkBox";
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // Setup
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outcomePortBox);
            this.Controls.Add(this.incomePortBox);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Setup";
            this.Load += new System.EventHandler(this.Setup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox incomePortBox;
        private System.Windows.Forms.ComboBox outcomePortBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.CheckBox checkBox;
    }
}

