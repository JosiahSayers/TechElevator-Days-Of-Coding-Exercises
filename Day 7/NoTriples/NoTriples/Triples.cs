using System;
namespace Day7
{
    public class Triples
    {
        public bool NoTriples(int[] nums)
        {
            bool output = true;
            if(nums.Length > 2)
            {
                for(int i=2; i<nums.Length; i++)
                {
                    if(nums[i] == nums[i-1] && nums[i] == nums[i-2])
                    {
                        output = false;
                    }
                }
            }
            return output;
        }
    }
}
