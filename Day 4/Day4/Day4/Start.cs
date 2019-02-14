using System;
using System.Collections.Generic;
using System.Text;

namespace Day4
{
    public class Start
    {
        public int Start1(int[] a, int[] b)
        {
            int output = 0;
            if (a.Length > 0)
            {
                if (a[0] == 1)
                {
                    output++;
                }
            }

            if (b.Length > 0)
            {
                if (b[0] == 1)
                {
                    output++;
                }
            }
            return output;
        }
    }
}
