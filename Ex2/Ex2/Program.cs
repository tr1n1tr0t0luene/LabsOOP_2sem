using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    public delegate bool FilterDelegate(int number);

    class Program
    {
        static int[] FilterArrayWithWhere(int[] array, FilterDelegate filterDelegate)
        {
            return array.Where(number => filterDelegate(number)).ToArray();
        }

        static int[] FilterArrayWithCustom(int[] array, FilterDelegate filterDelegate)
        {
            var list = new System.Collections.Generic.List<int>();
            foreach (var number in array)
            {
                if (filterDelegate(number))
                {
                    list.Add(number);
                }
            }
            return list.ToArray();
        }

        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.Write("Введіть число k: ");
            int k = int.Parse(Console.ReadLine());
            FilterDelegate filterDelegate = number => number % k == 0;
            Console.WriteLine("Фільтрація масиву з використанням методу Where:");
            Console.WriteLine(string.Join(", ", FilterArrayWithWhere(array, filterDelegate)));
            Console.WriteLine("Фільтрація масиву з використанням власної реалізації:");
            Console.WriteLine(string.Join(", ", FilterArrayWithCustom(array, filterDelegate)));
        }
    }

}
