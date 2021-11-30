using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_Set_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //this will be empty for now...
        }
        public static void afisareProblemeSet2()
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

            Console.Write("\nType the number of the problem you want to see: ");
            int set2 = int.Parse(Console.ReadLine());
            switch (set2)
            {
                case 1:
                    set2p1();
                    break;
                case 2:
                    set2p2();
                    break;
                case 3:
                    set2p3();
                    break;
                case 4:
                    set2p4();
                    break;
                case 5:
                    set2p5();
                    break;
                case 6:
                    set2p6();
                    break;
                case 7:
                    set2p7();
                    break;
                case 8:
                    set2p8();
                    break;
                default:
                    break;

            }
        }
        static Random rnd = new Random();
        public static void set2p1()
        {
            Console.Write("Cate numere doriti sa aiba sirul? :");
            int n = int.Parse(Console.ReadLine());
            int p = 0;

            for (int i = 0; i < n; i++)
            {
                int r = rnd.Next(-100, 100);

                Console.Write(r+" ");
                if (r % 2 == 0)
                {
                    p++;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"nr pare sunt: {p}");
        }
        public static void set2p2()
        {
            int a = int.Parse(Console.ReadLine());
            int p = 0;
            int n = 0;
            int z = 0;

            for (int i = 0; i < a; i++)
            {
                int r = rnd.Next(-100, 100);

                Console.Write(r + " ");
                if (r > 0)
                {
                    p++;
                }
                if (r < 0)
                {
                    n++;
                }
                if (r == 0)
                {
                    z++;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"atatea nr  sunt : {p} (pozitive), {z} (zero), {n} (negative).");
        }
        public static void set2p3()
        {
            Console.WriteLine("Introduceti un nr:");
            int n = int.Parse(Console.ReadLine());
            int sumgaus = 0;
            for (int i = 1; i <= n; i++)
            {
                sumgaus = sumgaus + i;
            }
            Console.WriteLine($"Suma numereleor de la 1 pana la {n} este: {sumgaus}.");
        }
        public static void set2p4()
        {
            Console.Write("Cate numere doriti sa aiba sirul? :");
            int n = int.Parse(Console.ReadLine());
            Console.Write("numarul pe care il cautati: ");
            int a = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();
            sb.Capacity = n;
            int b = 0;
            bool ok = false;
            for (int i = 0; i < n; i++)
            {
                int r = rnd.Next(1, 10);
                //Console.Write(r + " ");
                sb.Append(r);
                b++;
                if (r == a)
                {

                    Console.WriteLine($"am gasit nr {a} pe pozitia {b}");
                    ok = true;
                }
                else
                {

                }
            }
            if (ok)
            {

            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("-1");
            }
            Console.WriteLine("Sirul de numere generat: ");
            for (int j = 0; j < sb.Length; j++)
            {
                Console.Write(sb[j] + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
        public static void set2p5()
        {
            Console.Write("Cate numere doriti sa aiba sirul? :");
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            sb.Capacity = n;
            int b = 0;
            int a = 0;
            for (int i = 0; i < n; i++)
            {
                int r = rnd.Next(1, 10);
                //Console.Write(r + " ");
                sb.Append(r);
                if (r == b)
                {
                    a++;
                }
                else
                {

                }
                b++;
            }
            for (int j = 0; j < sb.Length; j++)
            {
                Console.Write(sb[j] + " ");
            }
            Console.WriteLine();
            for (int k = 0; k < sb.Length; k++)
            {
                Console.Write(k + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Numere egale cu pozitia lor sunt: {a}");
        }
        public static void set2p6()
        {
           
        }
        public static void set2p7()
        {
            Console.Write("Cate numere doriti sa aiba sirul? :");
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            sb.Capacity = n;
            int m = 0;
            int mic = 0;
            int mic2 = -1;

            for (int i = 0; i < n; i++)
            {
                int r = rnd.Next(1, 10);
                //Console.Write(r + " ");
                sb.Append(r);
                if (r > m)
                {
                    m = r;
                }
                if (r == 0 || r == 1)
                {
                    mic2 = r;

                }
                else
                {

                }

                if (r < m)
                {
                    if (r < mic)
                    {
                        mic = r;
                    }
                    else
                    {

                    }

                }
                else
                {
                    mic = r;
                }

            }
            for (int j = 0; j < sb.Length; j++)
            {
                Console.Write(sb[j] + " ");
            }
            Console.WriteLine();
            if (mic2 == 0 || mic2 == 1)
            {
                mic = mic2;
            }
            Console.WriteLine($"cel mai mare numar: {m}, si cel mai mic nr: {mic}.");
        }
        public static void set2p8()
        {

        }

    }
}
