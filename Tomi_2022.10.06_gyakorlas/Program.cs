using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tomi_2022._10._06_gyakorlas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Írj programot, ami beolvas két számot, majd kiírja:
            a.az összegüket;
            b.különbségüket;
            c.szorzatukat;
            d.hányadosukat, ha lehet!
            */
            Console.Write("Kérem adja me az egyik számot: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Kérem adja meg a másik számot: ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine($"két szám összege: {x + y}" +
                $"\nkét szám künönbsége: {((x>y) ? (x - y) : (y-x))}" +
                $"\nkét szám szorzata: {x * y}" +
                $"\nkét szám hányadosa:{((x > y) ? ((double)x / y) : (double)((double)y / x))}");

            /*Írj programot, mely beolvas két egész számot, és kiírja a képernyőre a
                nagyobbikat!*/
            if(x>y)
            {
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine(y);
            }

            //Írj programot, mely beolvas három egész számot, és kiírja a képernyőre a
            //legkisebbet!
            Console.Write("Kérem adja meg a 3. számot: ");
            int z = int.Parse(Console.ReadLine());
            
            if(x<y)
            {
                if(x<z)
                {
                    Console.WriteLine(x);
                }
                /*else
                {
                    Console.WriteLine(y);
                }*/
            }
            else if (y<z)
            {
                if(y<x)
                {
                    Console.WriteLine(y);
                }
                /*else
                {
                    Console.WriteLine(z);
                }*/
            }
            else if (z<x)
            {
                if(z<y)
                {
                    Console.WriteLine(z);
                }
                /*else
                {
                    Console.WriteLine(x);
                }*/
            }

            Console.WriteLine("Az én megoldásom!");

            if (x<y && x<z)
            {
                Console.WriteLine(x);
            }
            else if(y<z && y < x)
            {
                Console.WriteLine(y);
            }
            else
            {
                Console.WriteLine(z);
            }

            Console.WriteLine("Az én másik megoldásom!");
            if (x < y && x < z)
            {
                Console.WriteLine(x);
            }
            if (y < z && y < x)
            {
                Console.WriteLine(y);
            }
            if(z < x && z < y)
            {
                Console.WriteLine(z);
            }

            //Írj programot, mely beolvas két pozitív egész számot, és kiírja a számtani és
            //mértani közepüket!A gyökvonáshoz használd a Math.Sqrt() függvényt!
            Console.ReadKey();
        }
    }
}
