using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Xamarin_pizzamama
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            
            var navigationpage = new NavigationPage(new MainPage());
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
