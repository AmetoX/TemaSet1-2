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
            again:
            Console.WriteLine("Metoda 1: afisare codul hex la fiecare linie in parte.");
            Console.WriteLine("Metoda 2: afisare codul hex separat de continutul fisierului.");
            Console.Write("Introduceti nr metodei: ");
            int a = int.Parse(Console.ReadLine());
            if (a == 1)
            {
                Console.Clear();
                lista();
                metoda1();
            }
            else if (a == 2)
            {
                Console.Clear();
                lista();
                metoda2();
            }
            else
            {
                Environment.Exit(1);
            }
            Console.WriteLine("Vreti sa incercati din nou?(y/n)");
            string again = Console.ReadLine();
            string da = "y";
            string nu = "n";
            if (again == da)
            {
                goto again;
            }else if (again == nu)
            {
                Environment.Exit(1);
            }
        }
        private static void metoda1()
        {
            
            Console.Write("Scrieti numele unui fisier: ");
            string name = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            
            //afisarea continutului fisierului
            TextReader load = new StreamReader($@"..\..\Properties\{name}.txt");
            string buffer;
            Console.WriteLine("Continutul fisierului: ");
            while ((buffer = load.ReadLine()) != null)
            {
                //convertirea valorilor stringurilor  in hex
                var bytes = Encoding.Unicode.GetBytes(buffer); ;
                foreach (var t in bytes)
                {
                    sb.Append(t.ToString("X2"));

                }
                Console.Write(sb);
                Console.WriteLine("\t" + buffer);
            }
            Console.WriteLine();
        }

        private static void metoda2()
        {
            
            Console.Write("Scrieti numele unui fisier: ");
            string name = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            //afisarea continutului fisierului
            TextReader load = new StreamReader($@"..\..\Properties\{name}.txt");
            string buffer;
            Console.WriteLine("Continutul fisierului: ");
            while ((buffer = load.ReadLine()) != null)
            {
                //convertirea valorilor stringurilor  in hex
                Console.WriteLine(buffer);
                var bytes = Encoding.Unicode.GetBytes(buffer); ;
                foreach (var t in bytes)
                {
                    sb.Append(t.ToString("X2"));

                }

            }
            Console.WriteLine();
            Console.WriteLine("Convertirea in hex: ");
            for (int i = 0; i < sb.Length; i++)
            {
                Console.Write(sb[i]);
            }
            Console.WriteLine();
        }


        private static void lista()
        {
            Console.WriteLine("-Fisiere-");
            Console.WriteLine("Fisiere disponibile: ");
            Console.WriteLine("1.test");
            Console.WriteLine("2.");
            Console.WriteLine("3.");
            Console.WriteLine("4.");
        }
    }
}