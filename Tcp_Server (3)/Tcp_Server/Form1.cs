using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.NetworkInformation;
using System.Threading;

namespace Tcp_Server
{
    public partial class Form1 : Form
    {
        Socket socket;
        Socket client;
        string textvalue;
        bool inputcheck = false;
        string data;

        public Form1()
        {
            InitializeComponent();

        }
        ~Form1()
        {
            socket.Close();
            client.Close();
        }

        private void Server_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if(Server_checkBox.Checked && true)
            {
                textBox_IP.Visible = false;
            }
            else
            {
                textBox_IP.Visible = true;
            }
        }
        private void textBox_IP_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_port_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            string r_IP = textBox_IP.Text;

            string strNumber = textBox_port.Text;
            int r_Port = Int32.Parse(strNumber);
            if (Server_checkBox.Checked && true)
            {
                if (infobox.Checked)
                {
                    infobox.Checked = false;
                }
                else 
                {
                    infobox.Checked = true;
                    IPEndPoint iptser = new IPEndPoint(IPAddress.Any, r_Port);
                    try
                    {
                        socket.Bind(iptser);
                        socket.Listen(20);
                        textBox_log.Text += "서버로 작동 됩니다.\r\n";
                        IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
                        for (int i = 0; i < host.AddressList.Length; i++)
                        {
                            if (host.AddressList[i].AddressFamily == AddressFamily.InterNetwork)
                            {
                                textBox_log.Text += host.AddressList[i].ToString() +":"+r_Port+ "\r\n";
                                break;
                            }
                        }
                        Thread thread = new Thread(server);
                        thread.IsBackground = true;
                        thread.Start();

                    }
                    catch(Exception ex)
                    {
                        textBox_log.Text += ex.Message + "\r\n";
                    }

                }

            }
            else
            {
                IPEndPoint ipt = new IPEndPoint(IPAddress.Parse(r_IP), r_Port);
                if (infobox.Checked)
                {
                    infobox.Checked = false;
                }
                try
                {
                    socket.Connect(ipt);
                    textBox_log.Text += "서버에 연결 됩니다.\r\n";
                    infobox.Checked = true;

                    Thread thread = new Thread(Clienttesk);
                    thread.IsBackground = true;
                    thread.Start();
                }
                catch (Exception ex)
                {
                    textBox_log.Text += ex.Message +"\r\n";
                }
            }
        }
        private void Clienttesk()
        {
            while (true)
            {
                byte[] buffer = new byte[1024];
                int bytes = socket.Receive(buffer);
                if (bytes > 0)
                {
                    data = Encoding.UTF8.GetString(buffer, 0, bytes);
                    textBox_log.Text += "수신한 데이터 : " + data + "\r\n";
                }
            }
        }
        private void server()
        {
            while (true)
            {
                try
                {
                    client = socket.Accept();
                    textBox_log.Text += "연결되었습니다.\r\n";
                }
                catch (Exception ex) 
                {
                    textBox_log.Text += "에러 : " + ex.Message + "\r\n";
                }

                while (infobox.Checked) {
                    if (Server_checkBox.Checked)
                    {
                        var buff = new byte[1024];
                        int nCount;
                        nCount = client.Receive(buff, 0, buff.Length, SocketFlags.None);
                        if (nCount > 0)
                        {
                            string msg = Encoding.UTF8.GetString(buff, 0, nCount);
                            textBox_log.Text += "수신한 데이터 : " + msg + "\r\n";
                        }
                    }
                }
            }
        }

        private void textBox_log_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (inputcheck)
            {
                if (textvalue.Length > 0)
                {
                    data = textvalue;
                    byte[] msg = Encoding.UTF8.GetBytes(data);
                    if (Server_checkBox.Checked)
                    {
                        try
                        {
                            client.Send(msg, 0, msg.Length, SocketFlags.None);
                            textBox_log.Text += "송신한 데이터 : " + data + "\r\n";
                        }
                        catch (Exception ex)
                        {
                            textBox_log.Text += "에러 : " + ex.Message + "\r\n";
                        }
                    }
                    else
                    {
                        try
                        {
                            socket.Send(msg, 0, msg.Length, SocketFlags.None);
                            textBox_log.Text += "송신한 데이터 : " + data + "\r\n";
                        }
                        catch (Exception ex)
                        {
                            textBox_log.Text += "에러 : " + ex.Message + "\r\n";
                        }

                    }
                }
                    inputcheck = false;
                textvalue = null;
            }
        }

        private void infobox_CheckedChanged(object sender, EventArgs e)
        {
            if (infobox.Checked == false)
            {
                if (Server_checkBox.Checked)
                {
                    client.Close();
                    textBox_log.Text += "연결 종료\r\n";
                }
                else
                {
                    socket.Close();
                    textBox_log.Text += "연결 종료\r\n";
                }
            }
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {   
            if (e.KeyCode ==  Keys.Enter)
            {
                textvalue = textBox.Text;
                inputcheck = true;
                e.SuppressKeyPress = true;
                if (textvalue.Length < 1)
                {
                    textBox_log.Text += "보낼 내용을 입력해주세요\r\n";
                    e.SuppressKeyPress = false;
                }
                textBox.Text = null;
            }
        }

        private void button_input_Click(object sender, EventArgs e)
        {
            textvalue = textBox.Text;
            inputcheck = true;
            if (textBox.Text.Length < 1)
            {
                textBox_log.Text += "보낼 내용을 입력해주세요\r\n";
            }
            textBox.Text = null;
        }
    }
}
