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
            string entry = "Das ist ein Text mit Wörtern";

            //0: Das
            //1: ist
            //2: ein
            //3: Text
            //4: mit
            //5: Wörtern
            string[] entries = entry.Split(' ');
            foreach(String wort in entries)
            {
                Console.WriteLine(wort);    
            }
            for (int i= 0; i < entries.Length; i++)
            {
                Console.WriteLine(entries[i]);  
            }
           

            Console.ReadLine();
        }


    }
}