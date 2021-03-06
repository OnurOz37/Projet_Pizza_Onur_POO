using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Projet_PizzaOnur
{
    class Program
    {
        static List<Pizza> GetPizzaFromCode()
        {
            var pizzas = new List<Pizza>() {
             new Pizza("4 fromages", 11.5f, true, new List<string>{"Cantal", "Mozza","Tomate"}),
             new Pizza("Kebab", 11f, false, new List<string>{"Cantal", "Poulet", "Mozza", "Chevre", "Miel", "Ananas" ,"Tomate"}),
             new Pizza("4 saisons", 12.5f, true, new List<string>{"cantal", "Curry", "Mozza", "Chevre", "Miel","Tomate" }),
             new Pizza("Calzone", 11.5f, false, new List<string>{"Boeuf", "Poulet", "Mozza", "Chevre", "Miel", "Ananas" }),
             //new PizzaPersonalisee(),

             //new PizzaPersonalisee()
             };
            return pizzas; 
        }
        static List<Pizza> GetPizzaFromFile(string filename)
        {
            filename = "pizzas.json";
            string json = File.ReadAllText(filename);
            var pizzas = JsonConvert.DeserializeObject<List<Pizza>>(json);
            return pizzas; 
        }
        static void GenerateJsonFile(List<Pizza> pizzas, string filename)
        {
            string json = JsonConvert.SerializeObject(pizzas);
            //Console.WriteLine(json);

            File.WriteAllText("pizzas.json", json);
        }
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //var pizza1 = new Pizza("4 fromages", 11.5f, true);

            // pizza1.Afficher(); 

            /* var pizzas = new List<Pizza>() { 
             new Pizza("4 fromages", 11.5f, true, new List<string>{"Cantal", "Mozza","Tomate"}),
             new Pizza("Kebab", 11f, false, new List<string>{"Cantal", "Poulet", "Mozza", "Chevre", "Miel", "Ananas" ,"Tomate"}),
             new Pizza("4 saisons", 12.5f, true, new List<string>{"cantal", "Curry", "Mozza", "Chevre", "Miel","Tomate" }),
             new Pizza("Calzone", 11.5f, false, new List<string>{"Boeuf", "Poulet", "Mozza", "Chevre", "Miel", "Ananas" }),
             //new PizzaPersonalisee(),

             //new PizzaPersonalisee()
             };
            */
            /*var json = JsonConvert.SerializeObject(pizzas);
            //Console.WriteLine(json);

            File.WriteAllText("pizzas.json", json); // ici on a générér un fichier json avec le json de notre liste pizzas
            */

            //charger les données du fichier Json, déserialiser les données, 
            /* var path = "pizzas.json";
             string json = File.ReadAllText(path);
             var pizzas = JsonConvert.DeserializeObject<List<Pizza>>(json); */


            // pizzas = pizzas.OrderBy(p => p.prix).ToList(); //pour trier par prix


            //Pizza pizzaPrixMin = null;
            //Pizza pizzaPrixMax = null;


            //pizzaPrixMin = pizzas[0];
            //pizzaPrixMax= pizzas[0];

            //foreach (var pizza in pizzas)
            //{
            //    if (pizza.prix < pizzaPrixMin.prix)

            //    {
            //        pizzaPrixMin = pizza; 
            //    }
            //    if (pizza.prix > pizzaPrixMax.prix)

            //    {
            //        pizzaPrixMax = pizza;
            //    }


            //}
            // pizzas = pizzas.Where(p => p.vegetarienne).ToList();  // ca va afficher seulement les pizzas vegetariennes
            //pizzas = pizzas.Where(p => p.contientIngredient("tomate")).ToList();  //pizza qui contient l'ingredient souhaité
            var filename = "pizzas.json"; 
            Console.WriteLine();
            //var pizzas = GetPizzaFromCode(); 
            
            var pizzas = GetPizzaFromFile(filename);
            //GenerateJsonFile(pizzas, filename);
            Console.WriteLine("Voici notre menu: ");
            foreach (var pizza in pizzas)
            {
                
                pizza.Afficher(); 
            }

            //Console.WriteLine();
            //Console.WriteLine("La pizza la plus chère est la pizza: ");
            //pizzaPrixMax.Afficher();
            //Console.WriteLine("La pizza la moins chère est la pizza: ");
            //pizzaPrixMin.Afficher(); 
        }
    }
}
