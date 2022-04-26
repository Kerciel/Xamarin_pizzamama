using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin_pizzamama.Model
{
    public  class Pizza
    {
        public string nom { get; set; }
        public int prix { get; set; }
        public string imageURL { get; set; }
        public List<string> ingredients { get; set; }
        
        public string prixEuro { get { return prix + "€"; } }
        public string ingredientStr { get { return String.Join(",", ingredients); } }
        

    }
}
