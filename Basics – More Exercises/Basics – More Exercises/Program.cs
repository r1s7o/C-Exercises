using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics___More_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            int spaces = x - 2;
            for (int i = 0; i < x / 2; i++, spaces -= 2)
            {
                Console.WriteLine($"{new string(' ', i)}x{new string(' ', spaces)}x");
            }
            Console.WriteLine($"{new string(' ', x / 2)}x");
            spaces = 1;
            for (int i = x / 2; i > 0; i--, spaces += 2)
            {
                Console.WriteLine($"{new string(' ', i - 1)}x{new string(' ', spaces)}x");
            }
        }
    }
}
