using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    public class FizzArray
    {
        public int[] FizzArray3(int start, int end)
        {
            List<int> output = new List<int>();

            for(int i=start; i<end; i++)
            {
                output.Add(i);
            }

            return output.ToArray();
        }
    }
}
