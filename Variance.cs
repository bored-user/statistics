using System;

namespace Statistics
{
    public class Variance
    {
        public static double Index(long[] nums)
        {
            double mean = Mean.Index(nums);
            double res = 0;

            foreach (long num in nums)
            {
                res += Math.Pow(mean - num, 2);
            }

            return res / (double)nums.Length;
        }
    }
}
