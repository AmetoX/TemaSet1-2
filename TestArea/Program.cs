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
            Console.Write("Cate numere doriti sa contina vectorul 1?(0,100): ");
            int a = int.Parse(Console.ReadLine());
            int[] arr = new int[a];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0, 100);
            }
            PrintArray(arr);
            QuickSort(arr, 0, arr.Length);
            Console.WriteLine();
            PrintArray(arr);
            Console.WriteLine();
        }
        public static int[] QuickSort(int[]arr, int start, int end)
        {
            if (start < end)
            {
                int pivot = partition(arr, start, end);
                QuickSort(arr,start,pivot);
                QuickSort(arr,pivot+1,end);
            }
            return arr;
        }
        public static int partition(int[]arr,int start,int end)
        {
            int pivot = arr[start];
            int swapindex = start;
            for(int i = start + 1; i < end; i++)
            {
                if (arr[i] < pivot)
                {
                    swapindex++;
                    Swap(arr, i, swapindex);
                }
            }
            Swap(arr, start, swapindex);
            return swapindex;
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
            Console.Write($"Vectorul: ");
            for (int i = 0; i<arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            
        }
        public static int[] GenerateArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0, 50);
            }
            return arr;
        }
        public static void BubbleSort(int[] arr)
        {
            int i;
            bool sortat;
            do
            {
                sortat = true;
                for (i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        Swap(arr, i, i + 1);
                        sortat = false;
                    }
                }
            } while (!sortat);
        }
    }
}
