using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkLesson8._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> people = new Dictionary<int , string>();
            while (true)
            {
                Console.WriteLine($"Введите номер телефона :");
                int tele = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Введите фио:");
                string pep = Convert.ToString(Console.ReadLine());

                people.Add(tele, pep);


                foreach (KeyValuePair<int, string> e in people) Console.WriteLine($"{e}");

                Console.WriteLine($"поиск по номеру телефона:");
                int tryes = Convert.ToInt32(Console.ReadLine());

                if (people.TryGetValue(tryes, out pep))
                {
                    Console.WriteLine($"{pep}");
                }
                else
                {
                    Console.WriteLine($"пользователь с таким телефоном не найден");
                }
                Console.WriteLine($"для выхода нажмите (в), для продолжение нажмите Enter:");
                if(Console.ReadLine() == "в")
                {
                    break;
                }
                

            }           

        }
    }
}
