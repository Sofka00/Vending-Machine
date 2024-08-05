using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Vending_Machine.Recipes;
using Vending_Machine.Storage;

namespace Vending_Machine
{
    public abstract class AbstractMachine
    {

        public int Id { get; private set; }
        public decimal BalanceMachine { get; protected set; }
        public ProductStorage _storage = new ProductStorage();
        public List<ModelRecepes> _recipes = new List<ModelRecepes>();
        public string _adress;
        protected AbstractMachine(int id, decimal balance, string adress)
        {
            Id = id;
            BalanceMachine = balance;
            _adress = adress;
        }

        public virtual void BuyDrink(string drinkName)
        {
            ModelRecepes recipe = new ModelRecepes();
            Console.WriteLine($"Buying drink: {drinkName}");
            foreach (var item in _recipes)
            {
                if (item.Name == drinkName)
                {
                    recipe = item;
                    break;
                }
            }
            if (recipe == null)
            {
                Console.WriteLine($"Recipe for {drinkName} not found.");
                return;
            }
            foreach (var item in recipe.Ingredients)
            {
                if (_storage.FindName(item.Key) != null && _storage.FindName(item.Key).Count >= item.Value)
                {
                    _storage.RemoveProduct(item.Key, item.Value);
                }
                else
                {
                    Console.WriteLine($"Not enough {item.Key} in storage.");
                    return;
                }
            }

            Console.WriteLine($"Successfully bought {drinkName}.");

        }

        public  void DisplayRecipes()
        {
            if (_recipes.Count == 0)
            {
                Console.WriteLine("No recipes in the coffee machine.");
                return;
            }

            Console.WriteLine("Recipes in the coffee machine:");
            foreach (var recipe in _recipes)
            {
                Console.WriteLine($"Recipe: {recipe.Name}");
                foreach (var ingredient in recipe.Ingredients)
                {
                    Console.WriteLine($"  {ingredient.Key}: {ingredient.Value}");
                }
            }
        }


        public abstract void AddRecipe(string name, Dictionary<string, int> ingredients);
        public abstract void AddProduct(string productName, int quantity, int countDayCondition);
        public abstract void DisplayProducts();

    }
}




