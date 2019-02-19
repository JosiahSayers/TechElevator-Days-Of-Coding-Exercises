using System;
using System.Collections.Generic;
using System.Text;

namespace Day_9
{
    public class ArraySearch
    {
        public bool No14(int[] arr)
        {
            bool output = true;
            List<int> list = new List<int>();
            list.AddRange(arr);

            if(list.Contains(1) || list.Contains(4))
            {
                output = false;
            }

            return output;
        }
    }
}
