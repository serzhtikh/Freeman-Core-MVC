using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    public class Product
    {
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public Product Related { get; set; }

        public static Product[] GetProducts()
        {
            var lifejacket = new Product {Name = "Lifejacket", Price = 48.95M};
            var kayak = new Product {Name = "Kayak", Price = 275M, Related = lifejacket};

            return new Product[] {kayak, lifejacket, null};
        }
    }
}
