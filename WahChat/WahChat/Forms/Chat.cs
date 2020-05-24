using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WahChat
{
    public partial class Chat : Form
    {
        public Chat()
        {
            InitializeComponent();

            NetworkService.GetSharedService().chatBox = this.chatBox;

            this.usernameLabel.Text = String.Format("Подключен как \"{0}\"", NetworkService.GetSharedService().currentSession.username);
            this.chatBox.SelectionMode = SelectionMode.None;
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            string message = messageBox.Text;
            NetworkService.GetSharedService().SendMessage(message);

            messageBox.Clear();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            NetworkService.GetSharedService().CloseConnection();
        }
    }
}
