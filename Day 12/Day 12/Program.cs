using System;

namespace Day_12
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int[] MakeLast(int[] nums)
        {
            int[] output = new int[nums.Length * 2];

            output[output.Length - 1] = nums[nums.Length - 1];

            return output;
        }
    }
}
