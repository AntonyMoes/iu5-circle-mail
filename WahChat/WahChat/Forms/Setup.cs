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
    public partial class Setup : Form
    {
        public Setup()
        {
            InitializeComponent();
        }

        private void Setup_Load(object sender, EventArgs e)
        {
            // Показываем список COM-портов.
            string[] portNames = NetworkService.GetSharedService().GetPortsNames();
            foreach (string portName in portNames)
            {
                incomePortBox.Items.Add(portName);
                outcomePortBox.Items.Add(portName);
            }
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            // Проверяем, выставлены ли порты.
            if ((incomePortBox.SelectedItem != null) && (outcomePortBox.SelectedItem != null))
            {

                string incomePort = incomePortBox.SelectedItem.ToString();
                string outcomePort = outcomePortBox.SelectedItem.ToString();

                // Если порты одинаковые, то показываем ошибку.
                if (incomePort == outcomePort)
                {
                    MessageBox.Show("Выберите различные COM-порты", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                // Стартуем соединение.
                NetworkService.GetSharedService().CreateConnection(incomePort, outcomePort, checkBox.Checked);

                this.Hide();

                Login loginForm = new Login();
                loginForm.Show();
            }
            else
            {
                MessageBox.Show("Оба COM-порта должны быть выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
