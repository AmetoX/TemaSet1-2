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

    }
}
