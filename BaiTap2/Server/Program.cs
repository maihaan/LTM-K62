using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net;
using System.Net.Sockets;
using System.Timers;

namespace Server
{
    class Program
    {
        static Socket sk;
        static Timer tm;

        static void Main(string[] args)
        {
            tm = new Timer(10);
            tm.Elapsed += Tm_Elapsed;

            sk = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ep = new IPEndPoint(IPAddress.Any, 11000);
            sk.Bind(ep);
            sk.Listen(100);

            tm.Start();
        }

        private static void Tm_Elapsed(object sender, ElapsedEventArgs e)
        {
            Socket client = sk.Accept();
            if(client != null)
            {
                byte[] buffer = new byte[20];
                int dem = client.Receive(buffer);
                String data = Encoding.UTF8.GetString(buffer, 0, dem);
                String maLenh = data.Split(';')[0];
                String dsThamSo = data.Split(';')[1];
                float ts1 = float.Parse(dsThamSo.Split(',')[0]);
                float ts2 = float.Parse(dsThamSo.Split(',')[1]);
                float ketQua = 0;
                if(maLenh.Equals("cong"))
                {
                    ketQua = Cong(ts1, ts2);
                }
                else if(maLenh.Equals("tru"))
                {
                    ketQua = Tru(ts1, ts2);
                }
                else if(maLenh.Equals("nhan"))
                {
                    ketQua = Nhan(ts1, ts2);
                }
                else
                {
                    ketQua = Chia(ts1, ts2);
                }
                client.Send(Encoding.UTF8.GetBytes(ketQua.ToString()));
                client.Disconnect(false);
                client.Dispose();
            }
        }

        private static float Cong(float a, float b)
        {
            return a + b;
        }

        private static float Tru(float a, float b)
        {
            return a - b;
        }

        private static float Nhan(float a, float b)
        {
            return a * b;
        }

        private static float Chia(float a, float b)
        {
            return a / b;
        }
    }
}
