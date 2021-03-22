using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_UI
{
    class WebSocket
    {
        public Socket sck;
        public EndPoint epLocal, epRemote;
        byte[] buffer;
        public List<string> messages;
        public bool connection;

        public WebSocket()
        {
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            messages = new List<string>();
        }

        public void connect(string LIP, string LPort, string RIP, string RPort)
        {

            epLocal = new IPEndPoint(IPAddress.Parse(LIP), Convert.ToInt32(LPort));
            sck.Bind(epLocal);
            epRemote = new IPEndPoint(IPAddress.Parse(RIP), Convert.ToInt32(RPort));
            try
            {
                sck.Connect(epRemote);
                connection = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect connection details!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection = false;
            }
            buffer = new byte[1500];
            sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

        }

        public string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }

        public void sendMsg(string msg)
        {
            ASCIIEncoding aEncoding = new ASCIIEncoding();
            byte[] sendingMessage = new byte[1500];
            sendingMessage = aEncoding.GetBytes(msg);
            messages.Add(msg);
            sck.Send(sendingMessage);
        }

        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                byte[] receivedData = new byte[1500];
                receivedData = (byte[])aResult.AsyncState;

                ASCIIEncoding aEncoding = new ASCIIEncoding();
                string receivedMessage = aEncoding.GetString(receivedData);

                messages.Add(receivedMessage);

                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
