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
            Console.Write("Cate numere doriti sa contina vectorul?(0,100) : ");
            int a = int.Parse(Console.ReadLine());
            int[] arr;
            arr = new int[a];
            int b = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-100, 100);
                arr[i] = b++;
            }
            PrintArray(arr);
            Console.WriteLine();
            Console.Write("Ce numar de pe ce pozitie dori sa stergei(pozitia elementelor incepe de la 0)?: ");
            int e = int.Parse(Console.ReadLine());
            arr = arr.Where((source, index) => index != e).ToArray();
            arr = arr.Where((source, index) => index != 0).ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                int c = arr[i];
                if (c % c == 0)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                        if (arr[j] % c == 0)
                            arr = arr.Where((source, index) => index != j).ToArray();
                }

            }
            Console.WriteLine("Toate numerele prime mai mici sau egale cu a (ciurul lui Eratostene): ");
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