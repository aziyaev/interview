using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interview
{
    class Program
    {
        static Dictionary<int, int> Duplicates(int[] arr)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (!result.ContainsKey(arr[i]))
                    result.Add(arr[i], 0);
                else
                    result[arr[i]]++;
            }

            foreach(KeyValuePair<int, int> pair in result)
            {
                if(pair.Value == 0)
                {
                    result.Remove(pair.Key);
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            var arr = new int[] { 2, 2, 3, 4, 5, 6, 7, 7, 7, 8, 10 };

            
            var dup_withoutLINQ = Duplicates(arr);

            var dup_withLINQ = arr.GroupBy(x => x).Where(y => y.Count() > 1).Select(x => new { Num = x.Key, Count = x.Count()});

            Console.WriteLine("Подсчет с LINQ:");
            foreach(var item in dup_withLINQ)
            {
                Console.WriteLine($"Значение: {item.Num}    Кол-во: {item.Count - 1}");
            }

            Console.WriteLine("Подсчет без LINQ:");
            foreach (KeyValuePair<int, int> pair in dup_withoutLINQ)
            {
                Console.WriteLine($"Значение: {pair.Key}    Кол-во: {pair.Value}");
            }
        }


    }
}
