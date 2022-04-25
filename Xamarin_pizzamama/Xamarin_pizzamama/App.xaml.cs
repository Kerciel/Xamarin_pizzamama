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

            MainPage = new NavigationPage( new Listespizza());
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
