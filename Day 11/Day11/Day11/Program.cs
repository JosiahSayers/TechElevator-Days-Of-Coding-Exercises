using System;

namespace Day11
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int[] MakeMiddle(int[] nums)
        {
            return new int[] { nums[(nums.Length / 2) - 1], nums[nums.Length / 2] };
        }
    }
}
