using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btGui_Click(object sender, EventArgs e)
        {
            String serverIP = "127.0.0.1";
            int serverPort = 11000;

            // Kiem tra du lieu dau vao
            String data = tbNoiDung.Text;
            if(String.IsNullOrEmpty(data))
            {
                return;
            }
            SocketClient client = new SocketClient();
            client.IP = serverIP;
            client.Port = serverPort;
            client.Data = data;
            String msg = client.Send();
            tbLichSu.Text += "Send: " + data + "\r\n";
            if(msg.Equals("OK"))
            {
                String result = client.Result;

                // Hien thi ket qua len lich su tin nhan
                tbLichSu.Text += "[Đã nhận]\r\n";
                tbNoiDung.Text = "";
                tbNoiDung.Focus();
            }
            else
            {
                tbLichSu.Text += "[Lỗi kết nối]\r\n";
            }
        }
    }
}
