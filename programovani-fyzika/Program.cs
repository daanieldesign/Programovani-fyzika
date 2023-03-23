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
            Console.WriteLine("Zadejte volbu z výběru – 1, 2, 3, 4:");
            Console.WriteLine("1 – výpočet průměrné rychlosti auta");
            Console.WriteLine("2 – výpočet volného pádu tělesa");
            Console.WriteLine("3 – výpočet mechanické práce");
            Console.WriteLine("4 – výpočet nejvyšší výšky");
            int volba = char.Parse(Console.ReadLine());
            switch (volba)
            {
                case '1':
                    Console.WriteLine("Zadejte dráhu v metrech (pouze číslo): ");
                    double draha = double.Parse(Console.ReadLine());
                    Console.WriteLine("Zadejte čas v sekundách (pouze číslo): ");
                    double cas = double.Parse(Console.ReadLine());
                    double rychlost = draha / cas;
                    if (rychlost > 30)
                    {
                        Console.WriteLine("Rychlost nemůže být vyšší než 30 m/s.");
                    }
                    else
                    {
                        Console.WriteLine("Výsledek:" + "{0} m/s", rychlost);
                        Console.WriteLine("Výsledek:" + "{0} km/h", rychlost * 3.6);
                    }
                    break;
                case '2':
                    Console.WriteLine("Zadejte čas v sekundách (pouze číslo): ");
                    double t = double.Parse(Console.ReadLine());
                    Console.WriteLine("Zadejte zrychlení (pouze číslo): ");
                    double g = double.Parse(Console.ReadLine());
                    double h = 0.5 * g * Math.Pow(t, 2);
                    Console.WriteLine("Výsledek: " + "{0} cm", h * 100);
                    Console.WriteLine("Výsledek: " + "{0} m", h);
                    break;
                case '3':
                    Console.Write("Zadejte sílu (v Newtonech, pouze číslo): ");
                    double F = Double.Parse(Console.ReadLine());
                    Console.Write("Zadej čas v sekundách (pouze číslo): ");
                    double cas2 = Double.Parse(Console.ReadLine());
                    Console.Write("Zadejte úhel ve stupních (pouze číslo): ");
                    double uhel = Double.Parse(Console.ReadLine());

                    if (uhel > 90)
                    {
                        Console.WriteLine("Úhel nemůže být větší než 90 stupňů.");
                    }
                    else
                    {
                        double prace = F * Math.Cos(uhel * Math.PI / 180) * cas2;
                        Console.WriteLine("Výsledek: " + "{0} J", prace);
                    }
                    break;
                case '4':
                    Console.Write("Zadejte rychlost v jednotce m/s: ");
                    double V = Double.Parse(Console.ReadLine());
                    double maxH = Math.Pow(V, 2) / (2 * 9.81);
                    Console.WriteLine("{0} cm", maxH * 100);
                    Console.WriteLine("{0} m", maxH);
                    break;
                default:
                    Console.WriteLine("Vaše zadaná hodnota není ve výběru. Jste na hlavu?");
                    break;
            }
            Console.ReadKey();
        }
    }
}
