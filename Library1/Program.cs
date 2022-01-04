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
            // this will be empty for now...
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
            try
            {
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
                        Console.WriteLine("Wrong problem number.Try again!");
                        goto repeat;

                }
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("EROR: wrong input.");
                Console.WriteLine("Please try again...");
                goto repeat;
            }
        }
        public static void codprobleme2()
        {
            Console.WriteLine("Problema 1(Cate din ele sunt pare.)");
            Console.WriteLine("Problema 2(Cate sunt negative, cate sunt zero si cate sunt pozitive.)");
            Console.WriteLine("Problema 3(Suma si produsul numerelor de la 1 la n.)");
            Console.WriteLine("Problema 4(Pe ce pozitie se afla in secventa un numara a.)");
            Console.WriteLine("Problema 5(Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa.)");
            Console.WriteLine("Problema 6(Sa se determine daca numerele din secventa sunt in ordine crescatoare.)");
            Console.WriteLine("Problema 7(Sa se determine cea mai mare si cea mai mica valoare din secventa.)");
            Console.WriteLine("Problema 8(Al n-lea numar din sirul lui Fibonacci.)");
            Console.WriteLine("Problema 9(Daca o secventa de n numere este monotona.)");
            Console.WriteLine("Problema 10(Care este numarul maxim de numere consecutive egale din secventa.)");
            Console.WriteLine("Problema 11(Sa se caculeze suma inverselor acestor numere.)");
            Console.WriteLine("Problema 12(Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere.)");
            Console.WriteLine("Problema 13(Determinati daca o secventa de n numere este o secventa crescatoare rotita.)");
            Console.WriteLine("Problema 14(Determinati daca o secventa de n numere este o secventa monotona rotita.)");
            Console.WriteLine("Problema 15(Sa se determine daca este bitonica.)");
            Console.WriteLine("Problema 16(Se da o secventa de n numere. Se cere sa se determine daca este o secventa bitonica rotita.)");
            Console.WriteLine("Problema 17(Determinati daca secventa reprezinta o secventa de paranteze corecta.)");
            repeat1:
            Console.Write("\nType the number of the problem you want to see: ");
            try
            {
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
                    case 3:
                        TextReader s2load3 = new StreamReader(@"..\..\CodeLineProbleme2\Set2p3.txt");
                        string s2buffer3;
                        while ((s2buffer3 = s2load3.ReadLine()) != null)
                        {
                            Console.WriteLine(s2buffer3);
                        }
                        break;
                    case 4:
                        TextReader s2load4 = new StreamReader(@"..\..\CodeLineProbleme2\Set2p4.txt");
                        string s2buffer4;
                        while ((s2buffer4 = s2load4.ReadLine()) != null)
                        {
                            Console.WriteLine(s2buffer4);
                        }
                        break;
                    case 5:
                        TextReader s2load5 = new StreamReader(@"..\..\CodeLineProbleme2\Set2p5.txt");
                        string s2buffer5;
                        while ((s2buffer5 = s2load5.ReadLine()) != null)
                        {
                            Console.WriteLine(s2buffer5);
                        }
                        break;
                    case 6:
                        TextReader s2load6 = new StreamReader(@"..\..\CodeLineProbleme2\Set2p6.txt");
                        string s2buffer6;
                        while ((s2buffer6 = s2load6.ReadLine()) != null)
                        {
                            Console.WriteLine(s2buffer6);
                        }
                        break;
                    case 7:
                        TextReader s2load7 = new StreamReader(@"..\..\CodeLineProbleme2\Set2p7.txt");
                        string s2buffer7;
                        while ((s2buffer7 = s2load7.ReadLine()) != null)
                        {
                            Console.WriteLine(s2buffer7);
                        }
                        break;
                    case 8:
                        TextReader s2load8 = new StreamReader(@"..\..\CodeLineProbleme2\Set2p8.txt");
                        string s2buffer8;
                        while ((s2buffer8 = s2load8.ReadLine()) != null)
                        {
                            Console.WriteLine(s2buffer8);
                        }
                        break;
                    case 9:
                        TextReader s2load9 = new StreamReader(@"..\..\CodeLineProbleme2\Set2p9.txt");
                        string s2buffer9;
                        while ((s2buffer9 = s2load9.ReadLine()) != null)
                        {
                            Console.WriteLine(s2buffer9);
                        }
                        break;
                    case 10:
                        TextReader s2load10 = new StreamReader(@"..\..\CodeLineProbleme2\Set2p10.txt");
                        string s2buffer10;
                        while ((s2buffer10 = s2load10.ReadLine()) != null)
                        {
                            Console.WriteLine(s2buffer10);
                        }
                        break;
                    case 11:
                        TextReader s2load11 = new StreamReader(@"..\..\CodeLineProbleme2\Set2p11.txt");
                        string s2buffer11;
                        while ((s2buffer11 = s2load11.ReadLine()) != null)
                        {
                            Console.WriteLine(s2buffer11);
                        }
                        break;
                    case 12:
                        TextReader s2load12 = new StreamReader(@"..\..\CodeLineProbleme2\Set2p12.txt");
                        string s2buffer12;
                        while ((s2buffer12 = s2load12.ReadLine()) != null)
                        {
                            Console.WriteLine(s2buffer12);
                        }
                        break;
                    case 13:
                        TextReader s2load13 = new StreamReader(@"..\..\CodeLineProbleme2\Set2p13.txt");
                        string s2buffer13;
                        while ((s2buffer13 = s2load13.ReadLine()) != null)
                        {
                            Console.WriteLine(s2buffer13);
                        }
                        break;
                    case 14:
                        TextReader s2load14 = new StreamReader(@"..\..\CodeLineProbleme2\Set2p14.txt");
                        string s2buffer14;
                        while ((s2buffer14 = s2load14.ReadLine()) != null)
                        {
                            Console.WriteLine(s2buffer14);
                        }
                        break;
                    case 15:
                        TextReader s2load15 = new StreamReader(@"..\..\CodeLineProbleme2\Set2p15.txt");
                        string s2buffer15;
                        while ((s2buffer15 = s2load15.ReadLine()) != null)
                        {
                            Console.WriteLine(s2buffer15);
                        }
                        break;
                    case 16:
                        TextReader s2load16 = new StreamReader(@"..\..\CodeLineProbleme2\Set2p16.txt");
                        string s2buffer16;
                        while ((s2buffer16 = s2load16.ReadLine()) != null)
                        {
                            Console.WriteLine(s2buffer16);
                        }
                        break;
                    case 17:
                        TextReader s2load17 = new StreamReader(@"..\..\CodeLineProbleme2\Set2p17.txt");
                        string s2buffer17;
                        while ((s2buffer17 = s2load17.ReadLine()) != null)
                        {
                            Console.WriteLine(s2buffer17);
                        }
                        break;
                    default:
                        Console.WriteLine("Wrong problem number.Try again!");
                        goto repeat1;
                        
                }
            }
            catch
            {               
                Console.WriteLine();
                Console.WriteLine("EROR: wrong input.");
                Console.WriteLine("Please try again...");
                goto repeat1;
            }

        }
        public static void codprobleme3()
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
        repeat2:
            Console.Write("\nType the number of the problem you want to see: ");
            try
            {
                int set3 = int.Parse(Console.ReadLine());
                switch (set3)
                {
                    case 1:
                        TextReader s3load1 = new StreamReader(@"..\..\CodeLineProbleme3\Set3p1.txt");
                        string s3buffer1;
                        while ((s3buffer1 = s3load1.ReadLine()) != null)
                        {
                            Console.WriteLine(s3buffer1);
                        }
                        break;
                    case 2:
                        TextReader s3load2 = new StreamReader(@"..\..\CodeLineProbleme3\Set3p2.txt");
                        string s3buffer2;
                        while ((s3buffer2 = s3load2.ReadLine()) != null)
                        {
                            Console.WriteLine(s3buffer2);
                        }
                        break;
                    case 3:
                        TextReader s3load3 = new StreamReader(@"..\..\CodeLineProbleme3\Set3p3.txt");
                        string s3buffer3;
                        while ((s3buffer3 = s3load3.ReadLine()) != null)
                        {
                            Console.WriteLine(s3buffer3);
                        }
                        break;
                    case 4:
                        TextReader s3load4 = new StreamReader(@"..\..\CodeLineProbleme3\Set3p4.txt");
                        string s3buffer4;
                        while ((s3buffer4 = s3load4.ReadLine()) != null)
                        {
                            Console.WriteLine(s3buffer4);
                        }
                        break;
                    case 5:
                        TextReader s3load5 = new StreamReader(@"..\..\CodeLineProbleme3\Set3p5.txt");
                        string s3buffer5;
                        while ((s3buffer5 = s3load5.ReadLine()) != null)
                        {
                            Console.WriteLine(s3buffer5);
                        }
                        break;
                    case 6:
                        TextReader s3load6 = new StreamReader(@"..\..\CodeLineProbleme3\Set3p6.txt");
                        string s3buffer6;
                        while ((s3buffer6 = s3load6.ReadLine()) != null)
                        {
                            Console.WriteLine(s3buffer6);
                        }
                        break;
                    case 7:
                        TextReader s3load7 = new StreamReader(@"..\..\CodeLineProbleme3\Set3p7.txt");
                        string s3buffer7;
                        while ((s3buffer7 = s3load7.ReadLine()) != null)
                        {
                            Console.WriteLine(s3buffer7);
                        }
                        break;
                    case 8:
                        TextReader s3load8 = new StreamReader(@"..\..\CodeLineProbleme3\Set3p8.txt");
                        string s3buffer8;
                        while ((s3buffer8 = s3load8.ReadLine()) != null)
                        {
                            Console.WriteLine(s3buffer8);
                        }
                        break;
                    case 9:
                        TextReader s3load9 = new StreamReader(@"..\..\CodeLineProbleme3\Set3p9.txt");
                        string s3buffer9;
                        while ((s3buffer9 = s3load9.ReadLine()) != null)
                        {
                            Console.WriteLine(s3buffer9);
                        }
                        break;
                    case 10:
                        TextReader s3load10 = new StreamReader(@"..\..\CodeLineProbleme3\Set3p10.txt");
                        string s3buffer10;
                        while ((s3buffer10 = s3load10.ReadLine()) != null)
                        {
                            Console.WriteLine(s3buffer10);
                        }
                        break;
                    case 11:
                        TextReader s3load11 = new StreamReader(@"..\..\CodeLineProbleme3\Set3p11.txt");
                        string s3buffer11;
                        while ((s3buffer11 = s3load11.ReadLine()) != null)
                        {
                            Console.WriteLine(s3buffer11);
                        }
                        break;
                    case 12:
                        TextReader s3load12 = new StreamReader(@"..\..\CodeLineProbleme3\Set3p12.txt");
                        string s3buffer12;
                        while ((s3buffer12 = s3load12.ReadLine()) != null)
                        {
                            Console.WriteLine(s3buffer12);
                        }
                        break;
                    case 13:
                        TextReader s3load13 = new StreamReader(@"..\..\CodeLineProbleme3\Set3p13.txt");
                        string s3buffer13;
                        while ((s3buffer13 = s3load13.ReadLine()) != null)
                        {
                            Console.WriteLine(s3buffer13);
                        }
                        break;
                    case 14:
                        TextReader s3load14 = new StreamReader(@"..\..\CodeLineProbleme3\Set3p14.txt");
                        string s3buffer14;
                        while ((s3buffer14 = s3load14.ReadLine()) != null)
                        {
                            Console.WriteLine(s3buffer14);
                        }
                        break;
                    case 15:
                        TextReader s3load15 = new StreamReader(@"..\..\CodeLineProbleme3\Set3p15.txt");
                        string s3buffer15;
                        while ((s3buffer15 = s3load15.ReadLine()) != null)
                        {
                            Console.WriteLine(s3buffer15);
                        }
                        break;
                    case 16:
                        TextReader s3load16 = new StreamReader(@"..\..\CodeLineProbleme3\Set3p16.txt");
                        string s3buffer16;
                        while ((s3buffer16 = s3load16.ReadLine()) != null)
                        {
                            Console.WriteLine(s3buffer16);
                        }
                        break;
                    case 17:
                        TextReader s3load17 = new StreamReader(@"..\..\CodeLineProbleme3\Set3p17.txt");
                        string s3buffer17;
                        while ((s3buffer17 = s3load17.ReadLine()) != null)
                        {
                            Console.WriteLine(s3buffer17);
                        }
                        break;
                    case 18:
                        TextReader s3load18 = new StreamReader(@"..\..\CodeLineProbleme3\Set3p18.txt");
                        string s3buffer18;
                        while ((s3buffer18 = s3load18.ReadLine()) != null)
                        {
                            Console.WriteLine(s3buffer18);
                        }
                        break;
                    case 19:
                        TextReader s3load19 = new StreamReader(@"..\..\CodeLineProbleme3\Set3p19.txt");
                        string s3buffer19;
                        while ((s3buffer19 = s3load19.ReadLine()) != null)
                        {
                            Console.WriteLine(s3buffer19);
                        }
                        break;
                    case 20:
                        TextReader s3load20 = new StreamReader(@"..\..\CodeLineProbleme3\Set3p20.txt");
                        string s3buffer20;
                        while ((s3buffer20 = s3load20.ReadLine()) != null)
                        {
                            Console.WriteLine(s3buffer20);
                        }
                        break;
                    case 21:
                        TextReader s3load21 = new StreamReader(@"..\..\CodeLineProbleme3\Set3p21.txt");
                        string s3buffer21;
                        while ((s3buffer21 = s3load21.ReadLine()) != null)
                        {
                            Console.WriteLine(s3buffer21);
                        }
                        break;
                    case 22:
                        TextReader s3load22 = new StreamReader(@"..\..\CodeLineProbleme3\Set3p22.txt");
                        string s3buffer22;
                        while ((s3buffer22 = s3load22.ReadLine()) != null)
                        {
                            Console.WriteLine(s3buffer22);
                        }
                        break;
                    case 23:
                        TextReader s3load23 = new StreamReader(@"..\..\CodeLineProbleme3\Set3p23.txt");
                        string s3buffer23;
                        while ((s3buffer23 = s3load23.ReadLine()) != null)
                        {
                            Console.WriteLine(s3buffer23);
                        }
                        break;
                    case 24:
                        TextReader s3load24 = new StreamReader(@"..\..\CodeLineProbleme3\Set3p24.txt");
                        string s3buffer24;
                        while ((s3buffer24 = s3load24.ReadLine()) != null)
                        {
                            Console.WriteLine(s3buffer24);
                        }
                        break;
                    case 25:
                        TextReader s3load25 = new StreamReader(@"..\..\CodeLineProbleme3\Set3p25.txt");
                        string s3buffer25;
                        while ((s3buffer25 = s3load25.ReadLine()) != null)
                        {
                            Console.WriteLine(s3buffer25);
                        }
                        break;
                    case 26:
                        TextReader s3load26 = new StreamReader(@"..\..\CodeLineProbleme3\Set3p26.txt");
                        string s3buffer26;
                        while ((s3buffer26 = s3load26.ReadLine()) != null)
                        {
                            Console.WriteLine(s3buffer26);
                        }
                        break;
                    case 27:
                        TextReader s3load27 = new StreamReader(@"..\..\CodeLineProbleme3\Set3p27.txt");
                        string s3buffer27;
                        while ((s3buffer27 = s3load27.ReadLine()) != null)
                        {
                            Console.WriteLine(s3buffer27);
                        }
                        break;
                    case 28:
                        TextReader s3load28 = new StreamReader(@"..\..\CodeLineProbleme3\Set3p28.txt");
                        string s3buffer28;
                        while ((s3buffer28 = s3load28.ReadLine()) != null)
                        {
                            Console.WriteLine(s3buffer28);
                        }
                        break;
                    case 29:
                        TextReader s3load29 = new StreamReader(@"..\..\CodeLineProbleme3\Set3p29.txt");
                        string s3buffer29;
                        while ((s3buffer29 = s3load29.ReadLine()) != null)
                        {
                            Console.WriteLine(s3buffer29);
                        }
                        break;
                    case 30:
                        TextReader s3load30 = new StreamReader(@"..\..\CodeLineProbleme3\Set3p30.txt");
                        string s3buffer30;
                        while ((s3buffer30 = s3load30.ReadLine()) != null)
                        {
                            Console.WriteLine(s3buffer30);
                        }
                        break;
                    case 31:
                        TextReader s3load31 = new StreamReader(@"..\..\CodeLineProbleme3\Set3p31.txt");
                        string s3buffer31;
                        while ((s3buffer31 = s3load31.ReadLine()) != null)
                        {
                            Console.WriteLine(s3buffer31);
                        }
                        break;
                    default:
                        Console.WriteLine("Wrong problem number.Try again!");
                        goto repeat2;
                }
            }
            catch
            {
                Console.WriteLine("EROR: wrong input.");
                Console.WriteLine("Please try again...");
                goto repeat2;
            }

        }       
        public static bool passv2()
        {
            for (int P = 5; P > 0; P--)
            {
                Console.Write("Please type the password:");
                string p = Console.ReadLine();
                TextReader loadps = new StreamReader(@"..\..\Properties\Cache.txt");
                string interval = loadps.ReadLine();
                string[] local_data = interval.Split(' ');
                string passwords = "123";
                int done = 0;
                if (p == local_data[21] || p==passwords)
                {
                    Console.WriteLine("Password corect!\n\nWelcome!\n");
                    return true;
                }
                else
                {
                    Console.WriteLine("wrong password");
                    Console.WriteLine($"{P - 1} attemps left");
                }
                if (P == done)
                {
                    Console.WriteLine("No more attemps left...\n The program is closing...");
                    return false;

                }
            }
            return false;

        }

        //-----------------------------------------------
        public static string MyBase2Converter(int a)
        {
            int cifra;
            Stack<int> digits = new Stack<int>();
            while (a > 0)
            {
                cifra = a % 2;
                digits.Push(cifra);
                a /= 2;
            }
            StringBuilder sb = new StringBuilder();
            string map = "01";
            while (digits.Count > 0)
            {
                cifra = digits.Pop();
                sb.Append(map[cifra]);
            }


            return sb.ToString();
        }
        public static string MyBase3Converter(int a)
        {
            int cifra;
            Stack<int> digits = new Stack<int>();
            while (a > 0)
            {
                cifra = a % 3;
                digits.Push(cifra);
                a /= 3;
            }
            StringBuilder sb = new StringBuilder();
            string map = "012";
            while (digits.Count > 0)
            {
                cifra = digits.Pop();
                sb.Append(map[cifra]);
            }


            return sb.ToString();
        }
        public static string MyBase4Converter(int a)
        {
            int cifra;
            Stack<int> digits = new Stack<int>();
            while (a > 0)
            {
                cifra = a % 4;
                digits.Push(cifra);
                a /= 4;
            }
            StringBuilder sb = new StringBuilder();
            string map = "0123";
            while (digits.Count > 0)
            {
                cifra = digits.Pop();
                sb.Append(map[cifra]);
            }


            return sb.ToString();
        }
        public static string MyBase5Converter(int a)
        {
            int cifra;
            Stack<int> digits = new Stack<int>();
            while (a > 0)
            {
                cifra = a % 5;
                digits.Push(cifra);
                a /= 5;
            }
            StringBuilder sb = new StringBuilder();
            string map = "01234";
            while (digits.Count > 0)
            {
                cifra = digits.Pop();
                sb.Append(map[cifra]);
            }


            return sb.ToString();
        }
        public static string MyBase6Converter(int a)
        {
            int cifra;
            Stack<int> digits = new Stack<int>();
            while (a > 0)
            {
                cifra = a % 6;
                digits.Push(cifra);
                a /= 6;
            }
            StringBuilder sb = new StringBuilder();
            string map = "012345";
            while (digits.Count > 0)
            {
                cifra = digits.Pop();
                sb.Append(map[cifra]);
            }


            return sb.ToString();
        }
        public static string MyBase7Converter(int a)
        {
            int cifra;
            Stack<int> digits = new Stack<int>();
            while (a > 0)
            {
                cifra = a % 7;
                digits.Push(cifra);
                a /= 7;
            }
            StringBuilder sb = new StringBuilder();
            string map = "0123456";
            while (digits.Count > 0)
            {
                cifra = digits.Pop();
                sb.Append(map[cifra]);
            }


            return sb.ToString();
        }
        public static string MyBase8Converter(int a)
        {
            int cifra;
            Stack<int> digits = new Stack<int>();
            while (a > 0)
            {
                cifra = a % 8;
                digits.Push(cifra);
                a /= 8;
            }
            StringBuilder sb = new StringBuilder();
            string map = "01234567";
            while (digits.Count > 0)
            {
                cifra = digits.Pop();
                sb.Append(map[cifra]);
            }


            return sb.ToString();
        }
        public static string MyBase9Converter(int a)
        {
            int cifra;
            Stack<int> digits = new Stack<int>();
            while (a > 0)
            {
                cifra = a % 9;
                digits.Push(cifra);
                a /= 9;
            }
            StringBuilder sb = new StringBuilder();
            string map = "01234567";
            while (digits.Count > 0)
            {
                cifra = digits.Pop();
                sb.Append(map[cifra]);
            }


            return sb.ToString();
        }
        public static string MyBase11Converter(int a)
        {
            int cifra;
            Stack<int> digits = new Stack<int>();
            while (a > 0)
            {
                cifra = a % 11;
                digits.Push(cifra);
                a /= 11;
            }
            StringBuilder sb = new StringBuilder();
            string map = "0123456789A";
            while (digits.Count > 0)
            {
                cifra = digits.Pop();
                sb.Append(map[cifra]);
            }


            return sb.ToString();
        }
        public static string MyBase12Converter(int a)
        {
            int cifra;
            Stack<int> digits = new Stack<int>();
            while (a > 0)
            {
                cifra = a % 12;
                digits.Push(cifra);
                a /= 12;
            }
            StringBuilder sb = new StringBuilder();
            string map = "0123456789AB";
            while (digits.Count > 0)
            {
                cifra = digits.Pop();
                sb.Append(map[cifra]);
            }


            return sb.ToString();
        }
        public static string MyBase13Converter(int a)
        {
            int cifra;
            Stack<int> digits = new Stack<int>();
            while (a > 0)
            {
                cifra = a % 13;
                digits.Push(cifra);
                a /= 13;
            }
            StringBuilder sb = new StringBuilder();
            string map = "0123456789ABC";
            while (digits.Count > 0)
            {
                cifra = digits.Pop();
                sb.Append(map[cifra]);
            }


            return sb.ToString();
        }
        public static string MyBase14Converter(int a)
        {
            int cifra;
            Stack<int> digits = new Stack<int>();
            while (a > 0)
            {
                cifra = a % 14;
                digits.Push(cifra);
                a /= 14;
            }
            StringBuilder sb = new StringBuilder();
            string map = "0123456789ABCD";
            while (digits.Count > 0)
            {
                cifra = digits.Pop();
                sb.Append(map[cifra]);
            }


            return sb.ToString();
        }
        public static string MyBase15Converter(int a)
        {
            int cifra;
            Stack<int> digits = new Stack<int>();
            while (a > 0)
            {
                cifra = a % 15;
                digits.Push(cifra);
                a /= 15;
            }
            StringBuilder sb = new StringBuilder();
            string map = "0123456789ABCDE";
            while (digits.Count > 0)
            {
                cifra = digits.Pop();
                sb.Append(map[cifra]);
            }


            return sb.ToString();
        }
        public static string MyBase16Converter(int a)
        {
            int cifra;
            Stack<int> digits = new Stack<int>();
            while (a > 0)
            {
                cifra = a % 16;
                digits.Push(cifra);
                a /= 16;
            }
            StringBuilder sb = new StringBuilder();
            string map = "0123456789ABCDEF";
            while (digits.Count > 0)
            {
                cifra = digits.Pop();
                sb.Append(map[cifra]);
            }


            return sb.ToString();
        }
    }
}

