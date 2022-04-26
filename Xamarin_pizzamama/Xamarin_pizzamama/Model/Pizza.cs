using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin_pizzamama.Model
{
    //Creation d'une classe pizza pour les donnée
    public  class Pizza
    {
        //{nom, prix, imageURL, ingredients}
         public string nom { get; set; }
         public int prix { get; set; }
         public string imageURL { get; set; }
         public List<string> ingredients { get; set; }

         //prixEuro(€) 
         public string prixEuro { get { return prix + "€"; } }

         //ingredientStr(string)
         public string ingredientStr { get { return String.Join(",", ingredients); } }

        /* *************************************************Partie dynamique****************************************************
        public string nom ;
        public string prix;
        public string ingrédients;

        public Pizza(string nom, int prix, List<string> ingredients)
        {
            this.nom = nom;
            this.prix = prix + "€";
            this.ingrédients = String.Join(",",ingredients);
        }

        */


    }
}
