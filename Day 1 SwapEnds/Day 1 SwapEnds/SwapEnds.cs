using System;
using System.Collections.Generic;
using System.Text;

namespace Day_1_SwapEnds
{
    public class SwapEnd
    {
        public int[] SwapEnds(int[] arr)
        {
            int[] output = arr;
            int temp = output[output.Length - 1];
            output[output.Length-1] = output[0];
            output[0] = temp;

            return output;
        }
    }
}
