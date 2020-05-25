using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CircleMail
{
    public partial class Mail : Form
    {
        public Mail()
        {
            InitializeComponent();

            NetworkService.GetSharedService().mailBox = this.chatBox;

            this.usernameLabel.Text = String.Format("Пользователь \"{0}\"", NetworkService.GetSharedService().currentSession.username);
            // this.mailBox.SelectionMode = SelectionMode.None;

            string appDirectory = String.Format("c:/Users/{0}/AppData/CircleMail", Environment.UserName);
            if (!Directory.Exists(appDirectory))
            {
                Directory.CreateDirectory(appDirectory);
            }

            string userDirectory = String.Format("{0}/{1}", appDirectory, NetworkService.GetSharedService().currentSession.username);
            if (!Directory.Exists(userDirectory))
            {
                Directory.CreateDirectory(userDirectory);
            }

            NetworkService.GetSharedService().userDirectory = userDirectory;
            string[] files = Directory.GetFiles(userDirectory);
            foreach (string file in files)
            {
                string[] data = File.ReadAllLines(file);
                this.chatBox.Items.Add(string.Format("{0}: {1}",data[0], String.Join(Environment.NewLine, data.Skip(1))));
            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if (letterAuthorBox.Text == "")
            {
                MessageBox.Show("Выберите письмо", "Ошибка");
                return;
            }

            this.Hide();

            CreateLetter createLetterForm = new CreateLetter(letterAuthorBox.Text, letterAuthorBox.Text, "", letterTextBox.Text);
            createLetterForm.Owner = this;
            createLetterForm.StartPosition = FormStartPosition.CenterParent;
            createLetterForm.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            NetworkService.GetSharedService().CloseConnection();
        }

        private void chatBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] currentItemData = chatBox.SelectedItem.ToString().Split(':');
            letterAuthorBox.Text = currentItemData[0];
            letterTextBox.Text = currentItemData[1].Trim();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа предназначена для передачи\nтекстовых сообщений в формате электронной\nпочты между компьютерами, соединёнными\nнуль-модемными кабелями через\nинтерфейс RS-232C.",
                "О программе");
            MessageBox.Show("Программа выполнена в рамках курса\n\"Сетевые технологии в АСОИУ\" \n\nВыполнили:\nДятленко Е.А.\nСеледкина А.С.\nСысоев А.Р.\n\nПреподаватель:\nГалкин В.А. ",
                "Разработчики");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            CreateLetter createLetterForm = new CreateLetter("", "", "", "");
            createLetterForm.Owner = this;
            createLetterForm.StartPosition = FormStartPosition.CenterParent;
            createLetterForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (letterAuthorBox.Text == "")
            {
                MessageBox.Show("Выберите письмо", "Ошибка");
                return;
            }

            this.Hide();

            CreateLetter createLetterForm = new CreateLetter("", letterAuthorBox.Text, NetworkService.GetSharedService().currentSession.username.ToString(), letterTextBox.Text);
            createLetterForm.Owner = this;
            createLetterForm.StartPosition = FormStartPosition.CenterParent;
            createLetterForm.Show();
        }

        private void Chat_FormClosed(object sender, FormClosedEventArgs e)
        {
            NetworkService.GetSharedService().CloseConnection();
        }
    }
}
