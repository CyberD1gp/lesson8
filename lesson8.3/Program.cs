using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson8._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Random rand = new Random();
            for (int i = 0; i < 1000; i++)
            {
                list.Add(rand.Next(10));
            }
            var dictionary = new Dictionary<int, int>();
            foreach(int e in list)
            {
                if (!dictionary.ContainsKey(e)) dictionary.Add(e, 0);
                dictionary[e]++;
            }

            foreach(KeyValuePair<int,int>e in dictionary)
            {
                Console.WriteLine($"{e.Key,3} встречается{e.Value,10}раз");
            }
            Console.ReadLine();








        }
    }
}
