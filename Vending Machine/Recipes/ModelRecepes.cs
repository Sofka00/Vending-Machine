using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine.Recipes
{
    public class ModelRecepes
    {

        public string Name { get; set; }
        public List<ModelRecepes> _recipes = new List<ModelRecepes>();
        public Dictionary<string, int> Ingredients { get; set; }

        public ModelRecepes(string name, Dictionary<string, int> ingridients)
        {
            Name = name;
            Ingredients = ingridients;
        }

        public ModelRecepes()
        {
        }

        public void DisplayRecipe()
        {
            Console.WriteLine($"Recipe: {Name}");
            foreach (var ingredient in Ingredients)
            {
                Console.WriteLine($"{ingredient.Key}: {ingredient.Value}");
            }
        }
        public void AddRecipe(string name, Dictionary<string, int> ingredients)
        {
            //ModelRecepes recipe = new ModelRecepes(name, ingredients);
            //_recipes.Add(recipe);
            //Console.WriteLine($"Recipe {name} added successfully.");

            ModelRecepes newRecipe = new ModelRecepes(name, ingredients);

            if (_recipes.Contains(newRecipe))
            {
                Console.WriteLine($"Recipe {name} already exists.");
                return;
            }

            _recipes.Add(newRecipe);
            Console.WriteLine($"Recipe {name} added successfully.");
        }

        public override bool Equals( object obj)
        {
            if (obj is ModelRecepes otherRecipe)
            {
                return Name == otherRecipe.Name && Ingredients.SequenceEqual(otherRecipe.Ingredients);
            }
            return false;
        }
        public override int GetHashCode()
        {
            int hash = Name.GetHashCode();
            foreach (var ingredient in Ingredients)
            {
                hash ^= ingredient.Key.GetHashCode() ^ ingredient.Value.GetHashCode();
            }
            return hash;
        }
    }
}
