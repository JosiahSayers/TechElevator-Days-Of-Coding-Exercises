using System;

namespace Day_13
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int[] MakeEnds(int[] nums)
        {
            int[] output = new int[2];

            output[0] = nums[0];
            output[1] = nums[nums.Length - 1];

            return output;
        }
    }
}
