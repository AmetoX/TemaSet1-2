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
            Console.Write("Cate numere doriti sa contina vectorul?: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Scrieti nr pe care il cautati(intr-e -100 si 100): ");
            int b = int.Parse(Console.ReadLine());
            int c = 0;
            bool ok = false;
            int[] arr;
            arr = new int[a];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-100, 100);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                
                if(arr[i]==b)
                {
                    c = i;
                    ok = true;
                }

            }
            
            PrintArray(arr);
            Console.WriteLine();
            if (ok)
            {
                Console.WriteLine($"Numarul cautat({b}) a fost gasit si este pe pozita: {c}");
            }
            else
            {
                Console.WriteLine($"Numarul {b} nu se afla in acest sir.");
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