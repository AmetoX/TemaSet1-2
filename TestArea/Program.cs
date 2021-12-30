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
            bool ok = true;
            GenerateArray(arr);
            PrintArray(arr);
            do
            {
                ok = true;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        Swap(arr, i, i + 1);
                        ok = false;
                    }
                }
            } while (!ok);
            Console.WriteLine();
            PrintArray(arr);
            Console.WriteLine();
            int b = a-1;
            int aux;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    aux = arr[b];
                    arr[b] = arr[i];
                    arr[i] = aux;
                    b--;
                }
            }
            PrintArray(arr);
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
                arr[i] = rnd.Next(0, 2);
            }
            return arr;
        }
    }
} 