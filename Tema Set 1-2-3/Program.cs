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
        static void Main(string[] args)
        {
            Library1.Program.time();
            Console.WriteLine("Welcome dear User to my program !\n");
            password();
            start:
            Console.WriteLine("Chose an option from below:");
            options();
            Console.Write("Please enter the number of the option you want to choose: ");
            optionSelect();
            Console.Clear();
            Console.Write("Do you want to return to the main menu? (y/n)");
            string b = Console.ReadLine();
            string y = "y";
            string n = "n";
            if (b == y)
            {
                goto start;
                
            }
            else if (b == n)
            {
                Console.WriteLine("\nThank you for using my program!");
            }
        }
        
        static void options()
        {
            Console.WriteLine("1.Probleme");
            Console.WriteLine("2.Afisre codul problemelor");
        }
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
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("1.Cod probleme 1");
                    Console.WriteLine("2.Cod probleme 2");
                    Console.WriteLine("3.Cod probleme 3");
                    codprobleme();
                    break;
                default:
                    break;
            }

        }
        static void password()
        {
            if (pass())
            {
                Console.WriteLine("Now you can use the program!");
            }
            else
            {
                Environment.Exit(1);
            }

        }
        static bool pass()
        {
            for (int P = 5; P > 0; P--)
            {
                int done = 0;
                Console.WriteLine("Please type the password:");
                string p = Console.ReadLine();
                //string sp = p.ToString();
                string passwords = "123";
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
