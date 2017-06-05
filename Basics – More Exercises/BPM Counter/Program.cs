using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPM_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            double bpm = int.Parse(Console.ReadLine());
            int beatsCount = int.Parse(Console.ReadLine());
            double bars = Math.Round(beatsCount / 4.0, 1);
            int durationInSecs = (int)((beatsCount / bpm) * 60);
            int durationMinutes = durationInSecs / 60;
            durationInSecs %= 60;

            Console.WriteLine($"{bars} bars - {durationMinutes}m {durationInSecs}s");
        }
    }
}
