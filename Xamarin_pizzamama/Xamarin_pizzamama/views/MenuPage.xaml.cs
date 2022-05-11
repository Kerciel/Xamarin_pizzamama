using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_pizzamama.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
            TITRE.Opacity = 0;
            TITRE.RotateTo(360, 2000);
        }

        void NavPizza(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new MainPage());
        }

        void NavContact(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new ContactPage());
        }

        //Animation sur le titre du menu 
        protected override void OnAppearing()
        {
            base.OnAppearing();
            TITRE.Opacity = 0;

            TITRE.FadeTo(1, 4000);



        }
    }
}