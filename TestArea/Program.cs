using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace TestArea
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            TextReader load = new StreamReader($@"..\..\Test\dani.txt");
            string[] input = load.ReadLine();
            
            foreach (string letter in input)
            {
                // Get the integral value of the character.
                int value = Convert.ToInt32(letter);
                // Convert the integer value to a hexadecimal value in string form.
                Console.WriteLine($"Hexadecimal value of {letter} is {value:X}");
            }

        }

        private static void lista()
        {
            Console.WriteLine("Fisiere disponibile: ");
            Console.WriteLine("1.dani");
            Console.WriteLine("2.");
            Console.WriteLine("3.");
            Console.WriteLine("4.");
        }
    }
}