using System;
using System.Collections.Generic;
using System.Linq;

namespace Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Func<int, int> add = n => n + 1;
            Func<int, int> multiply = n => n * 2;
            Func<int, int> subtract = n => n - 1;
            Action<int[]> print = n => Console.WriteLine(string.Join(" ",n));

            string command = Console.ReadLine();

            while (command != "end")
            {
                switch (command)
                {
                    case "add":
                        nums = nums.Select(n => add(n)).ToArray();
                        break;
                    case "multiply":
                        nums = nums.Select(n => multiply(n)).ToArray();
                        break;
                    case "subtract":
                        nums = nums.Select(n => subtract(n)).ToArray();
                        break;
                    case "print":
                        print(nums);
                        break;

                }
                command = Console.ReadLine();
            }
        }
    }
}
