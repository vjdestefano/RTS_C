using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int[] nums = { 1, 3, 4, 8, 7, 9, 13 };
            List<int> sampleNums = new List<int>();

            sampleNums.AddRange(nums);

            var AboveBelowRTS = new RTS();
            Console.WriteLine(AboveBelowRTS.aboveBelow(sampleNums, 5).ToString());
            Console.WriteLine(AboveBelowRTS.stringRotation("TestString", 3));

        }
    }
}
