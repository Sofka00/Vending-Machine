using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Vending_Machine.Storage
{
    public class ProductStorage
    {

        protected Dictionary<string, ProductModel> Products { get; set; }
        public ProductStorage()
        {
            Products = new Dictionary<string, ProductModel>();
        }

        public void AddProduct(string productName, int quantity, int countDayCondition)
        {


            if (Products.ContainsKey(productName))
            {
                Products[productName].Count += quantity;
                Products[productName].Name = productName;
                Products[productName].InputData = DateTime.Now;
                Products[productName].NotConditionData = Products[productName].InputData.AddDays(countDayCondition);
            }
            else
            {
                Products.Add(productName, new ProductModel
                {
                    Name = productName,
                    Count = quantity,
                    InputData = DateTime.Now,
                    NotConditionData = DateTime.Now.AddDays(countDayCondition)
                });
              
            }

        }
        public bool RemoveProduct(string productName, int quantity)
        {
            if (Products.ContainsKey(productName) && Products[productName].Count >=quantity)
            {
                Products[productName].Count -= quantity;
                if (Products[productName].Count == 0)
                {
                    Products.Remove(productName);
                }
                return true;
            }
            return false;
        }
        public void DisplayProducts()
        {
            Console.WriteLine("Products in storage:");
            foreach (var product in Products)
            {
                Console.WriteLine($"{product.Key}: { product.Value.Count}, {product.Value.InputData}, {product.Value.NotConditionData}");
            }
        }
        public ProductModel FindName(string name)
        {
            ProductModel result = new ProductModel();
            foreach (var product in Products)
            {
                if (name == product.Key)
                {
                    result = product.Value;
                    break;
                }
                else
                {
                    result = null;
                }
            }
            return result;

        }



    }
}
