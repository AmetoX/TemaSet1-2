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
            Console.WriteLine("Facut(x) / Nefacut( )");
            Console.WriteLine("(x) Problema 1(Cate din ele sunt pare.)");
            Console.WriteLine("(x) Problema 2(Cate sunt negative, cate sunt zero si cate sunt pozitive.)");
            Console.WriteLine("(x) Problema 3(Suma si produsul numerelor de la 1 la n.)");
            Console.WriteLine("(x) Problema 4(Pe ce pozitie se afla in secventa un numara a.)");
            Console.WriteLine("(x) Problema 5(Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa.)");
            Console.WriteLine("(x) Problema 6(Sa se determine daca numerele din secventa sunt in ordine crescatoare.)");
            Console.WriteLine("(x) Problema 7(Sa se determine cea mai mare si cea mai mica valoare din secventa.)");
            Console.WriteLine("(x) Problema 8(Al n-lea numar din sirul lui Fibonacci.)");
            Console.WriteLine("(x) Problema 9(Daca o secventa de n numere este monotona.)");
            Console.WriteLine("(x) Problema 10(Care este numarul maxim de numere consecutive egale din secventa.)");
            Console.WriteLine("(x) Problema 11(Sa se caculeze suma inverselor acestor numere.)");
            Console.WriteLine("(x) Problema 12(Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere.)");
            Console.WriteLine("( ) Problema 13(Determinati daca o secventa de n numere este o secventa crescatoare rotita.)");
            Console.WriteLine("( ) Problema 14(Determinati daca o secventa de n numere este o secventa monotona rotita.)");
            Console.WriteLine("( ) Problema 15(Sa se determine daca este bitonica.)");
            Console.WriteLine("( ) Problema 16(Se da o secventa de n numere. Se cere sa se determine daca este o secventa bitonica rotita.)");
            Console.WriteLine("(x) Problema 17(Determinati daca secventa reprezinta o secventa de paranteze corecta.)");
            begin:
            Console.Write("\nType the number of the problem you want to see: ");
            int set2 = int.Parse(Console.ReadLine());
            try
            {
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
                    case 9:
                        set2p9();
                        break;
                    case 10:
                        set2p10();
                        break;
                    case 11:
                        set2p11();
                        break;
                    case 12:
                        set2p12();
                        break;
                    case 13:
                        set2p13();
                        break;
                    case 14:
                        set2p14();
                        break;
                    case 15:
                        set2p15();
                        break;
                    case 16:
                        set2p16();
                        break;
                    case 17:
                        set2p17();
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
        static Random rnd = new Random();
        public static void set2p1()
        {
            Console.Write("Cate numere doriti sa aiba sirul? : ");
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
            Console.Write("Introduceti un nr: ");
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
            Console.WriteLine("Introduceti un nr: ");
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
            Console.Write("Cate numere doriti sa aiba sirul? : ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Numarul pe care il cautati: ");
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
            
        }
        public static void set2p5()
        {
            Console.Write("Cate numere doriti sa aiba sirul? : ");
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
            Console.Write("Cate numere doriti sa aiba sirul? :");
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            sb.Capacity = n;
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;

            for (int i = 0; i < n; i++)
            {

                int r = rnd.Next(0, 100);

                sb.Append(r + " ");

                if (r > a)
                {
                    if (a > b)
                    {

                        if (b > d)
                        {

                            c++;
                        }

                        d = b;
                    }
                    b = a;

                }
                a = r;
            }
            if (c == (n - 1))
            {
                Console.WriteLine("Sirul este monoton crescator.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Sirul nu este crescator.");
                Console.WriteLine();
            }

            for (int j = 0; j < sb.Length; j++)
            {
                Console.Write(sb[j]);
            }
            Console.WriteLine();
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
            Console.WriteLine("Sirul lui Fibonacci");
            Console.Write("Introduceti un nr: ");
            int a = int.Parse(Console.ReadLine());
            int b, c, d, e, f;
            b = 1;
            c = 1;
            e = a;
            f = 1;
            if (a == 1)
            {
                Console.Write("1");
            }
            else
            {
                Console.Write("1" + " " + "1" + " ");
                a -= 2;
                while (a > 0)
                {
                    d = b + c;
                    b = c;
                    c = d;
                    Console.Write($"{d}" + " ");
                    a--;
                    f = d;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Al {e}-lea nr din sirul lui Fibonacci este: {f}.");
        }
        public static void set2p9()
        {
        again:
            Console.Clear();
            Console.WriteLine("Sir 1 (generare de sir cu calcule matematice).");
            Console.WriteLine("Sir 2 (generare de sir cu numere aleatorii).");
            Console.WriteLine("Sir 3 (monoton crescator 100%).");
            Console.WriteLine("Sir 4 (monoton descrescator 100%)");
            int sir = int.Parse(Console.ReadLine());
            switch (sir)
            {
                case 1:
                    sir1();
                    break;
                case 2:
                    sir2();
                    break;
                case 3:
                    sir3();
                    break;
                case 4:
                    sir4();
                    break;               
            }
            Console.WriteLine("Again? (y/n)");
            string yn = Convert.ToString(Console.ReadLine());
            string da = "y";
            string nu = "n";
            if (yn == da)
            {
                goto again;
            }
            else if (yn == nu)
            {

            }
            Console.WriteLine("Atat s-a putut.");
        }
        //apartin de problmea 9 (sir 1,2,3,4)
        public static void sir1()
        {
            Console.Write("Introduceti un nr: ");
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            sb.Capacity = n;
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            int e = 0;
            int f = 0;          
            int g = 0;
            int h = 0;
            int r = n;

            for (int i = 0; i <= n; i++)
            {
                while (n != 1)
                {

                    if (n % 2 == 0)
                    {
                        n = n / 2;
                    }
                    else
                    {
                        n = 3 * n + 1;
                    }
                    sb.Append(n + " ");

                    if (n > a)
                    {
                        if (a > b)
                        {
                            
                            if (b > d)
                            {
                                
                                c++;
                            }

                            d = b;
                        }
                        b = a;

                    }
                    a = n;

                    if (f > n)
                    {
                        if (e > f)
                        {
                            
                            if (h > e)
                            {
                                
                                g++;
                            }
                            h = e;
                        }
                        e = f;
                    }
                    f = n;

                    
                }
            }
            if (c == (r - 1))
            {
                Console.WriteLine("Sirul este monoton crescator.");
                Console.WriteLine();
            }
            else if (g == (r - 2))
            {
                Console.WriteLine("Sirul este monoton descrescator.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Sirul nu este monoton.");
                Console.WriteLine();
            }

            for (int j = 0; j < sb.Length; j++)
            {
                Console.Write(sb[j]);
            }
            Console.WriteLine();
            

        }
        public static void sir2()
        {
            Console.Write("Cate numere doriti sa aiba sirul? :");
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            sb.Capacity = n;
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            int e = 0;
            int f = 0;
            int g = 0;
            int h = 0;

            for (int i = 0; i < n; i++)
            {

                int r = rnd.Next(0, 100);
                
                sb.Append(r + " ");

                if (r > a)
                {
                    if (a > b)
                    {
                        
                        if (b > d)
                        {
                            
                            c++;
                        }

                        d = b;
                    }
                    b = a;

                }
                a = r;

                if (f > r)
                {
                    if (e > f)
                    {
                        
                        if (h > e)
                        {
                            
                            g++;
                        }
                        h = e;
                    }
                    e = f;
                }
                f = r;

            }
            if (c == (n - 1))
            {
                Console.WriteLine("Sirul este monoton crescator.");
                Console.WriteLine();
            }
            else if (g == (n - 2))
            {
                Console.WriteLine("Sirul este monoton descrescator.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Sirul nu este monoton.");
                Console.WriteLine();
            }

            for (int j = 0; j < sb.Length; j++)
            {
                Console.Write(sb[j]);
            }
            Console.WriteLine();
     


        }
        public static void sir3()
        {
            Console.Write("Cate numere doriti sa aiba sirul? :");
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            sb.Capacity = n;
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            int e = 0;
            int f = 0;
            int g = 0;
            int h = 0;
            int r = rnd.Next(1, 1000);
            int j = r;
            for(int i = 0; i < n; i++)
            {
            
                j+=2;
                sb.Append(j + " ");

                if (j > a)
                {
                    if (a > b)
                    {
                        
                        if (b > d)
                        {
                            
                            c++;
                        }

                        d = b;
                    }
                    b = a;

                }
                a = j;

                if (f > j)
                {
                    if (e > f)
                    {
                        
                        if (h > e)
                        {
                            
                            g++;
                        }
                        h = e;
                    }
                    e = f;
                }
                f = j;

            }
            if (c == (n - 1))
            {
                Console.WriteLine("Sirul este monoton crescator.");
                Console.WriteLine();
            }
            else if (g == (n - 2))
            {
                Console.WriteLine("Sirul este monoton descrescator.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Sirul nu este monoton.");
                Console.WriteLine();
            }

            for (int k = 0; k < sb.Length; k++)
            {
                Console.Write(sb[k]);
            }
            Console.WriteLine();
        }
        public static void sir4()
        {
            Console.Write("Cate numere doriti sa aiba sirul? :");
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            sb.Capacity = n;
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            int e = 0;
            int f = 0;
            int g = 0;
            int h = 0;

            int j;
            int k = rnd.Next(1, 1000);
            for (int i = 0; i < n; i++)
            {

                k--;
                j = k--;
                sb.Append(j + " ");

                if (j > a)
                {
                    if (a > b)
                    {
                        
                        if (b > d)
                        {
                            
                            c++;
                        }

                        d = b;
                    }
                    b = a;

                }
                a = j;

                if (f > j)
                {
                    if (e > f)
                    {
                        
                        if (h > e)
                        {
                            
                            g++;
                        }
                        h = e;
                    }
                    e = f;
                }
                f = j;



            }
            if (c == (n - 1))
            {
                Console.WriteLine("Sirul este monoton crescator.");
                Console.WriteLine();
            }
            else if (g == (n - 2))
            {
                Console.WriteLine("Sirul este monoton descrescator.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Sirul nu este monoton.");
                Console.WriteLine();
            }

            for (int l = 0; l < sb.Length; l++)
            {
                Console.Write(sb[l]);
            }
            Console.WriteLine();       
        }
        public static void set2p10()
        {
            Console.Write("Introduceti un nr. : ");
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            sb.Capacity = n;
            int a = 0;
            int b = 0;
            for (int i = 1; i <= n; i++)
            {
                int r = rnd.Next(0, n);

                if (r == a)
                {
                    b++;
                }
                a = r;

                sb.Append(r + " ");
            }
            Console.WriteLine();

            for (int j = 0; j < sb.Length; j++)
            {
                Console.Write(sb[j]);
            }
            Console.WriteLine();
            Console.WriteLine($"Numarul maxim de numere egale in secventa de mai sus este: {b}");
        }
        public static void set2p11()
        {
            Console.Write("Introduceti un nr. : ");
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            sb.Capacity = n;
            int suma = 0;

            for (int i = 1; i <= n; i++)
            {
                int r = rnd.Next(0, 100);
                Console.Write(r + " ");
                int ogl = 0;
                while (r != 0)
                {
                    ogl = ogl * 10 + r % 10;
                    r = r / 10;
                }
                suma = suma + ogl;

                sb.Append(ogl + " ");

            }
            Console.WriteLine();


            for (int j = 0; j < sb.Length; j++)
            {
                Console.Write(sb[j]);
            }
            Console.WriteLine();
            Console.WriteLine($"Suma inverselor numerelor din sir este: {suma}");
        }
        public static void set2p12()
        {
            Console.Write("Introduceti un nr. : ");
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            sb.Capacity = n;
            int a = 0;

            for (int i = 1; i <= n; i++)
            {
                int r = rnd.Next(0, 10);
                if (r != 0)
                {
                    a++;
                }

                sb.Append(r + " ");

            }
            Console.WriteLine();


            for (int j = 0; j < sb.Length; j++)
            {
                Console.Write(sb[j]);
            }
            Console.WriteLine();
            Console.WriteLine($"Sunt: {a} grupuri consecutive de numere diferite de 0.");
        }
        public static void set2p13()
        {
            Console.WriteLine("Nu am stiut sa o rezolv.");
        }
        public static void set2p14()
        {
            Console.WriteLine("Nu am stiut sa o rezolv.");
        }
        public static void set2p15()
        {
            Console.WriteLine("Nu am stiut sa o rezolv.");
        }
        public static void set2p16()
        {
            Console.WriteLine("Nu am stiut sa o rezolv.");
        }
        public static void set2p17()
        {
            Console.Write("Introduceti un nr. : ");
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            sb.Capacity = n;
            int b = 0;
            int a = -1;
            int zero = 0;
            int unu = 0;
            bool ok = true; ;
            for (int i = 1; i <= n; i++)
            {
                //()(()())
                //01001011
                //(((())))()((()))
                int r = rnd.Next(0, 2);
                if (r == 0)
                {
                    Console.Write("(" + " ");
                }
                else if (r == 1)
                {
                    Console.Write(")" + " ");
                }
                if (r == 1 && a == 0)
                {
                    b++;
                }
                a = r;


                ok = true;
                if (r == 0)
                {
                    ok = false;
                    zero++;
                }
                else
                {
                    unu++;
                }

                sb.Append(r + " ");
            }
            Console.WriteLine();


            for (int j = 0; j < sb.Length; j++)
            {
                Console.Write(sb[j]);
            }
            Console.WriteLine();
            Console.WriteLine("Paranteze perfecte: " + b);
            if (sb[0] == 1 || ok)
            {
                Console.WriteLine("nu");
            }

            if (zero == unu)

            {
                Console.WriteLine("merge");
            }

        }
    }
}
