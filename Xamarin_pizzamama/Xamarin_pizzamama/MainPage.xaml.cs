using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net;
using Newtonsoft.Json;
using System.Diagnostics;
using Xamarin_pizzamama.Model;

namespace Xamarin_pizzamama
{
    
    public partial class MainPage : ContentPage
    {

        List<Pizza> pizzas;
        public MainPage()
        {
            //initialise la page 
            InitializeComponent();
            
            pizzas = new List<Pizza>();


            //imageuURl
            pizzas.Add(new Pizza { nom="La 4 Fromage", prix = 13 , ingredients = new List<string> { "sauce tomate", "comte", "pesto", "olive" }, imageURL= "https://img.cuisineaz.com/660x660/2021/02/25/i159373-pizza-margherita.jpeg" });
            pizzas.Add(new Pizza { nom = "La végètarienne", prix = 10, ingredients = new List<string> { "sauce tomate", "comte", "boursin", "olive" }, imageURL= "https://www.cuisineactuelle.fr/imgre/fit/https.3A.2F.2Fi.2Epmdstatic.2Enet.2Fcac.2F2021.2F04.2F29.2Fd9891daa-c362-4abd-b420-be510909c90b.2Ejpeg/750x562/quality/80/crop-from/center/cr/wqkgUGxvdG9uIC8gUGhvdG9jdWlzaW5lIC8gQ3Vpc2luZSBBY3R1ZWxsZQ%3D%3D/pizza-montagnarde.jpeg" });
            pizzas.Add(new Pizza { nom = "La montagnarde", prix = 12, ingredients = new List<string> { "sauce tomate", "comte", "boursin", "gorgonzola", "mozzarella", "pesto", "olive","viande","oignon","salade" }, imageURL= "https://www.cuisineactuelle.fr/imgre/fit/http.3A.2F.2Fprd2-bone-image.2Es3-website-eu-west-1.2Eamazonaws.2Ecom.2Fcac.2F2018.2F09.2F25.2Ffa3a1409-a184-400c-8d77-e1cb37e57194.2Ejpeg/748x372/quality/80/crop-from/center/pizza-vegetarienne.jpeg" });

            //attrubut la liste des pizzas a lavariable liste
            listes.ItemsSource = pizzas;

            listes.ItemSelected += (sender, e) =>
            {
                if (listes.SelectedItem != null)
                {
                   Pizza item = listes.SelectedItem as Pizza; // on envoie les donnée de la liste recuprer à l'objet item
                    DisplayAlert(item.nom, item.ingredientStr + "/"+ item.prixEuro, "OK");//on affiche une alert
                    listes.SelectedItem = null;//on remet la liste a null 
                }
            };

        }

        
    }
}
