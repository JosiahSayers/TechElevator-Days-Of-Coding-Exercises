using System;
namespace Only14
{
    public class Only
    {
        public bool Only14(int[] nums)
        {
            foreach(int num in nums)
            {
                bool oneOrFour = false;
                if(num == 1 || num == 4)
                {
                    oneOrFour = true;
                }
                if (oneOrFour == false)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
