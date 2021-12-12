using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Probleme_Set_1;
using Probleme_Set_2;
using Probleme_Set_3;
using Library1;

namespace Tema_Set_1_2_3
{
    class Program
    {
        //Partea principala din program
        //Pentru ca programul sa functioneze corect aceasta solutie trebuie selecta ca si startup project
        static void Main(string[] args)
        {
            
            Library1.Program.time();
            Console.WriteLine("Welcome dear User to my program !\n");
            password();
            start:
            Console.WriteLine("Chose an option from below:");
            Console.WriteLine();
            options();
            Console.Write("Please enter the number of the option you want to choose: ");
            optionSelect();
            
            // o functie "goto" pt a merge inapoi la inceput dupa ce sa parcurs odata prin program           
            Console.Write("Do you want to return to the main menu? (y/n)");
            string b = Console.ReadLine();
            string y = "y";
            string n = "n";
            if (b == y)
            {
                Console.Clear();
                goto start;           
            }
            else if (b == n)
            {
                Console.WriteLine("\nThank you for using my program!");
            }
            
        }

        /// <summary>
        /// optiunile listate care apar la inceput
        /// </summary>
        static void options()
        {
            Console.WriteLine("1.Probleme");
            Console.WriteLine("2.Afisre codul problemelor");
        }
        /// <summary>
        /// -al doilea set de optiuni care apar in functie de ce alegi la primul set de optiuni
        /// -si se mai apeleaza o functie specifica in care vei introduce nr optiunii alese si te va redirectiona spre partea aleasa
        /// </summary>
        static void optionSelect()
        {
            int select = int.Parse(Console.ReadLine());
            switch (select)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Select the set:\n");
                    Console.WriteLine("1.Set 1");
                    Console.WriteLine("2.Set 2");
                    Console.WriteLine("3.Set 3");
                    afisareProbleme();
                    Console.WriteLine("Again or continue? (a/c)");
                    string b = Console.ReadLine();
                    string y = "a";
                    string n = "c";
                    if (b == y)
                    {
                        Console.Clear();
                        goto again;
                    }
                    else if (b == n)
                    {
                        Console.WriteLine("\nThank you for using my program!");
                    }
                    break;
                case 2:
                    again:
                    Console.Clear();
                    Console.WriteLine("1.Cod probleme 1");
                    Console.WriteLine("2.Cod probleme 2");
                    Console.WriteLine("3.Cod probleme 3");
                    codprobleme();
                    Console.WriteLine("Again or continue? (a/c)");
                    string d = Console.ReadLine();
                    string a = "a";
                    string c = "c";
                    if (d == a)
                    {
                        Console.Clear();
                        goto again;
                    }
                    else if (d == c)
                    {
                        Console.WriteLine("\nThank you for using my program!");
                    }
                    break;
                default:
                    break;
            }

        }
        /// <summary>
        /// functia password aceasta depinzand de un bool care daca va intoarce true vei intra in program iar daca nu se va inchide
        /// </summary>
        static void password()
        {
            if (Library1.Program.passv2())
            {
                Console.WriteLine("Now you can use the program!");
            }
            else
            {
                Environment.Exit(1);
            }

        }
        /// <summary>
        /// -acest bool va verifica parola introdusa si va acorda 5 incercari de a introduce parola dupa ce acele incercari se termina
        /// programul se va inchide 
        /// - daca parola se potriveste vei putea intra in cont
        /// </summary>        
        static bool pass()
        {
            for (int P = 5; P > 0; P--)
            {
                
                Console.Write("Please type the password:");
                string p = Console.ReadLine();               
                string passwords = "123";
                int done = 0;
                if (p == passwords)
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
        /// <summary>
        /// aceasta functie este apelata in functia de mai sus optionSelect(), in cazul in care utilizatorul alege prima optiune
        /// aceasta functie urmand sa redirectioneze utilizatorul spre partea cu probleme
        /// </summary>
        static void afisareProbleme()
        {
            Console.WriteLine("Scrieti numarul optiunii pe care o alegeti: ");
            int af = int.Parse(Console.ReadLine());
            if (af == 1)
            {
                Console.Clear();
                Console.WriteLine("\nProbleme set 1:");
                Probleme_Set_1.Program.afisareProblemeSet1();

            }
            else if (af == 2)
            {
                Console.Clear();
                Console.WriteLine("\nProbleme set 2:");
                Probleme_Set_2.Program.afisareProblemeSet2();
            }
            else if (af == 3)
            {
                Console.Clear();
                Console.WriteLine("\nProbleme set 3:");
                Probleme_Set_3.Program.afisareProblemeSet3();
            }

        }
        /// <summary>
        /// aceasta functie este apelata in functia de mai sus optionSelect(), in cazul in care utilizatorul alege a doua optiune
        /// aceasta functie urmand sa redirectioneze utilizatorul spre partea cu codul problemelor
        /// </summary>
        static void codprobleme()
        {
            Console.WriteLine("Scrieti numarul optiunii pe care o alegeti: ");
            int rs = int.Parse(Console.ReadLine());
            if (rs == 1)
            {
                Library1.Program.codprobleme1();
            }
            else if (rs == 2)
            {
                Library1.Program.codprobleme2();
            } else if(rs == 3)
            {
                Library1.Program.codprobleme3();
            }
        }
    }
}
