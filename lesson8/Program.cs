using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> map = new Dictionary<string, string>();
            map.Add("учитель","teacher");
            map.Add("работа","work");
            map.Add("дом","house");
            map.Add("машина","car");
            map.Add("проверка","check");
            Console.WriteLine("map");

            foreach (KeyValuePair<string, string> e in map) Console.WriteLine($"{e} ");

            Console.WriteLine($"\n\nmap[\"учитель\"] = {map["учитель"]}");

            Console.WriteLine($"\nmap.Keys");
            foreach (var e in map.Keys) Console.WriteLine($"{e}"  );

            Console.WriteLine($"\nmap.Values");
            foreach (var e in map.Values) Console.WriteLine($"{e} ");

            Console.WriteLine("\nУдаление");
            map.Remove("учитель");
            foreach (KeyValuePair<string, string> e in map) Console.WriteLine($"{e} ");

            Console.WriteLine($"кол-во элементов в коллекции {map.Count}"); 
            
            map.Clear();
            Console.WriteLine("map.Clear выполнен");

            Console.WriteLine($"кол-во элементов в коллекции {map.Count}");


            Console.ReadKey();



        }
    }
}
