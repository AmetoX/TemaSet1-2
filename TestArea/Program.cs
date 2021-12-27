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
            int b = 3;
            int[] arr;
            arr = new int[a];
            GenerateArray(arr);
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
                arr[i] = rnd.Next(-100, 100);
            }
            return arr;
        }
    }
} 