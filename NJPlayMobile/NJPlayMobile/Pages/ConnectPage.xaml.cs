using NJPlayMobile.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NJPlayMobile.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConnectPage : ContentPage
    {
        public ConnectPage()
        {
            InitializeComponent();
            bConnect.Clicked += bConnect_Click;
        }

        private void bConnect_Click(object sender, EventArgs e)
        {
            TCP tCP = new TCP();
            tCP.Connect(sIP.Text, int.Parse(sPort.Text));
            if (tCP.isConnected)
            {
                bConnect.IsEnabled = false;
            }
        }
    }
}