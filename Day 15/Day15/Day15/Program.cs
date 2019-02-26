using System;

namespace Day15
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static bool Has23(int[] nums)
        {
            return nums[0] == 2 || nums[1] == 2 || nums[0] == 3 || nums[1] == 3 ? true : false;
        }
    }
}
