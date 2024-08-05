using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vending_Machine.Machine;
using Vending_Machine.Recipes;
using Vending_Machine.Storage;

namespace Vending_Machine
{
    public class Program
    {
        static void Main(string[] args)
        {

            //CoffeMachine coffeMachine = new CoffeMachine(1, 0m,  new Dictionary<string, string>());
            //Dictionary<string, int> ingredients = new Dictionary<string, int>
            //{
            //    {"Coffee", 100},
            //    {"Milk", 150 },
            //    {"Water",100}
            //};
            //coffeMachine.AddRecipe("Latte", ingredients);
            //Console.ReadLine(); 
            //coffeMachine.DisplayRecipes();
            //Console.ReadLine();

            CoffeCocaoTeaMachine coffeTea = new CoffeCocaoTeaMachine(1, 0m, new Dictionary<string, int>(), "");
            coffeTea.AddProduct("Green", 100, 30);
            coffeTea.AddProduct("Coffee", 500, 30);
            coffeTea.AddProduct("Milk", 1000, 10);
            coffeTea.AddProduct("Water", 1000, 10);

            Dictionary<string,int> ingredients = new Dictionary<string, int> 
            {
                {"Green Tea", 2 },
                {"Water", 150 },
            };
            coffeTea.AddRecipe("Green Tea",ingredients);
            Console.ReadLine();
            coffeTea.DisplayProducts();
            Console.ReadLine();
            coffeTea.DisplayRecipes();
            Console.ReadLine();

            CoffeMachine coffee = new CoffeMachine (2, 0m, new Dictionary<string, int>(),"");
            coffee.AddProduct("Coffee", 1000, 15);
            coffee.AddProduct("Water", 1000, 10);

            Dictionary<string, int> ingredient = new Dictionary<string, int>
            {
                {"Coffee", 2 },
                {"Water", 150 },
            };
            coffee.AddRecipe("Americano", ingredient);
            Console.ReadLine();
            Console.ReadLine();
            coffee.DisplayProducts();
            Console.ReadLine();
            coffee.DisplayRecipes();
            Console.ReadLine();





        }
    }
}
