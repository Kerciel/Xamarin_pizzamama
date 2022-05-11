using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin_pizzamama.views;

namespace Xamarin_pizzamama
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            
            var navigationpage = new NavigationPage(new MenuPage());
            navigationpage.BarBackgroundColor = Color.FromHex("#1abbd4");

            MainPage = navigationpage;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
