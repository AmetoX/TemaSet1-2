﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Probleme_Set_3
{
    public class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            //this will be empty for now...
        }
        public static void afisareProblemeSet3()
        {
            Console.WriteLine("Problema 1( )");
            Console.WriteLine("Problema 2( )");
            Console.WriteLine("Problema 3( )");
            Console.WriteLine("Problema 4( )");
            Console.WriteLine("Problema 5( )");
            Console.WriteLine("Problema 6( )");
            Console.WriteLine("Problema 7( )");
            Console.WriteLine("Problema 8( )");
            Console.WriteLine("Problema 9( )");
            Console.WriteLine("Problema 10( )");
            Console.WriteLine("Problema 11( )");
            Console.WriteLine("Problema 12( )");
            Console.WriteLine("Problema 13( )");
            Console.WriteLine("Problema 14( )");
            Console.WriteLine("Problema 15( )");
            Console.WriteLine("Problema 16( )");
            Console.WriteLine("Problema 17( )");
            begin:
            Console.Write("\nType the number of the problem you want to see: ");
            int set3 = int.Parse(Console.ReadLine());
            try
            {
                switch (set3)
                {
                    case 1:
                        set3p1();
                        break;
                    case 2:
                        set3p2();
                        break;
                    case 3:
                        set3p3();
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    default:
                        Console.WriteLine("Wrong problem number.Try again!");
                        goto begin;

                }
            }
            catch
            {
                Console.WriteLine("EROR: wrong input.");
                Console.WriteLine("Please try again...");
                goto begin;
            }
        }
        public static void set3p1()
        {
            Console.Write("Cate numere doriti sa scrieti? : ");
            int a = int.Parse(Console.ReadLine());
            int[] arr;
            arr = new int[a];
            Console.Write("Introduceti numerele unu dupa altul cu un spatiu intr-e ele: ");
            string b = Console.ReadLine();
            string[] local_data = b.Split(' ');
            for (int i = 0; i < a; i++)
            {
                int c = int.Parse(local_data[i]);
                arr[i] = c;
            }
            int suma = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                suma = arr[i] + suma;
            }
            PrintArray(arr);
            Console.WriteLine();
            Console.WriteLine($"Suma sirului introdus este: {suma}");
        }
        public static void set3p2()
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

                if (arr[i] == b)
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
        public static void set3p3()
        {
            Console.Write("Cate numere doriti sa contina vecotrul? : ");
            int a = int.Parse(Console.ReadLine());
            int[] arr;
            arr = new int[a];
            int[] arr2 = new int[a];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-100, 100);
            }
            int b = -1;
            int c = 0;
            int d = 0;
            int e = 0;
            int f = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr2[i] = arr[i];
            }
            Array.Sort(arr2);
            for (int i = 0; i < arr.Length; i++)
            {
                b++;
                if (arr[i] == arr2[a - 1])
                {
                    c = arr[i];
                    d = b;
                }
                if (arr[i] == arr2[0])
                {
                    e = arr[i];
                    f = b;
                }
            }

            PrintArray(arr);
            Console.WriteLine();
            Console.WriteLine($"Cel mai mare nr este: {c} pe pozitia {d}");
            Console.WriteLine($"Cel mai mic nr este: {e} pe pozitia {f}");
        }
        private static void PrintArray(int[] arr)
        {
            Console.Write("Vectorul: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
    
}
