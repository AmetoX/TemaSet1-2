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
            int[] arr2 = new int[a];
            int[] arr3 = new int[a+a];
            GenerateArray(arr);
            GenerateArray(arr2);
            PrintArray(arr);
            Console.WriteLine();
            PrintArray(arr2);
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < arr2.Length; i++)
            {
                for(int j = 0; j < arr.Length; j++)
                {
                    if (arr2[i] == arr[j])
                    {
                        sb.Append(arr[j]);
                    }
                }
            }
            Console.WriteLine();
            for(int i = 0; i < sb.Length; i++)
            {
                Console.Write(sb[i]+" ");
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
                arr[i] = rnd.Next(0, 10);
            }
            return arr;
        }
    }
} 