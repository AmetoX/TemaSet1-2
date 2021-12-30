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
            Console.Write("Cate numere doriti sa contina vectorul?(-100,100): ");
            int a = int.Parse(Console.ReadLine());
            int[] arr = new int[a];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0, 3);
            }
            PrintArray(arr);
            Console.WriteLine();
            int m = 0;
            bool ok = false;
            double n = a/2;
            for (int i = 0; i < arr.Length; i++)
            {
                int b = arr[i];
                int rp = 0;
                for (int j = 0; j < arr.Length; j++)
                {                   
                    if (b == arr[j])
                    {
                        rp++;
                        if (rp >= n)
                        {
                            m = b;
                            ok = true;
                        }
                        
                    }                     
                }
            }
            if (ok)
            {
                Console.WriteLine($"Numarul majoritar este: {m}");
            }
            else
            {
                Console.WriteLine("Nu este numar majoritar.");
            }       
            Console.WriteLine();

        }
        private static void Swap(int[] arr, int i, int j)
        {
            int aux;
            aux = arr[i];
            arr[i] = arr[j];
            arr[j] = aux;
        }
        public static void PrintArray(int[] arr)
        {
            Console.Write("Vectorul: ");
            for (int i = 0; i<arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
        public static int[] GenerateArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0, 3);
            }
            return arr;
        }
    }
} 