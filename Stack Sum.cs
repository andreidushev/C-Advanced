using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack_and_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(input);
            string command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                var tokens = command.Split();
                var comm = tokens[0].ToLower();

                if (comm == "add")
                {
                    stack.Push(int.Parse(tokens[1]));
                    stack.Push(int.Parse(tokens[2]));
                }
                else if (comm == "remove")
                {
                    var removedNums = int.Parse(tokens[1]);

                    if (stack.Count > removedNums)
                    {
                        for (int i = 0; i < removedNums; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
                command = Console.ReadLine().ToLower();
            }
            var sum = stack.Sum();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
