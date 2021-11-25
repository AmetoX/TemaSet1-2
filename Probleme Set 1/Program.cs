using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_Set_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            //this will be empty for now...
        }
        
        public static void afisareProblemeSet1()
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

            Console.Write("\nType the number of the problem you want to see: ");
            int set1 = int.Parse(Console.ReadLine());

            switch (set1)
            {
                case 1:
                    set1p1();
                    break;
                case 2:
                    set1p2();
                    break;
                case 3:
                    set1p3();
                    break;
                case 4:
                    set1p4();
                    break;
                case 5:
                    set1p5();
                    break;
                case 6:
                    set1p6();
                    break;
                case 7:
                    set1p7();
                    break;
                case 8:
                    set1p8();
                    break;
                case 9:
                    set1p9();
                    break;
                case 10:
                    set1p10();
                    break;
                case 11:
                    set1p11();
                    break;
                case 12:
                    set1p12();
                    break;
                case 13:
                    set1p13();
                    break;
                case 14:
                    set1p14();
                    break;
                case 15:
                    set1p15();
                    break;
                case 16:
                    set1p16();
                    break;
                case 17:
                    set1p17();
                    break;
                case 18:
                    set1p18();
                    break;
                case 19:
                    set1p19();
                    break;
                case 20:
                    set1p20();
                    break;
                case 21:
                    set1p21();
                    break;
                default:
                    break;
            }
        }
        public static void set1p1()
        {
            Console.WriteLine("Type 2 numbers: ");
            double a = int.Parse(Console.ReadLine());
            double b = int.Parse(Console.ReadLine());
            double sol = 0;
            double x = (sol - b) / a;
            Console.WriteLine($"Necunoscuta x din ax+b=0 este {x}");
            Console.ReadKey();
        }
        public static void set1p2()
        {

        }
        public static void set1p3()
        {
            Console.WriteLine("Type 2 numbers: ");
            double n = int.Parse(Console.ReadLine());
            double k = int.Parse(Console.ReadLine());
            if (n % k == 0)
            {
                Console.WriteLine($"numarul {n} este divizibil cu {k}.");
            }
            else
            {
                Console.WriteLine($"numarul {n} nu este divizibil cu {k}.");
            }
            Console.ReadKey();
        }
        public static void set1p4()
        {
            Console.WriteLine("Introduceti un an:");
            int a = int.Parse(Console.ReadLine());
            if (a % 4 == 0)
            {
                Console.WriteLine($"Anul {a} este un an bisect.");
            }
            else if (a % 100 == 0)
            {
                Console.WriteLine($"Anul {a} nu este un an bisect.");
            }
            else if (a % 400 == 0)
            {
                Console.WriteLine($"Anul {a} este un an bisect.");
            }
            else
            {
                Console.WriteLine($"Anul {a} nu este un an bisect.");
            }
            Console.ReadKey();
        }
        public static void set1p5()
        {
            Console.Write("Introduceti un nr: ");
            int a = int.Parse(Console.ReadLine());
            int ogl = 0;
            int b = a;
            while (a != 0)
            {
                ogl = ogl * 10 + a % 10;
                a = a / 10;
            }
            Console.WriteLine($"Cifra de la sfarsitul unui numar ({ogl}) (Cifrele se numara de la dreapta la stanga): {ogl % 10}");
            Console.ReadKey();
        }
        public static void set1p6()
        {
            Console.WriteLine("Introduceti 3 numere: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine($"{a}, {b}, {c}  pot fi lungimile laturilor unui triunghi");
            }
            else
            {
                Console.WriteLine($"{a}, {b}, {c} nu pot fi lungimile laturilor unui triunghi");
            }
            Console.ReadKey();

        }
        public static void set1p7()
        {
            Console.Write("Introduceti primul numar a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Introduceti al doilea numnar b = ");
            int b = int.Parse(Console.ReadLine());
            int aux = a;
            a = b;
            b = aux;
            Console.WriteLine($"Dupa inversare numar a = {a} ,  iar b = {b} .");
            Console.ReadKey();
        }
        public static void set1p8()
        {
            Console.Write("Iroduceti a =");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Iroduceti b =");
            int b = int.Parse(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"a={a} iar b = {b}");
            Console.ReadKey();
        }
        public static void set1p9()
        {
            Console.WriteLine("Scrieti un numar:");
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            while (i <= n)
            {
                if (n % i == 0)
                    Console.Write(i + " ");
                i++;
            }
            Console.ReadKey();
        }
        public static void set1p10()
        {
            int n;
            Console.WriteLine("Introduceti un numar: ");
            n = int.Parse(Console.ReadLine());

            if (prim(n))
            {
                Console.WriteLine($"Numarul {n} este prim");
            }
            else
            {
                Console.WriteLine($"Numarul {n} nu este prim");
            }
            Console.ReadKey();
        }
        public static bool prim(int n)
        {
            if (n < 2)
                return false;
            if (n == 2)
            {
                return true;
            }
            if (n % 2 == 0)
            {
                return false;
            }

            for (int a = 3; a <= n / 2; a = a + 2)
            {
                if (n % a == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static void set1p11()
        {
            Console.Write("Introduceti un numar: ");
            int n = int.Parse(Console.ReadLine());
            int ogl = 0;
            int a = n;
            while (n != 0)
            {
                ogl = ogl * 10 + n % 10;
                n = n / 10;
            }
            Console.WriteLine($"Numarul invers este: {ogl}");
            Console.ReadKey();
        }
        public static void set1p12()
        {
            Console.WriteLine("Introduceti doua numere sa fie interval(unul dupa altu cu spatiu intre ele):");
            string interval = Console.ReadLine();
            string[] local_data = interval.Split(' ');
            int a = int.Parse(local_data[0]);
            int b = int.Parse(local_data[1]);
            Console.Write("Introduceti un numar: ");
            int n = int.Parse(Console.ReadLine());
            int interval1 = b - a;
            int div = 0;
            for (int i = 1; i <= interval1; i++)
            {
                if (i % n == 0)
                {
                    div++;
                }

            }
            Console.WriteLine($"Numarul {n} are {div} divizori in intervalul [{a},{b}].");
            Console.ReadKey();
        }
        public static void set1p13()
        {
            Console.WriteLine("Introduceti doi ani ca sa aflati cati ani bisecti se aflta intr-e ei (unul dupa altu cu spatiu intre ele):");
            string interval = Console.ReadLine();
            string[] local_data = interval.Split(' ');
            int a = int.Parse(local_data[0]);
            int b = int.Parse(local_data[1]);
            int bis = 0;
            if (a < b)
            {
                while (a < b)
                {
                    if (a % 4 == 0)
                    {
                        bis++;
                    }
                    else if (a % 400 == 0)
                    {
                        bis++;
                    }
                    else
                    {

                    }
                    a++;
                }
            }
            else if (b > a)
            {
                while (b > a)
                {
                    if (b % 4 == 0)
                    {
                        bis++;
                    }
                    else if (b % 400 == 0)
                    {
                        bis++;
                    }
                    else
                    {

                    }
                    b++;
                }

            }
            Console.WriteLine($"Intr-e anii {a} - {b} sunt {bis} anii bisecti.");
            Console.ReadKey();
        }
        public static void set1p14()
        {
            Console.Write("Introduceti un numar: ");
            int n = int.Parse(Console.ReadLine());
            int ogl = 0;
            int a = n;
            while (n != 0)
            {
                ogl = ogl * 10 + n % 10;
                n = n / 10;
            }
            if (ogl == a)
            {
                Console.WriteLine("Numarul introdus este palidrom.");
            }
            else
            {
                Console.WriteLine("Numarul introdus nu este palidrom.");
            }
            Console.ReadKey();
        }
        public static void set1p15()
        {
            Console.WriteLine("Introduceti 3 numere (unul dupa altu cu spatiu intr-e ele):");
            string interval = Console.ReadLine();
            string[] local_data = interval.Split(' ');
            int a = int.Parse(local_data[0]);
            int b = int.Parse(local_data[1]);
            int c = int.Parse(local_data[2]);
            if (a > b)
            {
                int aux = a;
                a = b;
                b = aux;
            }

            if (a > c)
            {
                int aux = a;
                a = c;
                c = aux;
            }

            if (b > c)
            {
                int aux = b;
                b = c;
                c = aux;
            }

            Console.WriteLine($"Numerele introduse mai sus in ordine crescatoare: {a}, {b}, {c}.");
        }
        public static void set1p16()
        {
            Console.WriteLine("Introduceti 5 numere (unul dupa altu cu spatiu intr-e ele):");
            string interval = Console.ReadLine();
            string[] local_data = interval.Split(' ');
            int a = int.Parse(local_data[0]);
            int b = int.Parse(local_data[1]);
            int c = int.Parse(local_data[2]);
            int d = int.Parse(local_data[3]);
            int e = int.Parse(local_data[4]);

            if (a > b)
            {
                int aux = a;
                a = b;
                b = aux;
            }
            if (a > c)
            {
                int aux = a;
                a = c;
                c = aux;
            }
            if (a > d)
            {
                int aux = a;
                a = d;
                d = aux;
            }
            if (a > e)
            {
                int aux = a;
                a = e;
                e = aux;
            }
            if (b > c)
            {
                int aux = b;
                b = c;
                c = aux;
            }
            if (b > d)
            {
                int aux = b;
                b = d;
                d = aux;
            }
            if (b > e)
            {
                int aux = b;
                b = e;
                e = aux;
            }
            if (c > d)
            {
                int aux = c;
                c = d;
                d = aux;
            }
            if (c > e)
            {
                int aux = c;
                c = e;
                e = aux;
            }
            if (d > e)
            {
                int aux = d;
                d = e;
                e = aux;
            }
            Console.WriteLine($"Numerele introduse mai sus in ordine crescatoare: {a}, {b}, {c}, {d}, {e}.");
        }
        public static void set1p17()
        {
            Console.WriteLine("Introduceti 2 numere (unul dupa altu cu spatiu intr-e ele):");
            string interval = Console.ReadLine();
            string[] local_data = interval.Split(' ');
            int a = int.Parse(local_data[0]);
            int b = int.Parse(local_data[1]);
            int x = a;
            int y = b;
            while (x != y)
            {
                if (x > y)
                {
                    x = x - y;
                }
                else
                {
                    y = y - x;
                }
            }
            Console.WriteLine($"Cel mai mic multiplu comun:" + (a * b) / x);
            Console.WriteLine($"Cel mai mare divizor comun:{x}");
        }
        public static void set1p18()
        {
            Console.Write("Introduceti un nr: ");
            int n = int.Parse(Console.ReadLine());
            int div = 2;
            int pt;
            Console.WriteLine("Numarul introdus se descompune in nr. prime astfel:");
            while (n > 1)
            {
                if (n % div == 0)
                {
                    pt = 0;
                    while (n % div == 0)
                    {
                        pt++;
                        n /= div;
                    }
                    Console.WriteLine($"{div} la puterea {pt}");
                }
                div++;
            }

        }
        public static void set1p19()
        {
            Console.WriteLine(dubp19()
                ? "Numarul este format numai din 2 numere diferite."
                : "Numarul este format din mai mult de 2 numere diferite.");
            Console.ReadKey();
        }
        static bool dubp19()
        {
            int n = int.Parse(Console.ReadLine());
            int a = -1, b = -1;
            while (n != 0)
            {
                if (a == -1)
                {
                    a = n % 10;
                }
                else if (b == -1 && n % 10 != a)
                {
                    b = n % 10;
                }
                else if (n % 10 != a && n % 10 != b)
                {
                    return false;
                }

                n /= 10;
            }
            return a != -1 && b != -1;
        }
        public static void set1p20()
        {

        }
        public static void set1p21()
        {
            Random random = new Random();
            int randomnr = random.Next(1, 1024);
            Console.WriteLine("numarul este mai mare sau egal decat 512?");
            if (randomnr >= 512)
            {
                Console.WriteLine("numrul este mai mare decat 512 si mai mic sau egal decat 1024");
                if (randomnr >= 728)
                {
                    Console.WriteLine("numarul este mai mare sau egal decat 728 si mai mic sau egal decat 1024");
                    if (randomnr >= 876)
                    {
                        Console.WriteLine("numarul este mai mare sau egal decat 876 si mai mic sau egal decat 1024");
                        if (randomnr >= 950)
                        {
                            Console.WriteLine("numarul este mai mare sau egal decat 950 si mai mic sau egal decat 1024");
                            if (randomnr >= 987)
                            {
                                Console.WriteLine("numarul este mai mare sau egal decat 987 si mai mic sau egal decat 1024");

                                if (randomnr >= 1005)
                                {
                                    Console.WriteLine("mumarul este mai mare sau egal decat 1005 si mai mic sau egal decat 1024 ");
                                    if (randomnr >= 1015)
                                    {
                                        Console.WriteLine("numarul este mai mare sau egal decat 1015 si mai mic sau egal decat 1024");
                                    }
                                    else
                                    {
                                        Console.WriteLine("numarul este mai mic sau egal decat 1015 si mai mare sau egal decat 1005 ");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("numarul este mai mic sau egal decat 1005 si mai mare sau egal decat 987 ");
                                }
                            }
                            else
                            {
                                Console.WriteLine("numarul este mai mic sau egal decat 987 si mai mare sau egal decat 950");
                            }
                        }
                        else
                        {
                            Console.WriteLine("numarul este mai mic sau egal decat 950 si mai mare sau egal decat 876");
                        }
                    }
                    else
                    {
                        Console.WriteLine("numarul este mai mic sau egal decat 876 si mai mare sau egal decat 728");
                        if (randomnr >= 802)
                        {
                            Console.WriteLine("numarul este mai mai mare sau egal cu 802 si mai mic sau egal decat 876");
                            if (randomnr >= 839)
                            {
                                Console.WriteLine("numarul este mai mare sau egal decat 839 si mai mic sau egal decat 876");
                            }
                            else
                            {
                                Console.WriteLine("numarul este mai mic sau egal decat 839 si mai mare sau egal decat 802 ");
                                if (randomnr >= 820)
                                {
                                    Console.WriteLine("nuamrul este mai mare sau egal decat 820 si mai mic sau egal cu 839");
                                }
                                else
                                {
                                    Console.WriteLine("numarul este mai mic sau egal decat 820 si mai mare sau egal decat 802 ");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("numarul este mai mic sau egal cu 802 si mai mare sau egal cu 728");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("numarul este mai mic decat 728 dar mai mare decat 512");
                    if (randomnr >= 626)
                    {
                        Console.WriteLine("numarul este mai mic sau egal decat 626 si mai mare sau egal decat 512");
                        if (randomnr >= 569)
                        {
                            Console.WriteLine("numarul este mai mare sau egal cu 569 si mai mic sau egal decat 626");
                            if (randomnr >= 581)
                            {
                                Console.WriteLine("numarul este mai mare sau egal decat 581 si mai mic sau egal decat 626");
                                if (randomnr >= 601)
                                {
                                    Console.WriteLine("numarul este mai mare sau egal decat 601 si mai mic sau egal decat 626");
                                }
                                else
                                {
                                    Console.WriteLine("numarul este mai mic sau egal decat 601 si mai mare sau egal decat 581");
                                }
                            }
                            else
                            {
                                Console.WriteLine("numarul este mai mic sau egal decat 581 si mai mare sau egal decat 569");
                            }
                        }
                        else
                        {
                            Console.WriteLine("nuamrul este mai mic sau egalc u 569 si mai mare sau egal decat 512");
                            if (randomnr >= 540)
                            {
                                Console.WriteLine("nuamrul este mai mare sau egal decat 540 si mai mic sau egal decat 569");
                            }
                            else
                            {
                                Console.WriteLine("numarul este mai mic sau egal decat 540 si mai mare sau egal decat 512");
                                if (randomnr >= 528)
                                {
                                    Console.WriteLine("numarul este mai mare sau egal decat 528 si mai mic sau egal decat 540");
                                }
                                else
                                {
                                    Console.WriteLine("numarul este mai mic sau egal decat 528 si mai mare sau egal cu 512");
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("numarul este mai mare sau egal cu 626 si mai mic decat 728 ");
                        if (randomnr >= 700)
                        {
                            Console.WriteLine("numarul este mai mare decat 700 si mai mic decat 728");
                        }
                        else
                        {
                            Console.WriteLine("numarul este mai mic decat 700 si mai mare decat 626");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("numarul este mai mic sau egal decat 512");
                if (randomnr <= 260)
                {
                    Console.WriteLine("numarul este mai mic sau egal decat 260.");
                    if (randomnr <= 130)
                    {
                        Console.WriteLine("numarul este mai mic sau egal decat 130");
                        if (randomnr <= 65)
                        {
                            Console.WriteLine("numarul este mai mic sau egal cu 65");
                            if (randomnr <= 30)
                            {
                                Console.WriteLine("numarul este mai mic sau egal decat 30");
                                if (randomnr <= 15)
                                {
                                    Console.WriteLine("numarul este mai mic sau egal cu 15");
                                }
                                else
                                {
                                    Console.WriteLine("numarul este mai mare sau egal decat 15 si mai mic sau egal decat 30 ");
                                }
                            }
                            else
                            {
                                Console.WriteLine("numarul este mai mare sau egal decat 30 si mai mic decat 65 ");
                                if (randomnr <= 45)
                                {
                                    Console.WriteLine("numarul este mai mic sau egal decat 45 si mai mare sau egal decat 30");
                                }
                                else
                                {
                                    Console.WriteLine("numarul este mai mare sau egal cu 45 si mai mic sau egal decat 65");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("numarul este mai mare sau egal cu 65 si mai mic decat 130");
                            if (randomnr <= 95)
                            {
                                Console.WriteLine("numarul este mai mic sau egal cu 95 si mai mare sau egal cu 65");
                            }
                            else
                            {
                                Console.WriteLine("numarul este mai mare sau egal cu 95 si mai mic sau egal decat 130");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("numarul este mai mare sau egal decat 130 si mai mic sau egal decat 260");
                        if (randomnr <= 195)
                        {
                            Console.WriteLine("numarul este mai mic sau egal decat 195 si mai mare sau egal decat 130 ");
                            if (randomnr <= 160)
                            {
                                Console.WriteLine("numarul este mai mic sau egal decat 160 si mai mare sau egal decat 130");
                                if (randomnr <= 145)
                                {
                                    Console.WriteLine("numarul este mai mic sau egal decat 145 si mai mare sau egal decat 130 ");
                                }
                            }
                            else
                            {
                                Console.WriteLine("numarul este mai mare sau egal decat 160 si mai mic decat 195");
                                if (randomnr <= 175)
                                {
                                    Console.WriteLine("numarul este mai mic sau egal decat 175 si mai mare sau egal decat 160");
                                }
                                else
                                {
                                    Console.WriteLine("numarul este mai mare sau egal decat 175 si mai mic sau egal decat 195");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("numarul este mai mare sau egal decat 195 si mai mic sau egal decat 260");
                            if (randomnr <= 230)
                            {
                                Console.WriteLine("numarul este mai mic sau egal decat 230 si mai mare sau egal cu 195");
                                if (randomnr <= 210)
                                {
                                    Console.WriteLine("numarul este mai mic sau egal cu 210 si mai mare sau egal cu 195");
                                }
                                else
                                {
                                    Console.WriteLine("numarul este mai mare sau egal cu 210 si mai mic sau egal cu 230");
                                }
                            }
                            else
                            {
                                Console.WriteLine("numarul este mai mare sau egal cu 230 si mai mic sau egal cu 260");
                                if (randomnr <= 245)
                                {
                                    Console.WriteLine("numarul este mai mic sau egal decat 245 si mai mare sau egal cu 230");
                                }
                                else
                                {
                                    Console.WriteLine("numarul este mai mare sau egal cu 245 si mai mic sau egal cu 260");
                                }
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("numarul este mai mare sau egal decat 260 si mai mic sau egal decat 512");
                    if (randomnr <= 390)
                    {
                        Console.WriteLine("numarul este mai mare sau egal decat 260 si mai mic sau egal decat 390 ");
                    }
                    else
                    {
                        Console.WriteLine("numarul este mai mare sau egal decat 390 si mai mic 512");
                        if (randomnr <= 450)
                        {
                            Console.WriteLine("numarul este mai mic sau egal decat 450 si mai mare sau egal decat 390");
                            if (randomnr <= 420)
                            {
                                Console.WriteLine("numarul este mai mic sau egal decat 420 si mai mare sau egal cu 390");
                            }
                            else
                            {
                                Console.WriteLine("numarul este mai mare sau egal cu 420 si mai mic decat 450");
                                if (randomnr <= 435)
                                {
                                    Console.WriteLine("numarul este mai mic sau egal decat 435 si mai mare sau egal decat 420");
                                }
                                else
                                {
                                    Console.WriteLine("numarul este mai mare sau egal decat 435 si mai mic sau egal cu 450");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("numarul este mai mare sau egal decat 450 si mai mic decat 512");
                            if (randomnr <= 500)
                            {
                                Console.WriteLine("numarul este mai mic sau egal decat 500 si mai mare sau egal decat 450");
                                if (randomnr <= 475)
                                {
                                    Console.WriteLine("numarul este mai mic decat 475 si mai mare decat 450");
                                }
                                else
                                {
                                    Console.WriteLine("numarul este mai mare decat 475 si mai mic decat 500");
                                }
                            }
                            else
                            {
                                Console.WriteLine("numarul este mai mare sau egal decat 500 si mai mic decat 512 ");
                            }
                        }
                    }
                }
            }
            Console.WriteLine($"test {randomnr}");

        }
    }
}
