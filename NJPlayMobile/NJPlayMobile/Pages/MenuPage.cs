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

            Children.Add(new ControlsPage()
            {
                Title = "NJPlay",
                Icon = "playicon.png"
            });
        }
    }
}