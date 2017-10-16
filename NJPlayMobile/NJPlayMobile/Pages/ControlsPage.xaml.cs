using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using NJPlayMobile.Classes;
using System.IO;
using System.Net.Sockets;
using System.Net;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NJPlayMobile.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ControlsPage : ContentPage
    {
        public TcpClient client;
        public StreamReader STR;
        public StreamWriter STW;
        public String input_to_send;
        public string receive;
        public BackgroundWorker worker1 = new BackgroundWorker();
        public BackgroundWorker worker2 = new BackgroundWorker();

        public ControlsPage()
        {
            InitializeComponent();

            bConnect.Clicked += bConnect_Click;
            bPlayPause.Clicked += bPlayPause_Clicked;
            bReturn.Clicked += bReturn_Clicked;
            bSkip.Clicked += bSkip_Clicked;
            bVolumeUp.Clicked += bVolumeUp_Clicked;
            bVolumeDown.Clicked += bVolumeDown_Clicked;

            worker1.DoWork += worker1_DoWork;
            worker2.DoWork += worker2_DoWork;
        }

        private void bVolumeDown_Clicked(object sender, EventArgs e)
        {
            input_to_send = "vDown";
            worker2.RunWorkerAsync();
        }

        private void bVolumeUp_Clicked(object sender, EventArgs e)
        {
            input_to_send = "vUp";
            worker2.RunWorkerAsync();
        }

        private void bConnect_Click(object sender, EventArgs e)
        {
            client = new TcpClient();
            IPEndPoint IP_End = new IPEndPoint(IPAddress.Parse(sIP.Text), int.Parse(sPort.Text));
            client.Connect(IP_End);
            if (client.Connected)
            {
                bConnect.IsEnabled = false;
                sIP.IsEnabled = false;
                sPort.IsEnabled = false;

                STW = new StreamWriter(client.GetStream());
                STR = new StreamReader(client.GetStream());

                worker1.RunWorkerAsync();
                worker2.WorkerSupportsCancellation = true;

                input_to_send = "connected";
                worker2.RunWorkerAsync();
            }
        }

        private void bSkip_Clicked(object sender, EventArgs e)
        {
            input_to_send = "skip";
            worker2.RunWorkerAsync();
        }

        private void bReturn_Clicked(object sender, EventArgs e)
        {
            input_to_send = "return";
            worker2.RunWorkerAsync();
        }

        private void bPlayPause_Clicked(object sender, EventArgs e)
        {
            input_to_send = "playpause";
            worker2.RunWorkerAsync();
        }

        private void worker2_DoWork(object sender, DoWorkEventArgs e)
        {
                STW.WriteLine(input_to_send);
                STW.Flush();
                input_to_send = "";
                worker2.CancelAsync();
        }

        private void worker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (client.Connected)
            {
                receive = STR.ReadLine();
                //implementar comandos de receber
            }
        }
    }
}