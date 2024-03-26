using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    internal class Program
    {
        private static ConsoleColor stdColor;
        private delegate double FunctionDelegate(double x);
        private static FunctionDelegate[] funcArray = { SqrtAbs, Cube, AddThreePointFive };

        private static void Main(string[] args)
        {
            stdColor = Console.ForegroundColor;
            PrintUsage();
            while (true)
            {
                try
                {
                    while (true)
                    {
                        string[] strArray = Console.ReadLine().Trim().Split(new char[0]);
                        Console.WriteLine(funcArray[int.Parse(strArray[0])](double.Parse(strArray[1])));
                        break;
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine("Сталася помилка {0}", exception.Message);
                    Console.WriteLine("Натисніть будь-яку клавішу для остаточного виходу");
                    Console.ReadKey();
                    return;
                }
            }
        }

        private static double SqrtAbs(double x)
        {
            return Math.Sqrt(Math.Abs(x));
        }

        private static double Cube(double x)
        {
            return x * x * x;
        }

        private static double AddThreePointFive(double x)
        {
            return x + 3.5;
        }

        private static void PrintUsage()
        {
            Console.WriteLine("Вводьте рядки послідовно один за одним.");
            Console.Write("Поки вони матимуть вигляд");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" 0 x ");
            Console.ForegroundColor = stdColor;
            Console.Write("чи");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" 1 x ");
            Console.ForegroundColor = stdColor;
            Console.Write("чи");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" 2 x ");
            Console.ForegroundColor = stdColor;
            Console.WriteLine("(тобто, цифра від 0 до 2, а після неї запис конкретного дійсного числа),");
            Console.WriteLine("програма обчислюватиме одну з трьох функцій");
            Console.WriteLine("\t0 -- sqrt(abs(x))");
            Console.WriteLine("\t1 -- x^3 (інакше кажучи, x*x*x)");
            Console.WriteLine("\t2 -- x + {0}", 3.5);
            Console.WriteLine("(згідно цифри на початку) і виводитиме результат.");
            Console.WriteLine("\nЯкщо вхідний рядок не задовольнятиме цей формат, програма завершить роботу.\n");
        }
    }

}
