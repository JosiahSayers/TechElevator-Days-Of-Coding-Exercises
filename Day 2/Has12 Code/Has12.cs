using System;
using System.Collections.Generic;
using System.Text;

namespace Has12_Code
{
    public class Has
    {
        public bool has12(int[] nums)
        {
            bool has1 = false;
            bool output = false;
            for(int i=0; i<nums.Length; i++)
            {
                if(nums[i] == 1)
                {
                    has1 = true;
                }
                if(has1 == true && nums[i] == 2)
                {
                    output = true;
                }
            }
            return output;
        }
    }
}
