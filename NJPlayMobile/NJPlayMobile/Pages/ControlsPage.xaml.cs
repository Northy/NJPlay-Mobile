using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using NJPlayMobile.Classes;
using System.IO;

namespace NJPlayMobile.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ControlsPage : ContentPage
    {
        public ControlsPage()
        {
            InitializeComponent();

            bSelect.Clicked += bSelect_Clicked;
            bPlay.Clicked += bPlay_Clicked;
            bPause.Clicked += bPause_Clicked;
            bReturn.Clicked += bReturn_Clicked;
            bSkip.Clicked += bSkip_Clicked;
            bSolicitar.Clicked += bSolicitar_Clicked;
            
        }

        private void bSolicitar_Clicked(object sender, EventArgs e)
        {
            TCP tCP = new TCP();
            if (tCP.isConnected)
            {
                List<string> files = new List<string>();
                files = TCP.FetchVideos();
                foreach (string file in files)
                {
                    videoPicker.Items.Add(Path.GetFileName(file));
                }
            }
        }

        private void bSkip_Clicked(object sender, EventArgs e)
        {
            TCP tCP = new TCP();
            tCP.TCPSend("skip");
        }

        private void bReturn_Clicked(object sender, EventArgs e)
        {
            TCP tCP = new TCP();
            tCP.TCPSend("return");
        }

        private void bPause_Clicked(object sender, EventArgs e)
        {
            TCP tCP = new TCP();
            tCP.TCPSend("pause");
        }

        private void bPlay_Clicked(object sender, EventArgs e)
        {
            TCP tCP = new TCP();
            tCP.TCPSend("play");
        }

        private void bSelect_Clicked(object sender, EventArgs e)
        {
            TCP tCP = new TCP();
            tCP.TCPSend(videoPicker.SelectedItem.ToString());
        }
    }
}