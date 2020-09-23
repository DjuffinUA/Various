using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace The_character
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = null, Class = null, Title = null, Characteristics = "Характеристики: ";
            int Level = 1, Endurance = 0, Strength = 0, Agility = 0, Intellect = 0;


            Name = Write();

            Class = ClassName();

            Console.WriteLine("" + Name);

        }

        static string Write()
        {
            Console.WriteLine("");
            string Line = Console.ReadLine();
            return Line;
        }

        static string ClassName()
        {
            int n = 0;
            string Class = null;
            Console.WriteLine("");
            n = Console.ReadLine();
            if (n == 1)
            {
                Class = " ";
            }
            return Class;
        }
    }
}
