using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Hall_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int itemsCount = int.Parse(Console.ReadLine());
            double totalSum = 0;
            for (int i = 0; i < itemsCount; i++)
            {
                string productName = Console.ReadLine();
                double productPrice = double.Parse(Console.ReadLine());
                int productCount = int.Parse(Console.ReadLine());

                productName += productCount > 1 ? "s" : "";

                Console.WriteLine($"Adding {productCount} {productName} to cart.");
                totalSum += (productPrice * productCount);
            }

            Console.WriteLine($"Subtotal: ${totalSum:F2}");
            if (budget >=totalSum)
            {
                Console.WriteLine($"Money left: ${budget - totalSum:F2}");
            }
            else
            {
                Console.WriteLine($"Not enough. We need ${totalSum - budget:F2} more.");
            }
            
        }
    }
}
