using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vending_Machine.Recipes;

namespace Vending_Machine.Machine
{
    public class JuiseMachine : AbstractMachine
    {

        public int CountOfOranges { get; set; }
        private DateTime lastOrangeReplacement;

        public JuiseMachine(int id, decimal balance, Dictionary<string, string> product, string adress) : base(id, balance, adress)
        {
            CountOfOranges = 0;
            lastOrangeReplacement = DateTime.Now;
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

        public override void BuyDrink(string drinkName)
        {
            if (drinkName != "Fresh Orange Juice")
            {
                Console.WriteLine($"This machine only makes Fresh Orange Juice.");
                return;
            }

            if ((DateTime.Now - lastOrangeReplacement).TotalDays > 2)
            {
                Console.WriteLine("Oranges are old and need to be replaced.");
                return;
            }

            if (CountOfOranges < 2)
            {
                Console.WriteLine("Not enough oranges to make juice.");
                return;
            }

            CountOfOranges -= 2;
            Console.WriteLine("Successfully made Fresh Orange Juice.");
        }

        public override void DisplayProducts()
        {
            Console.WriteLine("Products in storage:");
            Console.WriteLine($"Oranges: {CountOfOranges}");
        }

   

        public override void AddProduct(string productName, int quantity, int countDayCondition)
        {

            if (productName == "Orange")
            {
                CountOfOranges += quantity;
                Console.WriteLine($"{quantity} oranges added. Total oranges: {CountOfOranges}");
            }
            else
            {
                Console.WriteLine("This machine only accepts oranges.");
            }
        }
    }
    }

