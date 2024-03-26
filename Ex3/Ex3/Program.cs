using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    public delegate double SeriesDelegate(int n);

    class Program
    {
        public static double SumSeries(SeriesDelegate seriesDelegate, double epsilon)
        {
            double sum = 0;
            int n = 1;
            double term = seriesDelegate(n);
            while (Math.Abs(term) > epsilon)
            {
                sum += term;
                n++;
                term = seriesDelegate(n);
            }
            return sum;
        }

        public static double Series1(int n)
        {
            return 1.0 / Math.Pow(2, n - 1);
        }

        public static double Series2(int n)
        {
            return 1.0 / Factorial(n);
        }

        public static double Series3(int n)
        {
            return Math.Pow(-1, n + 1) / Math.Pow(2, n - 1);
        }

        public static int Factorial(int n)
        {
            if (n <= 1) return 1;
            else return n * Factorial(n - 1);
        }

        static void Main(string[] args)
        {
            double epsilon = 0.1;
            SeriesDelegate series1 = Series1;
            SeriesDelegate series2 = Series2;
            SeriesDelegate series3 = Series3;
            double sum1 = SumSeries(series1, epsilon);
            double sum2 = SumSeries(series2, epsilon);
            double sum3 = SumSeries(series3, epsilon);
            Console.WriteLine("Сума першого ряду: {0}", sum1);
            Console.WriteLine("Сума другого ряду: {0}", sum2);
            Console.WriteLine("Сума третього ряду: {0}", sum3);
        }
    }

}
