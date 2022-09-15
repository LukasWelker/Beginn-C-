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
            Console.WriteLine("Gib mir ein Wort!");
            string entry = Console.ReadLine();
           
            string trimmed_entry = entry.Trim(' ', 'a');

            Console.WriteLine("Old string " + entry + ":");
            Console.WriteLine("New string " + trimmed_entry + ":");

            Console.ReadLine();
        }


    }
}