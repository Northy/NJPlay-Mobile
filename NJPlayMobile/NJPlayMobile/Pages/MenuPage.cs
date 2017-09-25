using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace NJPlayMobile.Pages
{
    public class MenuPage : TabbedPage
    {
        public MenuPage()
        {
            Title = "Menu";

            Children.Add(new ConnectPage()
            {
                Title = "Conectar",
                Icon = "connecticon.png"
            });
            Children.Add(new ControlsPage()
            {
                Title = "Controles",
                Icon = "playicon.png"
            });
        }
    }
}