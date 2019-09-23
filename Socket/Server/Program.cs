using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net;
using System.Net.Sockets;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            int cong = 11000;
            String ip = "127.0.0.1";
            Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ep = new IPEndPoint(IPAddress.Any, cong);
            serverSocket.Bind(ep);
            try
            {
                // Bat dau lang nghe
                serverSocket.Listen(100);
                while (true)
                {
                    //if (serverSocket.Available > 0)
                    {
                        // Phat hien ket noi den
                        Socket client = serverSocket.Accept();
                        // Nhan du lieu
                        String duLieuNhan = "";
                        byte[] gioHang = new byte[1024];
                        int tongNhan = 0;
                        while (!duLieuNhan.Contains("<EOF>"))
                        {
                            int dem = client.Receive(gioHang);
                            tongNhan += dem;
                            duLieuNhan += Encoding.UTF8.GetString(gioHang, 0, dem);
                            gioHang = new byte[1024];
                        }
                        // Hien thi ra man hinh
                        Console.WriteLine(duLieuNhan);

                        // Phan hoi lai client
                        String cauTraLoi = tongNhan.ToString();
                        byte[] bCauTraLoi = Encoding.UTF8.GetBytes(cauTraLoi);
                        client.Send(bCauTraLoi);

                        // Dong ket noi
                        client.Disconnect(false);
                        client.Dispose();
                    }
                }
            }
            catch
            {

            }
        }
    }
}
