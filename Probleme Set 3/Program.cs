using System;
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
                        set3p4();
                        break;
                    case 5:
                        set3p5();
                        break;
                    case 6:
                        set3p6();
                        break;
                    case 7:
                        set3p7();
                        break;
                    case 8:
                        set3p8();
                        break;
                    case 9:
                        set3p9();
                        break;
                    case 10:
                        set3p10();
                        break;
                    case 11:
                        set3p11();
                        break;
                    case 12:
                        
                        break;
                    case 13:
                        
                        break;
                    case 14:
                        
                        break;
                    case 15:
                        set3p15();
                        break;
                    case 16:
                        
                        break;
                    case 17:
                        
                        break;
                    case 18:
                        
                        break;
                    case 19:
                        
                        break;
                    case 20:
                        
                        break;
                    case 21:
                        
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
                
                if (arr[i] == arr2[a - 1])
                {
                    c = arr[i];
                    d = i;
                }
                if (arr[i] == arr2[0])
                {
                    e = arr[i];
                    f = i;
                }
            }

            PrintArray(arr);
            Console.WriteLine();
            Console.WriteLine($"Cel mai mare nr este: {c} pe pozitia {d}");
            Console.WriteLine($"Cel mai mic nr este: {e} pe pozitia {f}");
        }
        public static void set3p4()
        {
            Console.Write("Cate numere doriti sa contina vectorul?(-100,100) : ");
            int a = int.Parse(Console.ReadLine());
            int b = 0;
            int c = 0;
            int[] arr;
            arr = new int[a];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-100, 100);
            }
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == arr[0])
                {
                    b++;
                }
                if (arr[i] == arr[a - 1])
                {
                    c++;
                }
            }
            PrintArray(arr);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Cel mai mare nr este: {arr[a - 1]} ,iar acesta apare de {c}-ori.");
            Console.WriteLine($"Cel mai mic nr este: {arr[0]} ,iar acesta apare de {b}-ori.");
        }
        public static void set3p5()
        {
            Console.Write("Cate numere doriti sa contina vectorul?(-100,100) : ");
            int a = int.Parse(Console.ReadLine());
            int[] arr;
            arr = new int[a];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-100, 100);
            }
            PrintArray(arr);
            Console.WriteLine();
            Console.Write("Ce numar doriti sa introduceti?: ");
            int e = int.Parse(Console.ReadLine());
            Console.Write("Pe ce pozitie dorit sa fie acesta?: ");
            int k = int.Parse(Console.ReadLine());
            int[] newarr = new int[a + 1];
            for (int i = 0; i < a + 1; i++)
            {
                if (i < k - 1)
                {
                    newarr[i] = arr[i];
                }
                else if (i == k - 1)
                {
                    newarr[i] = e;
                }
                else
                {
                    newarr[i] = arr[i - 1];
                }
            }
            Console.WriteLine();
            Console.WriteLine("Noul vector: ");
            PrintArray(newarr);
        }
        public static void set3p6()
        {
            Console.Write("Cate numere doriti sa contina vectorul?(-100,100) : ");
            int a = int.Parse(Console.ReadLine());
            int[] arr;
            arr = new int[a];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-100, 100);
            }
            PrintArray(arr);
            Console.WriteLine();
            Console.Write("Ce numar de pe ce pozitie dori sa stergeti(pozitia elementelor incepe de la 0)?: ");
            int e = int.Parse(Console.ReadLine());
            arr = arr.Where((source, index) => index != e).ToArray();
            PrintArray(arr);
        }
        public static void set3p7()
        {
            Console.Write("Cate numere doriti sa contina vectorul?(-100,100) : ");
            int a = int.Parse(Console.ReadLine());
            int[] arr;
            arr = new int[a];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-100, 100);
            }
            PrintArray(arr);
            Console.WriteLine();
            int[] rev = new int[a];
            int b = a - 1;
            for (int i = 0; i < arr.Length; i++)
            {

                rev[i] = arr[b];
                b--;
            }
            Console.Write("Vectorul inversat: ");
            for (int i = 0; i < rev.Length; i++)
            {
                Console.Write(rev[i] + " ");
            }
        }
        public static void set3p8()
        {
            Console.Write("Cate numere doriti sa contina vectorul?(-100,100): ");
            int a = int.Parse(Console.ReadLine());
            int[] arr;
            arr = new int[a];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-100, 100);
            }
            PrintArray(arr);
            Console.WriteLine();
            int c = arr[0];
            for (int i = 0; i < arr.Length - 1; i++)
            {

                arr[i] = arr[i + 1];

            }
            arr[a - 1] = c;
            Console.WriteLine("Vector rotit spre stanga cu o pozitie.");
            PrintArray(arr);

        }
        public static void set3p9()
        {

        }
        public static void set3p10()
        {
                        Console.Write("Cate numere doriti sa contina vectorul?(-100,100) : ");            
            int a = int.Parse(Console.ReadLine());
            int[] arr;
            arr = new int[a];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-100, 100);                
            }
            Array.Sort(arr);
            Console.Write("Ce numar doriti sa cautati?: ");
            int key = int.Parse(Console.ReadLine());
            bool ok = false;
            int nf = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == key)
                {
                    ok = true;
                    nf = i;
                }
            }
            if (ok)
            {
                Console.WriteLine($"Am gasit nr. cautat({key}), pe pozitia: {nf}");
            }
            else
            {
                Console.WriteLine($"Numarul nu a fost gasit {nf}");
            }
            PrintArray(arr);
            Console.WriteLine();
        }
        public static void set3p11()
        {
            Console.Write("Cate numere doriti sa contina vectorul?(0,100) : ");
            int a = int.Parse(Console.ReadLine());
            int[] arr;
            arr = new int[a];
            int b = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = b++;
            }
            PrintArray(arr);
            Console.WriteLine();
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
        public static void set3p15()
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
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i - 1])
                {
                    arr = arr.Where((source, index) => index != i).ToArray();
                }
            }
            Console.WriteLine("Vectorul fara numere care se repeta:");
            PrintArray(arr);
        }
        public static void set3p17()
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
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
    
}
