using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEMCNS.BCR_TML
{
    public class MessageHandler
    {
        string _serverIp = "127.0.0.1";
        int _port = 2508;

        TcpClient _client;
        bool _isConnect = false;

        public MessageHandler()
        {
            _client = new TcpClient();
        }

        //public async Task StartAsync()
        public void Connect()
        {
            try
            {
                //await _client.ConnectAsync(_serverIp, _port);
                _client.Connect(_serverIp, _port);
                _isConnect = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public string SendMessage(string message)
        {
            string response = string.Empty;
            try
            {
                if(_isConnect == false)
                {
                    Connect();
                }

                byte[] sendBuffer = Encoding.UTF8.GetBytes(message);

                using (NetworkStream stream = _client.GetStream())
                {
                    // 문자열을 바이트 배열로 변환하여 전송
                    stream.WriteAsync(sendBuffer, 0, sendBuffer.Length);

                    // 응답 수신
                    byte[] buffer = new byte[1024];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    response = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return response;
        }
    }
}
