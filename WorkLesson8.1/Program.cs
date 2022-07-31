using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkLesson8._1
{
    internal class Program
    {
        public static List<int> list = new List<int>();
        static void Main(string[] args)
        {

            Fill(list);

            Delete(list);

            //list.Sort();

            Print(list);
            
            //Console.WriteLine($"\n\ncount:{list.Count}");

            Console.ReadKey();

        }
        static void Fill(List<int> vs)
        {
            

            Random rand = new Random();

            for (int i = 0; i < 100; i++)
            {
                vs.Add(rand.Next(100));
            }
                       
        }
        
        static void Delete(List<int> vs)
        {
                       
            for (int i = 0; i < 100; i++)
            {
                if (i < 50 && i > 25)
                {
                    vs.RemoveAll(x => x == i);
                }
            }
         
        }
    
        static void Print(List<int> vss)
        {           
                foreach (int v in vss) Console.Write($"{v} ");
                     

        }
        




       
    }
}
