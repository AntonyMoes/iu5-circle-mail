namespace WahChat
{
    partial class Chat
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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.chatBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.usernameLabel.Location = new System.Drawing.Point(56, 47);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(95, 39);
            this.usernameLabel.TabIndex = 9;
            this.usernameLabel.Text = " Имя";
            // 
            // messageBox
            // 
            this.messageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.messageBox.Location = new System.Drawing.Point(63, 542);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(512, 49);
            this.messageBox.TabIndex = 11;
            // 
            // SendButton
            // 
            this.SendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(112)))), ((int)(((byte)(129)))));
            this.SendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SendButton.ForeColor = System.Drawing.Color.White;
            this.SendButton.Location = new System.Drawing.Point(597, 542);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(279, 49);
            this.SendButton.TabIndex = 12;
            this.SendButton.Text = "Отправить";
            this.SendButton.UseVisualStyleBackColor = false;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(112)))), ((int)(((byte)(129)))));
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(597, 47);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(279, 49);
            this.closeButton.TabIndex = 13;
            this.closeButton.Text = "Отключиться";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // chatBox
            // 
            this.chatBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.chatBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chatBox.ForeColor = System.Drawing.Color.Black;
            this.chatBox.FormattingEnabled = true;
            this.chatBox.ItemHeight = 33;
            this.chatBox.Location = new System.Drawing.Point(63, 143);
            this.chatBox.Name = "chatBox";
            this.chatBox.Size = new System.Drawing.Size(813, 367);
            this.chatBox.TabIndex = 14;
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(942, 645);
            this.Controls.Add(this.chatBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.usernameLabel);
            this.Name = "Chat";
            this.Text = "Чат";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ListBox chatBox;
    }
}