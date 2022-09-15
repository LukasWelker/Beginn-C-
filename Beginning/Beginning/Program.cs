using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("Wie groß bist du in Meter (in Meter?");
            double height = Convert.ToDouble(Console.ReadLine());
            double multiplicator = 3;
            Console.WriteLine("Du bist " + height * multiplicator + " groß!");
            Console.ReadLine();
          
        }
    }
}