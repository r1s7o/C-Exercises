using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Megapixels
{
    class Program
    {
        static void Main(string[] args)
        {
            int resolutionW = int.Parse(Console.ReadLine());
            int resolutionH = int.Parse(Console.ReadLine());

            double megapixels = Math.Round(resolutionW * resolutionH / 1000000.0, 1);
            Console.WriteLine($"{resolutionW}x{resolutionH} => {megapixels}MP");
        }
    }
}
