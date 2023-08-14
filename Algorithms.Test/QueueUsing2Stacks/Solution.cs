using System;
using System.Collections.Generic;

namespace Algorithms.Test.QueueUsing2Stacks
{
    public class Solution
    {
        private static Stack<int> stackNewestOnTop = new Stack<int>();
        private static Stack<int> stackOldestOnTop = new Stack<int>();

        public static void Main2(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string query = Console.ReadLine();
                int type = int.Parse($"{query[0]}");

                switch (type)
                {
                    case 1:
                        int value = int.Parse(query.Split(' ')[1]);
                        Enqueue(value);
                        break;
                    case 2:
                        Dequeue();
                        break;
                    case 3:
                        Peek(); // Print
                        break;
                }
            }
        }

        private static void Enqueue(int newValue)
        {
            stackNewestOnTop.Push(newValue);
        }

        private static void Dequeue()
        {
            PrepOldest();
            stackOldestOnTop.Pop();
        }

        private static void Peek()
        {
            PrepOldest();
            Console.WriteLine($"{stackOldestOnTop.Peek()}");
        }

        private static void PrepOldest()
        {
            // Lazy Load
            if (stackOldestOnTop.Count == 0)
                while(stackNewestOnTop.Count > 0)
                    stackOldestOnTop.Push(stackNewestOnTop.Pop());
        }
    }
}
