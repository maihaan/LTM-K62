using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net;
using System.Net.Sockets;


namespace Client
{
    public class SocketClient
    {
        // Thuoc tinh
        public String IP { get; set; }
        public int Port { get; set; }
        public String Data { get; set; }
        public String Result { get; set; }

        // Hanh vi - Phuong thuc
        public String Send()
        {
            // Buoc 1: Chuyen doi du lieu
            byte[] buffer = Encoding.UTF8.GetBytes(Data);

            // Buoc 2: Mo ket noi den may chu va gui du lieu
            IPAddress serverIP = IPAddress.Parse(IP);
            Socket sk = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                // Ket noi den may chu
                sk.Connect(serverIP, Port);
                if(sk.Connected)
                {
                    // Gui du lieu
                    int count = sk.Send(buffer);
                    if(count != buffer.Length)
                    {
                        return "E1"; // Gui khong het
                    }
                    else
                    {
                        // Nhan tra loi tu server
                        byte[] revBuffer = new byte[10];
                        int revCount = sk.Receive(revBuffer);
                        if(count != revCount)
                        {
                            return "E2"; // Nhan khong het
                        }
                        else
                        {
                            Result = Encoding.UTF8.GetString(revBuffer);
                        }
                    }
                    sk.Disconnect(false);
                }
                else
                {
                    return "E0"; // Khong ket noi duoc
                }
                sk.Dispose();
                return "OK"; // Thanh cong
            }
            catch (Exception e)
            {
                if (sk.Connected)
                    sk.Disconnect(false);
                sk.Dispose();
                return "E3-" + e.ToString(); // Loi khong xac dinh
            }
        }
    }
}
