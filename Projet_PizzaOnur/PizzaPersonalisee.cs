using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_PizzaOnur
{
    public class PizzaPersonalisee : Pizza
    {
        static int nbPizzaPersonnalisee = 0; 
        public PizzaPersonalisee(): base("Pizza Personalisée", 5f, false, null)
        {
            nbPizzaPersonnalisee++;
            
            nom = "Personnalisée " + nbPizzaPersonnalisee;
            
            ingredients = new List<string>();

            while (true)
            {
                Console.Write("Veuillez ajouter vos ingrédients pour la pizza personnalisée n° "+nbPizzaPersonnalisee+ " (1.50€ par ingrédient) " + "et appuyer sur ENTER: ");
                var ingredientChoisi = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(ingredientChoisi))
                {
                    break; 
                }
                
                if (ingredients.Contains(ingredientChoisi))
                {
                    Console.WriteLine("Vous avez déjà renseigné cet ingrédient, veuillez rentrer un nouveau ingrédient." );
                    ingredients.Remove(ingredientChoisi); 
                }
                ingredients.Add(ingredientChoisi);
                Console.WriteLine(string.Join(", ", ingredients));
            }
            Console.WriteLine();

            prix = 5 + ingredients.Count * 1.5f;
            //Console.WriteLine("Prix ingrédient=1.5€");

        }
    }
}
