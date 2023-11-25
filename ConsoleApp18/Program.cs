using modu_4;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
namespace modu_4
{
    class Operation
    {
        private static bool Check(double a, double b, double c)
        {
            bool z;
            if ((a + b) > c && (a + c) > b && (b + c) > a)
                return true;
            else
                return false;
        }
        static double Count(double a, double b, double c, out int v, out double square)
        {
            square = 0; bool z = Operation.Check(a, b, c);
            if (z == true)
            {
                v = 0; double perim = (a + b + c) / 2;
                square = Math.Sqrt(perim * (perim - a) * (perim - b) * (perim - c));
            }
            else
            {
                v = 1;
            }
            return v;
        }
        static double Count(double d, out double square)
        {
            square = Math.Sqrt(d * d * d * d * 3 / 16); return square;
        }
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Введите тип треугольника: 1 - равносторонний; любая другая цифра - неравносторонний");
                int t = int.Parse(Console.ReadLine());
                if (t == 1)
                {
                    Console.WriteLine("Введите значение строноны равностороннего треугольника");
                    double d = double.Parse(Console.ReadLine()); Count(d, out double square);
                    Console.WriteLine($"Площадь = {square}");
                }
                else
                {
                    Console.WriteLine("Введите a"); double a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите b"); double b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите c"); double c = double.Parse(Console.ReadLine());
                    Count(a, b, c, out int v, out double square); switch (v)
                    {
                        case 0:
                            Console.WriteLine($"Площадь = {square}"); break;
                        case 1:
                            Console.WriteLine($"Введены неверные параметры треугольника"); break;
                    }
                }
            }
        }
    }
}
