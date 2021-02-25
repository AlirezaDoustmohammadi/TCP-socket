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
using System.Threading;
//For Browse
using System.IO;

namespace client1
{
    public partial class TCP_Client_3 : Form
    {
        Socket socketClint = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        Socket socketClint_f = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        Socket socketServer_f = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        Socket socketClient_f = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        byte[] b;
        FileStream fs;
        int con = 0;
        int counter = 0;
        int num_1 = 0;
        int counter_1;
        string[] clients = new string[3];
        int tedad = 0;
        IPEndPoint ipservers;
        string[,] ss = new string[10, 3];

        public TCP_Client_3()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;


            IPEndPoint ipens = new IPEndPoint(IPAddress.Parse("127.0.0.5"), int.Parse("4044"));
            socketClint.Bind(ipens);

            IPEndPoint ipensr = new IPEndPoint(IPAddress.Parse("127.0.0.5"), int.Parse("4045"));
            socketServer_f.Bind(ipensr);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void getmsg()
        {
            try
            {
                while (true)
                {
                    byte[] barray = new byte[1024];
                    // string[,] ss = new string[10, 3];
                    int rc = socketClint.Receive(barray);
                    if (rc > 0)
                    {
                        listBox1.Items.Add("Server: " + Encoding.Unicode.GetString(barray));
                        clients = Encoding.Unicode.GetString(barray).Split(',');
                        ss[counter, 0] = clients[0];
                        ss[counter, 1] = clients[1];
                        ss[counter, 2] = clients[2];
                        counter = counter + 1;
                        MessageBox.Show(ss[0, 1]);
                        MessageBox.Show(ss[0, 2]);

                        if (!socketClint_f.Connected)
                        {
                            ipservers = new IPEndPoint(IPAddress.Parse(ss[con, 1]), int.Parse(ss[con, 2]));
                            try
                            {
                                socketClint_f.Connect(ipservers);
                                Thread tr = new Thread(new ThreadStart(getFile));
                                con = counter;
                                MessageBox.Show("Connect to Recive File");
                                tr.Start();
                            }
                            catch
                            {
                                MessageBox.Show("سرور پیدا نشد");
                                con = con + 1;
                            }
                        }

                    }
                }

            }


            catch { ;}
        }


        public void getFile()
        {
            //For Recive File
            byte[] b = new byte[1024 * 10000];

            //End

            try
            {
                while (true)
                {
                    //For Recive File


                    int r = socketClint_f.Receive(b);
                    if (r > 0)
                    {
                        MessageBox.Show(r.ToString());
                        this.Invoke(new Action(() =>
                        {
                            SaveFileDialog s = new SaveFileDialog();
                            if (s.ShowDialog() == DialogResult.OK)
                            {
                                FileStream fs = new FileStream(s.FileName, FileMode.Create);
                                fs.Write(b, 0, r);
                                fs.Flush();
                                MessageBox.Show("Transfer is Finish");
                            }
                        }));

                        //Thread.CurrentThread.Abort();



                    }



                    //End


                }

            }

            catch { ;}
            




        }

       private void bt_con_Click(object sender, EventArgs e)
        {
            IPEndPoint ipserver = new IPEndPoint(IPAddress.Parse(txt_ip.Text), int.Parse(txt_port.Text));

            try
            {
                socketClint.Connect(ipserver);
                Thread tr = new Thread(new ThreadStart(getmsg));
                tr.Start();
            }
            catch
            {
                MessageBox.Show("سرور پیدا نشد");
            }
        }

        private void txt_port_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_send_Click(object sender, EventArgs e)
        {
            //For Radio Button and Send File

            byte[] barray = new byte[1024];
            if (sen.Checked)
            {
                fs = new FileStream(txt_path.Text, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
                b = new byte[fs.Length];
                fs.Read(b, 0, b.Length);
                barray = Encoding.Unicode.GetBytes(Path.GetFileNameWithoutExtension(fs.Name) + "," + "1" + "," + "127.0.0.5" + "," + "4045");
               // MessageBox.Show(fs.Length.ToString());
            //    socketClint.Send(barray);
                Thread trs = new Thread(new ThreadStart(SendFile));
                trs.Start();
            }
            else
            {

                barray = Encoding.Unicode.GetBytes(txt_msg.Text + "," + "2");
                if (socketClient_f.Connected)
                {
                    socketClint_f.Disconnect(true);
                }

            }

            socketClint.Send(barray);
            listBox1.Items.Add("me: " + Encoding.Unicode.GetString(barray));

            //End

            //***************8* socketClint.Send(b);

           
        }



        public void SendFile()
        {
            // MessageBox.Show("hh");
            socketServer_f.Listen(1);
            // MessageBox.Show("listen");
            // socketClient = socketServer.Accept();
            socketClient_f = socketServer_f.Accept();
            // MessageBox.Show("Accept");           

            MessageBox.Show("درخواست کلاینت قبول شد");
            if (socketClient_f.Connected)
            {
                MessageBox.Show("Send File");
                fs.Read(b, 0, b.Length);
                MessageBox.Show("Size of File: "+fs.Length.ToString());
                socketClient_f.Send(b);
            }

        }


        private void bt_stop_Click(object sender, EventArgs e)
        {

            try
            {                if (socketClint != null)
                    socketClint.Shutdown(SocketShutdown.Both);
                Environment.Exit(Environment.ExitCode);
                Application.Exit();
            }
            catch
            {
                Environment.Exit(Environment.ExitCode);
                Application.Exit();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_msg_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        //For Browse File
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            if (of.ShowDialog() == DialogResult.OK)
            {
                txt_path.Text = of.FileName;
            }
            //End Browse File
        }

        private void Req_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
