using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_PizzaOnur
{
    public class Pizza
    {
        protected string nom;
        public float prix { get; init; }
        public bool vegetarienne { get; init; }


        public List<string> ingredients { get; protected set; }


        public Pizza(string nom, float prix, bool vegetarienne, List<string> ingredients)
        {

            this.nom = nom;
            this.prix = prix;
            this.vegetarienne = vegetarienne;
            this.ingredients = ingredients;

        }



        public void Afficher()
        {
            string badgeVegetarienne = vegetarienne ? "(V)" : "";

            string nomAfficher = formatPremiereLettreMajuscule(nom);

            /* var ingredientAfficher = new List<string>();

             foreach (var ingredient in ingredients)
             {
                 ingredientAfficher.Add= formatPremiereLettreMajuscule(ingredient);
             }
            */
            //ou on le fait avec Select

            var ingredientsAfficher = ingredients.Select(i => formatPremiereLettreMajuscule(i)).ToList();


            Console.WriteLine(nom + "-" + badgeVegetarienne + "-" + "Prix: " + prix + "€");
            Console.WriteLine(string.Join("- ", ingredientsAfficher));
            Console.WriteLine();


        }
        public bool contientIngredient (string ingredient)
        {
            return ingredients.Where(i => i.ToLower().Contains(ingredient)).ToList().Count > 0;
        }

        private static string formatPremiereLettreMajuscule(string s)
        {

            if (string.IsNullOrEmpty(s))
            {
                return s;
            }
            string miniscules = s.ToLower();
            string majuscules = s.ToUpper();
            string resultat;


            resultat = majuscules[0] + miniscules.Substring(1);
            return resultat;



        }

    }
}
