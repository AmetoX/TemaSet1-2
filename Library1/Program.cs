using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;


namespace Library1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char a = '|';
            char b = '*';
            char c = ' ';
            char d = '#';
            for (int i = 0; i <= n; i++)
            {
                Console.Write(a);
                for (int j = 0; j <= 4; j++)
                {
                    Console.Write(b);
                }
                Console.Write(a);
                for (int j = 0; j <= 4; j++)
                {
                    Console.Write(b);
                }
                Console.Write(a);
                Console.WriteLine();
            }



            //this will be empty for now...
        }
        /// <summary>
        /// arata timpul cand se porneste programul
        /// </summary>
        public static void time()
        {
            DateTime dt = DateTime.Now;
            CultureInfo culture = new CultureInfo("en-US");
            Console.WriteLine(dt.ToString(culture));
        }       
        /// <summary>
        /// -aceste 3 functii cand vor fi apeta vor arata o serie de variante 
        /// -odata ce utilizatorul alege una dintr-e acele variante programul va arata in consola exact continutul din fiesrul text
        /// care ii corespende
        /// (are rolul de gasi codul unei probleme fara a cauta prin tot codul programului)
        /// </summary>
        public static void codprobleme1()
        {
            Console.WriteLine("Problema 1(necunoscuta: ax+b = 0)");
            Console.WriteLine("Problema 2(necunoscuta: ax^2 + bx + c = 0)");
            Console.WriteLine("Problema 3(n se divide cu k)");
            Console.WriteLine("Problema 4(un an y este an bisect)");
            Console.WriteLine("Problema 5(afisati a k-a cifra de la sfarsitul unui numar)");
            Console.WriteLine("Problema 6(trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi)");
            Console.WriteLine("Problema 7(sa se inverseze valorile lor)");
            Console.WriteLine("Problema 8(sa se inverseze valorile lor fara a folosi alte variabile suplimentare)");
            Console.WriteLine("Problema 9(toti divizorii numarului n)");
            Console.WriteLine("Problema 10(daca un numar n este prim)");
            Console.WriteLine("Problema 11(Afisati in ordine inversa cifrele unui numar n)");
            Console.WriteLine("Problema 12(cate numere integi divizibile cu n se afla in intervalul [a, b])");
            Console.WriteLine("Problema 13(cati ani bisecti sunt intre anii y1 si y2)");
            Console.WriteLine("Problema 14(daca un numar n este palindrom)");
            Console.WriteLine("Problema 15(3 numere. Sa se afiseze in ordine crescatoare)");
            Console.WriteLine("Problema 16(5 numere. Sa se afiseze in ordine crescatoare)");
            Console.WriteLine("Problema 17(cel mai mare divizor comun si cel mai mic multiplu comun a doua numere)");
            Console.WriteLine("Problema 18(descompunerea in factori primi ai unui numar n)");
            Console.WriteLine("Problema 19(daca un numar e format doar cu 2 cifre care se pot repeta)");
            Console.WriteLine("Problema 20(Afisati fractia m/n in format zecimal, cu perioada intre paranteze)");
            Console.WriteLine("Problema 21(Ghiciti un numar intre 1 si 1024)");

            repeat:
            Console.Write("\nType the number of the problem you want to see: ");
            int set1 = int.Parse(Console.ReadLine());
            
            switch (set1)
            {
                case 1:
                    TextReader load = new StreamReader(@"..\..\CodeLineProbleme1\Set1p1.txt");
                    string buffer;
                    while ((buffer = load.ReadLine()) != null)
                    {
                        Console.WriteLine(buffer);
                    }
                    break;
                case 2:
                    TextReader load2 = new StreamReader(@"..\..\CodeLineProbleme1\Set1p2.txt");
                    string buffer2;
                    while ((buffer2 = load2.ReadLine()) != null)
                    {
                        Console.WriteLine(buffer2);
                    }
                    break;
                case 3:
                    TextReader load3 = new StreamReader(@"..\..\CodeLineProbleme1\Set1p3.txt");
                    string buffer3;
                    while ((buffer3 = load3.ReadLine()) != null)
                    {
                        Console.WriteLine(buffer3);
                    }
                    break;
                case 4:
                    TextReader load4 = new StreamReader(@"..\..\CodeLineProbleme1\Set1p4.txt");
                    string buffer4;
                    while ((buffer4 = load4.ReadLine()) != null)
                    {
                        Console.WriteLine(buffer4);
                    }
                    break;
                case 5:
                    TextReader load5 = new StreamReader(@"..\..\CodeLineProbleme1\Set1p5.txt");
                    string buffer5;
                    while ((buffer5 = load5.ReadLine()) != null)
                    {
                        Console.WriteLine(buffer5);
                    }
                    break;
                case 6:
                    TextReader load6 = new StreamReader(@"..\..\CodeLineProbleme1\Set1p6.txt");
                    string buffer6;
                    while ((buffer6 = load6.ReadLine()) != null)
                    {
                        Console.WriteLine(buffer6);
                    }
                    break;
                case 7:
                    TextReader load7 = new StreamReader(@"..\..\CodeLineProbleme1\Set1p7.txt");
                    string buffer7;
                    while ((buffer7 = load7.ReadLine()) != null)
                    {
                        Console.WriteLine(buffer7);
                    }
                    break;
                case 8:
                    TextReader load8 = new StreamReader(@"..\..\CodeLineProbleme1\Set1p8.txt");
                    string buffer8;
                    while ((buffer8 = load8.ReadLine()) != null)
                    {
                        Console.WriteLine(buffer8);
                    }
                    break;
                case 9:
                    TextReader load9 = new StreamReader(@"..\..\CodeLineProbleme1\Set1p3.txt");
                    string buffer9;
                    while ((buffer9 = load9.ReadLine()) != null)
                    {
                        Console.WriteLine(buffer9);
                    }
                    break;
                case 10:
                    TextReader load10 = new StreamReader(@"..\..\CodeLineProbleme1\Set1p3.txt");
                    string buffer10;
                    while ((buffer10 = load10.ReadLine()) != null)
                    {
                        Console.WriteLine(buffer10);
                    }
                    break;
                case 11:
                    TextReader load11 = new StreamReader(@"..\..\CodeLineProbleme1\Set1p11.txt");
                    string buffer11;
                    while ((buffer11 = load11.ReadLine()) != null)
                    {
                        Console.WriteLine(buffer11);
                    }
                    break;
                case 12:
                    TextReader load12 = new StreamReader(@"..\..\CodeLineProbleme1\Set1p12.txt");
                    string buffer12;
                    while ((buffer12 = load12.ReadLine()) != null)
                    {
                        Console.WriteLine(buffer12);
                    }
                    break;
                case 13:
                    TextReader load13 = new StreamReader(@"..\..\CodeLineProbleme1\Set1p13.txt");
                    string buffer13;
                    while ((buffer13 = load13.ReadLine()) != null)
                    {
                        Console.WriteLine(buffer13);
                    }
                    break;
                case 14:
                    TextReader load14 = new StreamReader(@"..\..\CodeLineProbleme1\Set1p14.txt");
                    string buffer14;
                    while ((buffer14 = load14.ReadLine()) != null)
                    {
                        Console.WriteLine(buffer14);
                    }
                    break;
                case 15:
                    TextReader load15 = new StreamReader(@"..\..\CodeLineProbleme1\Set1p15.txt");
                    string buffer15;
                    while ((buffer15 = load15.ReadLine()) != null)
                    {
                        Console.WriteLine(buffer15);
                    }
                    break;
                case 16:
                    TextReader load16 = new StreamReader(@"..\..\CodeLineProbleme1\Set1p16.txt");
                    string buffer16;
                    while ((buffer16 = load16.ReadLine()) != null)
                    {
                        Console.WriteLine(buffer16);
                    }
                    break;
                case 17:
                    TextReader load17 = new StreamReader(@"..\..\CodeLineProbleme1\Set1p17.txt");
                    string buffer17;
                    while ((buffer17 = load17.ReadLine()) != null)
                    {
                        Console.WriteLine(buffer17);
                    }
                    break;
                case 18:
                    TextReader load18 = new StreamReader(@"..\..\CodeLineProbleme1\Set1p18.txt");
                    string buffer18;
                    while ((buffer18 = load18.ReadLine()) != null)
                    {
                        Console.WriteLine(buffer18);
                    }
                    break;
                case 19:
                    TextReader load19 = new StreamReader(@"..\..\CodeLineProbleme1\Set1p19.txt");
                    string buffer19;
                    while ((buffer19 = load19.ReadLine()) != null)
                    {
                        Console.WriteLine(buffer19);
                    }
                    break;
                case 20:
                    TextReader load20 = new StreamReader(@"..\..\CodeLineProbleme1\Set1p20.txt");
                    string buffer20;
                    while ((buffer20 = load20.ReadLine()) != null)
                    {
                        Console.WriteLine(buffer20);
                    }
                    break;
                case 21:
                    TextReader load21 = new StreamReader(@"..\..\CodeLineProbleme1\Set1p21.txt");
                    string buffer21;
                    while ((buffer21 = load21.ReadLine()) != null)
                    {
                        Console.WriteLine(buffer21);
                    }
                    break;
                default:
                    goto repeat;
                    
            }
            Console.ReadKey();
        }
        public static void codprobleme2()
        {
            Console.WriteLine("Problema 1()");
            Console.WriteLine("Problema 2()");
            Console.WriteLine("Problema 3()");
            Console.WriteLine("Problema 4()");
            Console.WriteLine("Problema 5()");
            Console.WriteLine("Problema 6()");
            Console.WriteLine("Problema 7()");
            Console.WriteLine("Problema 8()");
            Console.WriteLine("Problema 9()");
            Console.WriteLine("Problema 10()");
            Console.WriteLine("Problema 11()");
            Console.WriteLine("Problema 12()");
            Console.WriteLine("Problema 13()");
            Console.WriteLine("Problema 14()");
            Console.WriteLine("Problema 15()");
            Console.WriteLine("Problema 16()");
            Console.WriteLine("Problema 17()");
            Console.WriteLine("Problema 18()");
            Console.WriteLine("Problema 19()");
            Console.WriteLine("Problema 20()");
            Console.WriteLine("Problema 21()");

            Console.Write("\nType the number of the problem you want to see: ");
            int set2 = int.Parse(Console.ReadLine());
            switch (set2)
            {
                case 1:
                    TextReader s2load1 = new StreamReader(@"..\..\CodeLineProbleme2\Set2p1.txt");
                    string s2buffer1;
                    while ((s2buffer1 = s2load1.ReadLine()) != null)
                    {
                        Console.WriteLine(s2buffer1);
                    }
                    break;
                case 2:
                    TextReader s2load2 = new StreamReader(@"..\..\CodeLineProbleme2\Set2p2.txt");
                    string s2buffer2;
                    while ((s2buffer2 = s2load2.ReadLine()) != null)
                    {
                        Console.WriteLine(s2buffer2);
                    }
                    break;
                default:
                    break;
            }

        }
        public static void codprobleme3()
        {
            Console.WriteLine("Problema 1()");
            Console.WriteLine("Problema 2()");
            Console.WriteLine("Problema 3()");
            Console.WriteLine("Problema 4()");
            Console.WriteLine("Problema 5()");
            Console.WriteLine("Problema 6()");
            Console.WriteLine("Problema 7()");
            Console.WriteLine("Problema 8()");
            Console.WriteLine("Problema 9()");
            Console.WriteLine("Problema 10()");
            Console.WriteLine("Problema 11()");
            Console.WriteLine("Problema 12()");
            Console.WriteLine("Problema 13()");
            Console.WriteLine("Problema 14()");
            Console.WriteLine("Problema 15()");
            Console.WriteLine("Problema 16()");
            Console.WriteLine("Problema 17()");
            Console.WriteLine("Problema 18()");
            Console.WriteLine("Problema 19()");
            Console.WriteLine("Problema 20()");
            Console.WriteLine("Problema 21()");

            Console.Write("\nType the number of the problem you want to see: ");
            int set3 = int.Parse(Console.ReadLine());
            switch (set3)
            {
                case 1:
                    break;
                default:
                    break;
            }

        }
    }
}

