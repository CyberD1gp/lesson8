using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson8._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Queue<int> vs = new Queue<int>();

            //vs.Enqueue(1);
            //vs.Enqueue(2);
            //vs.Enqueue(3);
            //vs.Enqueue(4);                
            //vs.Enqueue(5);

            //foreach (int e in vs) Console.WriteLine($"{e} ");

            //Console.WriteLine($"queue.Dequeue() = {vs.Dequeue()}");
            //foreach (int e in vs) Console.WriteLine($"{e} ");

            //Console.WriteLine($"queue.Peek() = {vs.Peek()}");
            //foreach (int e in vs) Console.WriteLine($"{e} ");

            //Console.ReadKey();


                //Stack<int> vs = new Stack<int>();

                //vs.Push(1);
                //vs.Push(2);
                //vs.Push(3);
                //vs.Push(4);
                //vs.Push(5);

                //foreach (int e in vs) Console.WriteLine($"{e} ");

                //Console.WriteLine($"stack.Pop() = {vs.Pop()}");
                //foreach(int e in vs) Console.WriteLine($"{e} ");

                //Console.WriteLine($"stack.Peek() = {vs.Peek()}");
                //foreach (int e in vs) Console.WriteLine($"{e} ");

                //Console.ReadKey();

            HashSet<int> set1 = new HashSet<int>(new int [] {1, 4 ,5 , 3, 2, 6, 5 , 5, 3, 2, 1, 1,} );
            Console.WriteLine($"set 1");
            foreach (int e in set1) Console.WriteLine($"{e} ");
            Console.WriteLine($"\n\nэлемент '3' Присутсвует в set 1: {set1.Contains(3)}");
            Console.WriteLine($"элемент '21' Присутсвует в set 1: {set1.Contains(21)}");

            HashSet<int> set2 = new HashSet<int>() { 1, 2, 6, 3, 5, 5, 5, 5, 5, 2, 1, 1, 6, 6, 3, 4 };
            Console.WriteLine($"\nset 2");
            foreach (int e in set2) Console.WriteLine($"{e} ");

            set1.UnionWith(set2);
            Console.WriteLine($"\nset 1 после UnionWith()");
            foreach (int e in set1) Console.WriteLine($"{e} ");

            set1.ExceptWith(new int[] { 1, 6 });
            Console.WriteLine($"set 1 после ExpectWith()");
            foreach (int e in set1) Console.WriteLine($"{e} ");








            Console.ReadKey();


        }
    }
}
