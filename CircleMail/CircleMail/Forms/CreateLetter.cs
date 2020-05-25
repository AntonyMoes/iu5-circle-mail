using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircleMail
{
    public partial class CreateLetter : Form
    {
        public CreateLetter(string author, string replyAuthor, string replyRecipient, string text)
        {
            InitializeComponent();

            if (author != "")
            {
                letterRecipientBox.Text = author;
                letterRecipientBox.ReadOnly = true;
            }

            if (text != "")
            {
                string[] lines = text.Split('\n');
                letterTextBox.Text += Environment.NewLine;
                letterTextBox.Text += Environment.NewLine;
                if (replyRecipient != "")
                {
                    //letterTextBox.Text += String.Format("---Пересылаемое сообщение---");
                    //letterTextBox.Text += Environment.NewLine;
                    letterTextBox.Text += String.Format("От кого: {0}", replyAuthor);
                    letterTextBox.Text += Environment.NewLine;
                    letterTextBox.Text += String.Format("Кому: {0}", replyRecipient);
                    letterTextBox.Text += Environment.NewLine;
                } else
                {
                    letterTextBox.Text += String.Format("{0}:", replyAuthor);
                    letterTextBox.Text += Environment.NewLine;
                }
                
                foreach (string line in lines)
                {
                    letterTextBox.Text += String.Format("\n> {0}", line);
                }
            }
        }

        private void CreateLetter_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (letterRecipientBox.Text == "")
            {
                MessageBox.Show("Введите получателя письма", "Ошибка");
                return;
            }
            int recipient = int.Parse(letterRecipientBox.Text);

            if (letterTextBox.Text == "")
            {
                MessageBox.Show("Письмо не должно быть пустым", "Ошибка");
                return;
            }
            string text = letterTextBox.Text;
            NetworkService.GetSharedService().SendMessage(recipient, text);

            this.Close();
        }
    }
}
