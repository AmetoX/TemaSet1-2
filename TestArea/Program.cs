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
            Console.Write("Introduceti un nr > 3: ");
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            sb.Capacity = n;
            int a = 0;
            int b = 0;
            int c = 0;
            int r=n;
            int d = 0;
            bool cres = false;
            bool des = false;
            int e=0;
            int f=0;
            int g=0;
            int h =0;
            for (int i = 1; i <= n; i++)
            {                
                r = r/2+1;
                if (r > a)
                {
                    if (a > b)
                    {
                        cres = false;
                        if (b > d)
                        {
                            cres = true;
                            c++;
                        }
                        
                        d = b;
                    }
                    b = a;
                    
                }              
                a = r;
                
                if (f>r)
                {
                    if (e>f)
                    {
                        des = false;
                        if (h>e)
                        {
                            des = true;
                            g++;
                        }
                        h = e;
                    }
                    e = f;
                }
                f = r;
                
                sb.Append(r + " ");
            }
            Console.WriteLine();
            Console.WriteLine(cres);
            Console.WriteLine(des);
            for(int j = 0; j < sb.Length; j++)
            {
                Console.Write(sb[j]);
            }
            Console.WriteLine();
            if (c == n-2 || cres)
            {
                Console.WriteLine("Sirul este crescator.");
               
            }else if (g == n - 3 || des)
            {
                Console.WriteLine("descrescator");
            }
            else
            {
                Console.WriteLine("Sirul nu este crescator.");
            }
        }
    }
}