using System;
using System.Collections.Generic;
using System.Text;

namespace Day_3
{
    public class Ticket
    {
        public int GreenTicket(int a, int b, int c)
        {
            int output = 0;
            if (a == b)
            {
                output += 10;
            }
            if (b == c)
            {
                output += 10;
            }
            if (a == c)
            {
                if (output < 20)
                {
                    output += 10;
                }
            }
            return output;
        }
    }
}
