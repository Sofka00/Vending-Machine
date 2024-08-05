using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine.Storage
{
    public class ProductModel
    {

        public string Name { get; set; }
        public DateTime InputData { get; set; }
        public DateTime NotConditionData { get; set; }
        public int Count { get; set; }
        public ProductModel()
        {
        }

        public ProductModel(string name, DateTime inputData, DateTime notConditionData, int count)
        {
            Name = name;
            InputData = inputData;
            NotConditionData = notConditionData;
            Count = count;
        }
    }
}
