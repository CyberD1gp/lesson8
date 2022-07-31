using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkLesson8._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>();
            while (true)
            {

                Console.Write($"Введите число ");
                int number = Convert.ToInt32(Console.ReadLine());
                if (!set.Contains(number))
                {
                    set.Add(number);
                    Console.WriteLine($"Число {number} сохранено");
                }
                else 
                {
                    Console.WriteLine($"Число уже введено");
                }

                Console.WriteLine($"Для вывода всех чисел нажмите (d)");
                if(Console.ReadLine() == "d")
                {
                    foreach (int i in set) Console.WriteLine($"{i}");
                }
                
            }
                   
                

            
        }
    }
}
