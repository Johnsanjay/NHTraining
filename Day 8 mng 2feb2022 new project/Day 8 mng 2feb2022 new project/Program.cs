using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_8_mng_2feb2022_new_project
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
        static void Main(string[] args)
        {
            List<Product> product = new List<Product>()
            {
                new Product() {id=1, name = "iphone", price = 400, brand="Apple" },
                new Product(){id=2, name = "Nord", price = 500, brand= "Oneplus" },
                new Product(){id=3, name = "Galaxy", price=100, brand = "Samsung" },
                new Product(){id=4, name = "redmi", price=600, brand="Mi" },
                
            };
            // usingforloop
            for (int i = 0; i < product.Count; i++)
            {
                if (product[i].price > 400)
                    Console.WriteLine($"Name={product[i].name}, Brand={product[i].brand}");
            }

            //foreach loop
            foreach (var p in product)
            {
                if (p.price > 400)
                    Console.WriteLine($"Name={p.name}, Brand={p.brand}");

            }

            // using Lambda Expression
            product.ToList().Where(p => p.price > 400).ToList().ForEach(p => Console.WriteLine($"Name={p.name}, Brand={p.brand}"));

            // using  Linq
            var result = from p in product
                         where p.price > 400
                         select p;
            result.ToList().ForEach(p => Console.WriteLine($"Name={p.name}, Brand={p.brand}"));

            Console.ReadLine();
        }
    }
}
