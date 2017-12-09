using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZRozw_6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> figury = new List<Figura>();
            figury.Add(new Kwadrat(4));
            figury.Add(new Trojkat(3,4,5));
            figury.Add(new Kwadrat(7));
            figury.Add(new Trojkat(5, 12, 13));
            foreach(var figura in figury)
            {
                Console.WriteLine(figura.ObliczPole());
            }

            Console.ReadKey();
        }
    }
}
