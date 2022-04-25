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

namespace Xamarin_pizzamama
{
    class Pizza
    {
        public string nom;
        public int prix;
        public List<string> ingredients;

        public Pizza(string nom, int prix, List<string> ingredients)
        {
            this.nom = nom;
            this.prix = prix;
            this.ingredients = ingredients;
        }
        public void AffichagePizza()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Debug.WriteLine(nom + " ( " + String.Join(",", ingredients) + " ) / " + prix + "€");
        }
    }

    
    public partial class MainPage : ContentPage
    {

       
            public MainPage()
        {
            string url = "https://codeavecjonathan.com/res/pizzas2.json";
            List<Pizza> pizza = GetPizzaFormUrl(url);
           
            InitializeComponent();
            

        }

        static List<Pizza> GetPizzaFormUrl(string url)
        {
            var webclient = new WebClient();
            string json = null;
            try
            {
                json = webclient.DownloadString(url);
                Debug.WriteLine(json);
            }
            catch (WebException ex)
            {
                if (ex.Response != null)
                {
                    var statusCode = ((HttpWebResponse)ex.Response).StatusCode;
                    if (statusCode == HttpStatusCode.NotFound)
                    {
                        Debug.WriteLine("ERREUR RESEAU: Non trouvé");
                        return null;
                    }
                    else
                    {

                            Debug.WriteLine("ERREUR RESEAU:" + statusCode);
                        return null;
                    }
                }
                else
                {
                    Debug.WriteLine("ERREUR RESEAU:" + ex.Message);
                    return null;
                }
            }

            return JsonConvert.DeserializeObject<List<Pizza>>(json);
        }
    }
}
