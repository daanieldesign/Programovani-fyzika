using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programovani_fyzika
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte volbu a, b, c, d:");
            Console.WriteLine("a – výpočet průměrné rychlosti auta, b – výpočet volného pádu tělesa, c – výpočet mechanické práce, d – výpočet nejvyšší výšky");
            char volba = char.Parse(Console.ReadLine());
            switch (volba)
            {
                case 'a':
                    Console.WriteLine("Zadej dráhu v metrech: ");
                    double draha = double.Parse(Console.ReadLine());
                    Console.WriteLine("Zadejte čas v sekundách: ");
                    double cas = double.Parse(Console.ReadLine());
                    double rychlost = draha / cas;
                    if (rychlost > 30)
                    {
                        Console.WriteLine("Rychlost nemůže být vyšší než 30 m/s");
                    }
                    else
                    {
                        Console.WriteLine("Výsledek:" + "{0} m/s", rychlost);
                        Console.WriteLine("Výsledek:" + "{0} km/h", rychlost * 3.6);
                    }
                    break;
                case 'b':
                    Console.WriteLine("Zadejte čas v sekundách: ");
                    double t = double.Parse(Console.ReadLine());
                    Console.WriteLine("Zadejte zrychlení: ");
                    double g = double.Parse(Console.ReadLine());
                    double h = 0.5 * g * Math.Pow(t, 2);
                    Console.WriteLine("Výsledek: " + "{0} cm", h * 100);
                    Console.WriteLine("Výsledek: " + "{0} m", h);
                    break;
                case 'c':
                    Console.Write("Zadejte sílu v Newtonech: ");
                    double F = Double.Parse(Console.ReadLine());
                    Console.Write("Zadej čas v sekundách: ");
                    double time = Double.Parse(Console.ReadLine());
                    Console.Write("Zadejte úhel ve stupních: ");
                    double uhel = Double.Parse(Console.ReadLine());

                    if (uhel > 90)
                    {
                        Console.WriteLine("Error: úhel nemůže být větší než 90 stupňů");
                    }
                    else
                    {
                        double prace = F * Math.Cos(uhel * Math.PI / 180) * time;
                        Console.WriteLine("Výsledek: " + "{0} J", prace);
                    }
                    break;
                case 'd':
                    Console.Write("Zadejte rychlost v jednotce m/s: ");
                    double V = Double.Parse(Console.ReadLine());
                    double maxH = Math.Pow(V, 2) / (2 * 9.81);
                    Console.WriteLine("{0} cm", maxH * 100);
                    Console.WriteLine("{0} m", maxH);
                    break;
                default:
                    Console.WriteLine("V rozsahu není volba.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
