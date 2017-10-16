using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;
using Xamarin.Forms;
using System.ComponentModel;
using NJPlayMobile.Pages;

namespace NJPlayMobile.Classes
{
    public class TCP
    {
        /*public TcpClient client;
        public StreamReader STR;
        public StreamWriter STW;
        public string receive;
        public string conectando = "Conectando";
        public bool isConnected = false;
        public String input_to_send;
        public IPEndPoint IP_End; //variável global declarada
        public BackgroundWorker worker1 = new BackgroundWorker();
        public BackgroundWorker worker2 = new BackgroundWorker();

        public static List<string> FetchVideos()
        {
            TCP tCP = new TCP();
            List<string> incomingfiles = new List<string>();
            tCP.TCPSend("fetch_videos");

            int Size = Convert.ToInt32(tCP.receive);
            int i = 0;
            while (i < Size)
            {
                incomingfiles.Add(tCP.receive);
                i++;
            }
            return incomingfiles;
        }

        public void Connect(string s, int i)
        {

            client = new TcpClient();
            IP_End = new IPEndPoint(IPAddress.Parse(s), i); //tentando declarar uma variável pública
            client.Connect(IP_End);
            if (client.Connected)
            {
                STW = new StreamWriter(client.GetStream());
                STR = new StreamReader(client.GetStream());
                STW.AutoFlush = true;
                worker1.DoWork += worker1_DoWork;
                worker2.DoWork += worker2_DoWork;
                worker1.RunWorkerAsync();
                worker2.WorkerSupportsCancellation = true;
                isConnected = true;
            }
            return;
        }

        public void TCPSend(string input_to_send)
        {
            isConnected = false;
            STW.Write(input_to_send);
            STW.Flush();
            isConnected = true;
            input_to_send = "";
        }

        private void worker2_DoWork(object sender, DoWorkEventArgs e)
        {
            client = new TcpClient();
            IPEndPoint IP_End = new IPEndPoint(IPAddress.Parse(ip), port);
            client.Connect(IP_End);
            if (client.Connected)
            {
                STW.WriteLine(input_to_send);
                STW.Flush();
                input_to_send = "";
                worker2.CancelAsync();
            }
        }

        private void worker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (isConnected)
            {
                receive = STR.ReadLine();
                //implementar comandos de receber
            }
        }*/
    }
}
