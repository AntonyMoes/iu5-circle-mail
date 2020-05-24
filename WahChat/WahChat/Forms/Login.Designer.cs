namespace WahChat
{
    partial class Login
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
            this.loginButton = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.notificationLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(112)))), ((int)(((byte)(129)))));
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.85F);
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.loginButton.Location = new System.Drawing.Point(43, 216);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(591, 68);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Войти";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.85F, System.Drawing.FontStyle.Bold);
            this.textBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox.Location = new System.Drawing.Point(43, 131);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(591, 40);
            this.textBox.TabIndex = 6;
            // 
            // notificationLabel
            // 
            this.notificationLabel.AutoSize = true;
            this.notificationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.notificationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.notificationLabel.Location = new System.Drawing.Point(51, 358);
            this.notificationLabel.Name = "notificationLabel";
            this.notificationLabel.Size = new System.Drawing.Size(26, 37);
            this.notificationLabel.TabIndex = 7;
            this.notificationLabel.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(36, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = " Имя";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(673, 434);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.notificationLabel);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.loginButton);
            this.Name = "Login";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label notificationLabel;
        private System.Windows.Forms.Label label1;
    }
}