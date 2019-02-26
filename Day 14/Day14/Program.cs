using System;

namespace Day14
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static bool LessBy10(int a, int b, int c)
        {
            bool output = false;

            if(Math.Abs(a-c) >= 10)
            {
                output = true;
            }
            else if(Math.Abs(a-b) >= 10)
            {
                output = true;
            }
            else if(Math.Abs(b-c) >= 10)
            {
                output = true;
            }

            return output;
        }
    }
}
