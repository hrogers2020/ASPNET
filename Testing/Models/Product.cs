using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Testing.Models
{
    public class Product
    {
        public Product()
        {

        }

        public int ProductID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string InstrumentType { get; set; }
        public int StockLevel { get; set; }
        public int Year { get; set; }
        public string Condition { get; set; }

        //public string PhotoLink { get; set; }
        //public IEnumerable<Category> Categories { get; set; }

    }
}
