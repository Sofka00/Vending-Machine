using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vending_Machine.Recipes;
using Vending_Machine.Storage;

namespace Vending_Machine.Machine
{
    public class CoffeCocaoTeaMachine : AbstractMachine
    {
        

        public CoffeCocaoTeaMachine(int id, decimal balance, Dictionary<string, int> product, string adress) : base(id, balance, adress)
        { 

        }
        public override void AddRecipe(string name, Dictionary<string, int> ingredients)
        {
            ModelRecepes newRecipe = new ModelRecepes(name, ingredients);

            if (_recipes.Contains(newRecipe))
            {
                Console.WriteLine($"Recipe {name} already exists.");
                return;
            }

            _recipes.Add(newRecipe);
            Console.WriteLine($"Recipe {name} added successfully.");
        }
        //public override void AddRecipe(string name, Dictionary<string, int> ingredients)
        //{
        //    ModelRecepes recipe = new ModelRecepes(name, ingredients);
        //    _recipes.Add(recipe);
        //    Console.WriteLine($"Recipe {name} added successfully.");
        //}
        //public override void DisplayRecipes()
        //{
        //    if (_recipes.Count == 0)
        //    {
        //        Console.WriteLine("No recipes in the coffee machine.");
        //        return;
        //    }

        //    Console.WriteLine("Recipes in the coffee machine:");
        //    foreach (var recipe in _recipes)
        //    {
        //        Console.WriteLine($"Recipe: {recipe.Name}");
        //        foreach (var ingredient in recipe.Ingredients)
        //        {
        //            Console.WriteLine($"  {ingredient.Key}: {ingredient.Value}");
        //        }
        //    }
        //}



        public override void AddProduct(string productName, int quantity, int countDayCondition)
        {
            _storage.AddProduct(productName, quantity, countDayCondition);
        }
        public override void DisplayProducts()
        {
          _storage.DisplayProducts();
        }
    }
}
