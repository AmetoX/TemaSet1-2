using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library1;


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
            Console.WriteLine("Problema 1(Calculati suma elementelor unui vector de n numere citite de la tastatura.)");
            Console.WriteLine("Problema 2(Sa se determine prima pozitie din vector pe care apare k. )");
            Console.WriteLine("Problema 3(Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element.)");
            Console.WriteLine("Problema 4(Cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea.)");
            Console.WriteLine("Problema 5(Se cere sa se insereze valoarea e in vector pe pozitia k.)");
            Console.WriteLine("Problema 6(Se cere sa se stearga din vector elementul de pe pozitia k.)");
            Console.WriteLine("Problema 7(Se cere sa se inverseze ordinea elementelor din vector.)");
            Console.WriteLine("Problema 8(Rotiti elementele vectorului cu o pozitie spre stanga.)");
            Console.WriteLine("Problema 9(Rotiti elementele vectorului cu k pozitii spre stanga.)");
            Console.WriteLine("Problema 10(Se cere sa se determine pozitia unui element dat k.)");
            Console.WriteLine("Problema 11(Se cere sa se afiseze toate numerele prime mai mici sau egale cu n (ciurul lui Eratostene)");
            Console.WriteLine("Problema 12(Implementati algoritmul de sortare <Selection Sort>.)");
            Console.WriteLine("Problema 13(Implementati algoritmul de sortare <Insertion Sort>.)");
            Console.WriteLine("Problema 14(Toate valorile egale cu zero sa ajunga la sfarsit.)");
            Console.WriteLine("Problema 15(Modificati un vector prin eliminarea elementelor care se repeta, fara a folosi un alt vector.)");
            Console.WriteLine("Problema 16(Determinati cel mai mare divizor comun al elementelor vectorului.)");
            Console.WriteLine("Problema 17(Sa se converteasca si sa se afiseze numarul n in baza b.)");
            Console.WriteLine("Problema 18(Se cere valoarea polinomului intr-un punct x.)");
            Console.WriteLine("Problema 19(Determinati de cate ori apare p in s.)");
            Console.WriteLine("Problema 20(Determinati numarul de suprapuneri.)");
            Console.WriteLine("Problema 21(Se cere sa se determine ordinea lor lexicografica.)");
            Console.WriteLine("Problema 22(Se cere sa determine intersectia, reuniunea, si diferentele v1-v2 si v2 -v1.)");
            Console.WriteLine("Problema 23(Elementele din v1 respectiv v2  sunt in ordine strict crescatoare.)");
            Console.WriteLine("Problema 24(Elementele sunt stocate ca vectori cu valori binare)");
            Console.WriteLine("Problema 25(Construiti un al treilea vector ordonat crescator format din toate elementele din  v1 si v2.)");
            Console.WriteLine("Problema 26(Se cere sa se determine suma, diferenta si produsul a doua astfel de numere.)");
            Console.WriteLine("Problema 27(Sa se determine valoarea din vector care va fi pe pozitia index dupa ce vectorul este sortat.)");
            Console.WriteLine("Problema 28(Sortati un vector folosind metoda QuickSort.)");
            Console.WriteLine("Problema 29(Sortati un vector folosind metoda MergeSort.)");
            Console.WriteLine("Problema 30(Sortati vectorii astfel incat elementele lui E sa fie in in ordine crescatoare.)");
            Console.WriteLine("Problema 31(Sa se determine elementul majoritate al unui vector).");
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
                        set3p12();
                        break;
                    case 13:
                        set3p13();
                        break;
                    case 14:
                        set3p14();
                        break;
                    case 15:
                        set3p15();
                        break;
                    case 16:
                        set3p16();
                        break;
                    case 17:
                        set3p17();
                        break;
                    case 18:
                        set3p18();
                        break;
                    case 19:
                        set3p19();
                        break;
                    case 20:
                        set3p20();
                        break;
                    case 21:
                        set3p21();
                        break;
                    case 22:
                        set3p22();
                        break;
                    case 23:
                        set3p23();
                        break;
                    case 24:
                        set3p24();
                        break;
                    case 25:
                        set3p25();
                        break;
                    case 26:
                        set3p26();
                        break;
                    case 27:
                        set3p27();
                        break;
                    case 28:
                        set3p28();
                        break;
                    case 29:
                        set3p29();
                        break;
                    case 30:
                        set3p30();
                        break;
                    case 31:
                        set3p31();
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
            GenerateArray(arr);
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
            GenerateArray(arr);
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
            GenerateArray(arr);
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
            GenerateArray(arr);
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
            GenerateArray(arr);
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
            GenerateArray(arr);
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
            GenerateArray(arr);
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
            //
        }
        public static void set3p10()
        {
                        Console.Write("Cate numere doriti sa contina vectorul?(-100,100) : ");            
            int a = int.Parse(Console.ReadLine());
            int[] arr;
            arr = new int[a];
            GenerateArray(arr);
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
        public static void set3p12()
        {
            Console.Write("Cate numere doriti sa contina vectorul?: ");
            int a = int.Parse(Console.ReadLine()); ;
            int[] arr;
            arr = new int[a];
            GenerateArray(arr);
            PrintArray(arr);
            Console.WriteLine();
            Console.WriteLine("Sorting...");
            int i, j, k;
            for (i = 0; i < arr.Length; i++)
            {
                k = i;
                for (j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[k])
                    {
                        k = j;
                    }
                }
                Swap(arr, i, k);
            }
            Console.WriteLine("-Selection sort-");
            PrintArray(arr);
        }
        public static void set3p13()
        {
            Console.Write("Cate numere doriti sa contina vectorul?: ");
            int a = int.Parse(Console.ReadLine()); ;
            int[] arr;
            arr = new int[a];
            GenerateArray(arr);
            PrintArray(arr);
            Console.WriteLine();
            Console.WriteLine("Sorting...");
            int i, k;
            for (i = 1; i < arr.Length; i++)
            {
                for (k = i; k > 0 && arr[k] < arr[k - 1]; k--)
                {
                    Swap(arr, k, k - 1);
                }
            }
            Console.WriteLine("-Insertion sort-");
            PrintArray(arr);
        }
        public static void set3p14()
        {

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
        public static void set3p16()
        {

        }
        public static void set3p17()
        {
            Console.Write("Introduceti un nr. in baza 10: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("In ce baza doriti sa convertiti numarul?: ");
            int b = int.Parse(Console.ReadLine());
            switch (b)
            {
                case 2:
                    Console.WriteLine(Library1.Program.MyBase2Converter(a));
                    break;
                case 3:
                    Console.WriteLine(Library1.Program.MyBase3Converter(a));
                    break;
                case 4:
                    Console.WriteLine(Library1.Program.MyBase4Converter(a));
                    break;
                case 5:
                    Console.WriteLine(Library1.Program.MyBase5Converter(a));
                    break;
                case 6:
                    Console.WriteLine(Library1.Program.MyBase6Converter(a));
                    break;
                case 7:
                    Console.WriteLine(Library1.Program.MyBase7Converter(a));
                    break;
                case 8:
                    Console.WriteLine(Library1.Program.MyBase8Converter(a));
                    break;
                case 9:
                    Console.WriteLine(Library1.Program.MyBase9Converter(a));
                    break;
                case 10:
                    Console.WriteLine(Convert.ToString(a, 10));
                    break;
                case 11:
                    Console.WriteLine(Library1.Program.MyBase11Converter(a));
                    break;
                case 12:
                    Console.WriteLine(Library1.Program.MyBase12Converter(a));
                    break;
                case 13:
                    Console.WriteLine(Library1.Program.MyBase13Converter(a));
                    break;
                case 14:
                    Console.WriteLine(Library1.Program.MyBase14Converter(a));
                    break;
                case 15:
                    Console.WriteLine(Library1.Program.MyBase15Converter(a));
                    break;
                case 16:
                    Console.WriteLine(Library1.Program.MyBase16Converter(a));
                    break;
            }
        }
        public static void set3p18()
        {
            //
        }
        public static void set3p19()
        {
            //
        }
        public static void set3p20()
        {
            //
        }
        public static void set3p21()
        {
            //
        }
        public static void set3p22()
        {
            Console.Write("Cate numere doriti sa contina vectorul 1?(0,100): ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Cate numere doriti sa contina vectorul 2?(0,100): ");
            int a2 = int.Parse(Console.ReadLine());
            int[] arr = new int[a];
            int[] arr2 = new int[a2];
            int[] arr3 = arr;
            Array.Copy(arr, arr3, arr.Length);
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0, 100);
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = rnd.Next(0, 100);
            }
            PrintArray(arr);
            Console.WriteLine();
            PrintArray(arr2);
            Console.WriteLine();
            StringBuilder sb = new StringBuilder();
            int b;
            if (a2 > a)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr2.Length; j++)
                    {
                        if (arr[i] == arr2[j])
                        {
                            b = arr[i];
                            sb.Append(b + " ");
                            break;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < arr2.Length; i++)
                {
                    for (int j = 0; j < arr.Length; j++)
                    {
                        if (arr2[i] == arr[j])
                        {
                            b = arr2[i];
                            sb.Append(b + " ");
                            break;
                        }
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Interesctia:");
            for (int i = 0; i < sb.Length; i++)
            {
                Console.Write(sb[i]);
            }
            Console.WriteLine();
            sb.Clear();
            Console.WriteLine();
            Console.WriteLine("Reuniunea:");
            int c = 0;
            if (a > a2)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                    while (c < arr2.Length)
                    {
                        Console.Write(arr2[c] + " ");
                        c++;
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < arr2.Length; i++)
                {
                    Console.Write(arr2[i] + " ");
                    while (c < arr.Length)
                    {
                        Console.Write(arr[c] + " ");
                        c++;
                        break;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Diferenta v1-v2");
            if (a2 > a)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr2.Length; j++)
                    {
                        if (arr[i] == arr2[j])
                        {
                            arr = arr.Where((source, index) => index != i).ToArray();
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < arr2.Length; i++)
                {
                    for (int j = 0; j < arr.Length; j++)
                    {
                        if (arr2[i] == arr[j])
                        {
                            arr = arr.Where((source, index) => index != i).ToArray();
                        }
                    }
                }
            }
            PrintArray(arr);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Diferenta v2-v1");
            if (a > a2)
            {
                for (int i = 0; i < arr2.Length; i++)
                {
                    for (int j = 0; j < arr3.Length; j++)
                    {
                        if (arr2[i] == arr3[j])
                        {
                            arr2 = arr2.Where((source, index) => index != i).ToArray();

                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < arr3.Length; i++)
                {
                    for (int j = 0; j < arr2.Length; j++)
                    {
                        if (arr3[i] == arr2[j])
                        {
                            arr2 = arr2.Where((source, index) => index != i).ToArray();

                        }
                    }
                }
            }
            PrintArray(arr2);
            Console.WriteLine();
            Console.WriteLine();
        }
        public static void set3p23()
        {
            Console.Write("Cate numere doriti sa contina vectorul 1?(0,100): ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Cate numere doriti sa contina vectorul 2?(0,100): ");
            int a2 = int.Parse(Console.ReadLine());
            int[] arr = new int[a];
            int[] arr2 = new int[a2];
            int[] arr3 = arr;
            Array.Copy(arr, arr3, arr.Length);
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0, 100);
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = rnd.Next(0, 100);
            }
            PrintArray(arr);
            Console.WriteLine();
            PrintArray(arr2);
            Console.WriteLine();
            BubbleSort(arr);
            BubbleSort(arr2);
            BubbleSort(arr3);
            Console.WriteLine("Dupa sortare: ");
            Console.WriteLine();
            PrintArray(arr);
            Console.WriteLine();
            PrintArray(arr2);
            Console.WriteLine();
            Console.WriteLine();
            StringBuilder sb = new StringBuilder();
            int b;
            if (a2 > a)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr2.Length; j++)
                    {
                        if (arr[i] == arr2[j])
                        {
                            b = arr[i];
                            sb.Append(b + " ");
                            break;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < arr2.Length; i++)
                {
                    for (int j = 0; j < arr.Length; j++)
                    {
                        if (arr2[i] == arr[j])
                        {
                            b = arr2[i];
                            sb.Append(b + " ");
                            break;
                        }
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Interesctia:");
            for (int i = 0; i < sb.Length; i++)
            {
                Console.Write(sb[i]);
            }
            Console.WriteLine();
            sb.Clear();
            Console.WriteLine();
            Console.WriteLine("Reuniunea:");
            int c = 0;
            if (a > a2)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                    while (c < arr2.Length)
                    {
                        Console.Write(arr2[c] + " ");
                        c++;
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < arr2.Length; i++)
                {
                    Console.Write(arr2[i] + " ");
                    while (c < arr.Length)
                    {
                        Console.Write(arr[c] + " ");
                        c++;
                        break;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Diferenta v1-v2");
            if (a2 > a)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr2.Length; j++)
                    {
                        if (arr[i] == arr2[j])
                        {
                            arr = arr.Where((source, index) => index != i).ToArray();
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < arr2.Length; i++)
                {
                    for (int j = 0; j < arr.Length; j++)
                    {
                        if (arr2[i] == arr[j])
                        {
                            arr = arr.Where((source, index) => index != i).ToArray();
                        }
                    }
                }
            }
            PrintArray(arr);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Diferenta v2-v1");
            if (a > a2)
            {
                for (int i = 0; i < arr2.Length; i++)
                {
                    for (int j = 0; j < arr3.Length; j++)
                    {
                        if (arr2[i] == arr3[j])
                        {
                            arr2 = arr2.Where((source, index) => index != i).ToArray();

                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < arr3.Length; i++)
                {
                    for (int j = 0; j < arr2.Length; j++)
                    {
                        if (arr3[i] == arr2[j])
                        {
                            arr2 = arr2.Where((source, index) => index != i).ToArray();

                        }
                    }
                }
            }
            PrintArray(arr2);
            Console.WriteLine();
            Console.WriteLine();
        }
        public static void set3p24()
        {
            Console.Write("Cate numere doriti sa contina vectorul 1?(0,100): ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Cate numere doriti sa contina vectorul 2?(0,100): ");
            int a2 = int.Parse(Console.ReadLine());
            int[] arr = new int[a];
            int[] arr2 = new int[a2];
            int[] arr3 = arr;
            Array.Copy(arr, arr3, arr.Length);
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0, 100);
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = rnd.Next(0, 100);
            }
            List<int> com = new List<int>();
            int b;
            if (a2 > a)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr2.Length; j++)
                    {
                        if (arr[i] == arr2[j])
                        {
                            b = arr[i];
                            com.Add(b);
                            break;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < arr2.Length; i++)
                {
                    for (int j = 0; j < arr.Length; j++)
                    {
                        if (arr2[i] == arr[j])
                        {
                            b = arr2[i];
                            com.Add(b);
                            break;
                        }
                    }
                }
            }
            Console.WriteLine();
            PrintArray2(arr, 1);
            Console.WriteLine();
            Console.Write("---Binar--: ");
            for (int i = 0; i < arr.Length; i++)
            {

                if (com.Contains(arr[i]))
                {
                    Console.Write("1  ");
                }
                else
                {
                    Console.Write("0  ");
                }

            }
            Console.WriteLine();
            PrintArray2(arr2, 2);
            Console.WriteLine();
            Console.Write("---Binar--: ");
            for (int i = 0; i < arr2.Length; i++)
            {

                if (com.Contains(arr2[i]))
                {
                    Console.Write("1  ");
                }
                else
                {
                    Console.Write("0  ");
                }

            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Reuniunea:");
            int c = 0;
            if (a > a2)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                    while (c < arr2.Length)
                    {
                        Console.Write(arr2[c] + " ");
                        c++;
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < arr2.Length; i++)
                {
                    Console.Write(arr2[i] + " ");
                    while (c < arr.Length)
                    {
                        Console.Write(arr[c] + " ");
                        c++;
                        break;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Diferenta v1-v2");
            if (a2 > a)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr2.Length; j++)
                    {
                        if (arr[i] == arr2[j])
                        {
                            arr = arr.Where((source, index) => index != i).ToArray();
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < arr2.Length; i++)
                {
                    for (int j = 0; j < arr.Length; j++)
                    {
                        if (arr2[i] == arr[j])
                        {
                            arr = arr.Where((source, index) => index != i).ToArray();
                        }
                    }
                }
            }
            PrintArray2(arr, 1);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Diferenta v2-v1");
            if (a > a2)
            {
                for (int i = 0; i < arr2.Length; i++)
                {
                    for (int j = 0; j < arr3.Length; j++)
                    {
                        if (arr2[i] == arr3[j])
                        {
                            arr2 = arr2.Where((source, index) => index != i).ToArray();

                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < arr3.Length; i++)
                {
                    for (int j = 0; j < arr2.Length; j++)
                    {
                        if (arr3[i] == arr2[j])
                        {
                            arr2 = arr2.Where((source, index) => index != i).ToArray();

                        }
                    }
                }
            }
            PrintArray2(arr2, 2);
            Console.WriteLine();
            Console.WriteLine();
        }
        public static void set3p25()
        {

        }
        public static void set3p26()
        {
            //
        }
        public static void set3p27()
        {

        }
        public static void set3p28()
        {

        }
        public static void set3p29()
        {

        }
        public static void set3p30()
        {
            //
        }
        public static void set3p31()
        {
            Console.Write("Cate numere doriti sa contina vectorul?(-100,100): ");
            int a = int.Parse(Console.ReadLine());
            int[] arr = new int[a];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0, 3);
            }
            PrintArray(arr);
            Console.WriteLine();
            int m = 0;
            bool ok = false;
            double n = a / 2;
            for (int i = 0; i < arr.Length; i++)
            {
                int b = arr[i];
                int rp = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (b == arr[j])
                    {
                        rp++;
                        if (rp >= n)
                        {
                            m = b;
                            ok = true;
                        }

                    }
                }
            }
            if (ok)
            {
                Console.WriteLine($"Numarul majoritar este: {m}");
            }
            else
            {
                Console.WriteLine("Nu este numar majoritar.");
            }
            Console.WriteLine();
        }

        private static void PrintArray(int[] arr)
        {
            Console.Write("Vectorul: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        public static void PrintArray2(int[] arr, int nr)
        {
            Console.Write($"Vectorul {nr}: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        public static int[] GenerateArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-100, 100);
            }
            return arr;
        }
        private static void Swap(int[] arr, int i, int j)
        {
            int aux;
            aux = arr[i];
            arr[i] = arr[j];
            arr[j] = aux;
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
