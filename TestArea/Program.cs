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
            Console.Write("Introduceti un nr. in baza 10: ");
            int a = int.Parse(Console.ReadLine());
        bk:
            Console.Write("In ce baza doriti sa convertiti numarul?: ");
            int b = int.Parse(Console.ReadLine());
            switch (b)
            {
                case 2:
                    Console.WriteLine($"Numarul {a} convertit in baza {b} este: " + Convert.ToString(a, 2));
                    break;
                case 10:
                    Console.WriteLine($"Numarul {a} convertit in baza {b} este: " + Convert.ToString(a, 10));
                    break;
                case 16:
                    Console.WriteLine($"Numarul {a} convertit in baza {b} este: " + Convert.ToString(a, 16));
                    break;
                default:
                    Console.WriteLine("Baza gresita !!!! Incercati dinou...");
                    goto bk;
            }

        }       
        private static void PrintArray(int[] arr)
        {
            Console.Write("Vectorul: ");
            for (int i = 0; i<arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
        private static int[] GenerateArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-100, 100);
            }
            return arr;
        }
    }
} 