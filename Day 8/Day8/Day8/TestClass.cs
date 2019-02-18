using System;
using System.Collections.Generic;
using System.Text;

namespace Day8
{
    public class TestClass
    {
        public bool No23(int[] nums)
        {
            List<int> numList = new List<int>();
            numList.AddRange(nums);
            if (numList.Contains(2) || numList.Contains(3))
            {
                return false;
            }
            else return true;
        }
    }
}
