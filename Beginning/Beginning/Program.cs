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
            Console.WriteLine("Wie alt bist du?");
            int age = Convert.ToInt32(Console.ReadLine());
            if(age < 18)
            {
                Console.WriteLine("Du kommst hier nicht rein!");
            }
            else if (age < 28)
            {
                Console.WriteLine("Bitte ihren Ausweis zeigen");
            }
            else
            {
                Console.WriteLine("Viel Spaß auf der Feier!!");          
            }
            Console.ReadLine();
        }


    }
}