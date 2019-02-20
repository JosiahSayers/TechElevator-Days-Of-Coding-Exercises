using System;
using System.Collections.Generic;
using System.Text;

namespace Day_10
{
    public class Day10
    {
        public bool More14(int[] nums)
        {
            int numOnes = 0;
            int numFours = 0;

            foreach(int num in nums)
            {
                if(num == 1)
                {
                    numOnes++;
                }
                else if(num == 4)
                {
                    numFours++;
                }
            }

            return numOnes > numFours ? true : false;
        }
    }
}
