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
            Console.Write("Cate numere doriti sa contina vectorul?(-100,100) : ");            
            int a = int.Parse(Console.ReadLine());
            int[] arr;
            arr = new int[a];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-10, 10);                
            }
            PrintArray(arr);
            Console.WriteLine();
            int[] rmv = new int[a];
            Array.Sort(arr);
            for (int i = 1; i < arr.Length-1; i++)
            {
                if(arr[i] == arr[i - 1])
                {
                    arr = arr.Where((source, index) => index != i).ToArray();
                }  
            }
            Console.WriteLine("Vectorul fara numere care se repeta:");
            PrintArray(arr);            
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