using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WahChat
{
    class NetworkService
    {
        public Label notificationLabel;
        public Button connectButton;
        public ListBox chatBox;

        private NetworkService()
        {
            // ..
        }

        private static readonly NetworkService _sharedService = new NetworkService();

        public static NetworkService GetSharedService()
        {
            return _sharedService;
        }

        /// Текущее соединение
        public Connection currentConnection;

        /// Текущая сессия
        public Session currentSession;

        /// <summary>
        /// Создание соединения
        /// </summary>
        public void CreateConnection(string incomePortName, string outcomePortName, bool isMaster)
        {
            this.currentConnection = new Connection(incomePortName, outcomePortName, isMaster);

            // формирование LINK кадра..
            // отправка LINK кадра..
        }

        /// <summary>
        /// Закрытие соединения
        /// </summary>
        public void CloseConnection()
        {
            Frame frame = new Frame(Frame.Type.Downlink);
            this.SendFrame(frame);
        }

        /// <summary>
        /// Обработка пришедшего сообщения
        /// </summary>
        public void HandleMessage(List<byte> message)
        {
            Frame frame = new Frame(message);
            this.HandleFrame(frame);
        }

        /// <summary>
        /// Обработка пришедшего кадра
        /// </summary>
        public void HandleFrame(Frame frame)
        {
            switch (frame.type)
            {
                case Frame.Type.Link:

                    this.notificationLabel.Invoke((MethodInvoker)delegate {

                        // Running on the UI thread
                        this.notificationLabel.Text = "Соединение установлено";
                        this.connectButton.Text = "Войти";
                    });

                    // Если станция не ведущая, то отправляем дальше
                    if (currentConnection.isMaster == false)
                    {
                        this.SendFrame(frame);
                    }

                    break;

                case Frame.Type.Ask:

                    // Если станция не ведущая, то отправляем дальше
                    if (currentConnection.isMaster == false)
                    {
                        this.SendFrame(frame);
                    }

                    break;

                case Frame.Type.Data:

                    this.chatBox.Invoke((MethodInvoker)delegate {

                        // Running on the UI thread
                        this.chatBox.Items.Add(string.Format("{0} ({1}) {2}", DateTime.Now.ToString("hh:mm"), frame.authorID, frame.message));
                    });

                    // Если станция не ялвяется отправителем, то отправляем дальше
                    if (currentSession.username != frame.authorID)
                    {
                        this.SendFrame(frame);
                    }

                    break;

                case Frame.Type.Error:

                    // Если станция не ведущая, то отправляем дальше
                    if (currentConnection.isMaster == false)
                    {
                        this.SendFrame(frame);
                    }

                    break;

                case Frame.Type.Downlink:

                    // Если станция не ведущая, то отправляем дальше
                    if (currentConnection.isMaster == false)
                    {
                        this.SendFrame(frame);
                    }

                    System.Windows.Forms.Application.Exit();

                    break;
            }
        }

        public void SendFrame(Frame frame)
        {
            this.currentConnection.SendBytes(frame.data);
        }

        public void SendMessage(string message)
        {
            byte[] byteStr = System.Text.Encoding.UTF8.GetBytes(message);

            List<byte> data = new List<byte>();

            data.Add((byte)Frame.Type.Data);
            data.Add((byte)currentSession.username);

            foreach (byte b in byteStr)
            {
                data.Add(b);
            }

            Frame frame = new Frame();
            frame.data = data;

            this.SendFrame(frame);
        }

        /// <summary>
        /// Список доступных портов
        /// </summary>
        public string[] GetPortsNames()
        {
            return SerialPort.GetPortNames();
        }

        /// <summary>
        /// Создание сессии
        /// </summary>
        public void CreateSession(int username)
        {
            this.currentSession = new Session(username);

            // формирование кадра c username..
            // отправка кадра c username..
        }

        /// <summary>
        /// Закрытие сессии
        /// </summary>
        public void CloseSession()
        {
            // ..
        }
    }
}
