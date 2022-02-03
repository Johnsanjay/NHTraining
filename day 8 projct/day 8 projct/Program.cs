using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_8_projct
{
    class Product
    {
        public int id;
        public string name;
        public int price;
        public string brand;
    }
    internal class Program
    {
      public  static void main(string[] args)
        {
            List<Product> product = new List<Product>()
            {
                new Product() {id=1, name = "iphone", price = 400, brand ="apple" },
                new Product(){id=2, name = "nord", price = 500, brand = "Oneplus" },
                new Product(){id=3, name = "galaxy", price = 1000, brand = "Razer" },
                new Product(){id=4, name = "redmi", price = 600, brand ="Mi" }
               
            };
            //  using forloop
            for (int i = 0; i < product.Count; i++)
            {
                if (product[i].price > 500)
                    Console.WriteLine($"Name={product[i].name}, Brand={product[i].brand}");
            }
            // using foreach loop
            foreach (var p in product)
                {
                    if (p.price > 500)
                        Console.WriteLine($"Name={p.name}, Brand={p.brand}");

                }
            // using Lambda Expression
            product.ToList().Where(p => p.price > 500).ToList().ForEach(p => Console.WriteLine($"Name={p.name}, Brand={p.brand}"));

            // using LinQ
            var result = from p in product
                         where p.price > 500
                         select p;
            result.ToList().ForEach(p => Console.WriteLine($"Name={p.name}, Brand={p.brand}"));

            Console.ReadLine();
        }
    }
}
