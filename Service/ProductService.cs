using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PurchaseCalculator.Model;
using PurchaseCalculator.Service.Interfaces;

namespace PurchaseCalculator.Service
{
    public class ProductService : IProductService
    {
        public List<Product> AddProducts()
        {
            List<Product> cart = new List<Product>();

            Console.WriteLine("Enter product details (or press ENTER to finish):");
            while (true)
            {
                Console.Write("Enter product name: ");
                string name = Console.ReadLine();

                if (string.IsNullOrEmpty(name)) break;

                Console.Write("Enter product price: $");
                if (!decimal.TryParse(Console.ReadLine(), out decimal cost))
                {
                    Console.WriteLine("Invalid price. Try again.");
                    continue;
                }

                cart.Add(new Product(name, cost));
            }

            if (!cart.Any())
            {
                Console.WriteLine("No products added.");
            }

            return cart;
        }
    }
}
