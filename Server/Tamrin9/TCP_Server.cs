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
using System.Text.RegularExpressions;
//For Recive File
using System.IO;

namespace Tamrin9
{
    public partial class TCP_Server : Form
    {
        Socket socketServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        Socket socketClient = null;
        int counter = 0;
        string[,] barray2 = new string[100, 4];
        string result;
        int num = 0;
        int numm = 0;
        private Object thisLock = new Object();  
        public TCP_Server()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void start()
        {

            IPEndPoint ipens = new IPEndPoint(IPAddress.Parse(txt_ip.Text), int.Parse(txt_port.Text));
            socketServer.Bind(ipens);
            MessageBox.Show("سرور در انتظار یک درخواست");

            for (int i = 0; i <= 3; i++)
            {
                Thread tr_client = new Thread(new ThreadStart(multi_client));
                tr_client.Start();

            }

            
        }

        public void multi_client()
        {

            socketServer.Listen(1);
           // socketClient = socketServer.Accept();
            Socket Sos=socketServer.Accept();

            MessageBox.Show("درخواست کلاینت قبول شد");
            if (Sos.Connected)
            {
                Thread trgetmsg = new Thread(new ParameterizedThreadStart(getmsg));
                trgetmsg.Start(Sos);
            }
        }

        
         void getmsg(object clientSockObj)
        {
            Socket soc = (Socket)clientSockObj;
         //   Object thisLock = new Object();

            //For Recive File
            byte[] b = new byte[1024*10000];
            int type = 0;
            //End

            try
            {
                while (true)
                {

                    byte[] barray = new byte[1024];
                    int rc = soc.Receive(barray);
                    barray2[counter,0] = Encoding.Unicode.GetString(barray, 0, rc);

                    if (rc > 0)
                    {

                        string[] data = Encoding.Unicode.GetString(barray, 0, rc).Split(',');
                       // MessageBox.Show(data[0]);

                            if (data[1] == "1")
                            {
                                type = 1;
                            }
                            else if (data[1] == "2")
                            {
                                type = 2;
                            }

                         //   MessageBox.Show(type.ToString());





                            if (type == 1)
                            {
                                MessageBox.Show("deliver");

                                lock (thisLock)
                                {
                                    barray2[counter, 0] = data[0];
                                    var endPoint = (IPEndPoint)soc.RemoteEndPoint;
                                    barray2[counter, 2] = data[2];
                                    barray2[counter, 3] = data[3];
                                    counter = counter + 1;
                                    MessageBox.Show("I am Lock");
                                }

                            }
                            else if (type == 2)
                            {
                               // MessageBox.Show(counter.ToString());
                                for (int i = 0; i < counter; i++)
                                {
                                    MessageBox.Show(barray2[counter-1,0]);
                                    if (barray2[i, 0] == data[0])
                                    {
                                        result = barray2[i, 0] + "," + barray2[i, 2] + "," + barray2[i, 3];
                                         soc.Send(Encoding.Unicode.GetBytes(result));


                                    }
                                  

                                }
                                
                                
                                if (counter == 0)
                                {
                                    MessageBox.Show("لیست خالی است");
                                }

                            }


                        }
                        



                    }
                   
                    
                }

            
            catch { ;}
            

        }

        private void bt_co_Click(object sender, EventArgs e)
        {
             
             Thread trstart = new Thread(new ThreadStart(start));
               trstart.Start();
               
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

       
      
        private void bt_exit_Click(object sender, EventArgs e)
        {
            try
            {
                if (socketClient != null)
                    socketClient.Shutdown(SocketShutdown.Both);
                
                if (socketServer != null)
                    socketServer.Shutdown(SocketShutdown.Both);
                Environment.Exit(Environment.ExitCode);
                Application.Exit();
            }
            catch 
            {
                Environment.Exit(Environment.ExitCode);
                Application.Exit();
            }

        }

        private void txt_msg_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
