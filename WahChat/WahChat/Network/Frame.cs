using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WahChat
{
    class Frame
    {
        /// <summary>
        /// Тип кадра
        /// </summary>
        public enum Type: byte
        {
            /// Установка логического соединения.
            Link,
            /// Получение списка пользователей.
            Ask,
            /// Отправка сообщений пользователя.
            Data,
            /// Отправка запроса на переотправку сообщения.
            Error,
            /// Разъединение соединения.
            Downlink
        }

        public Type type;
        public List<byte> data;

        public int authorID;
        public string message;

        public Frame()
        {
            // ..
        }

        public Frame(List<byte> data)
        {
            this.data = data;

            byte typeByte = data[0];
            switch (typeByte)
            {
                case (byte)Type.Link:
                    this.type = Type.Link;
                    break;

                case (byte)Type.Ask:
                    this.type = Type.Ask;
                    break;

                case (byte)Type.Data:
                    this.type = Type.Data;
                    this.authorID = (int)data[1];

                    byte[] byteArray = data.ToArray();

                    int messageLength = data.Count - 2;
                    byte[] messageData = new byte[messageLength];

                    Array.Copy(byteArray, 2, messageData, 0, messageLength);

                    this.message = System.Text.Encoding.UTF8.GetString(messageData, 0, messageData.Length);

                    break;

                case (byte)Type.Error:
                    this.type = Type.Error;
                    break;

                case (byte)Type.Downlink:
                    this.type = Type.Downlink;
                    break;

                default:
                    this.type = Type.Link;
                    break;
            }

        }

        public Frame(Type type)
        {
            List<byte> data = new List<byte>();
            data.Add((byte)type);
            this.data = data;
        }
    }
}
