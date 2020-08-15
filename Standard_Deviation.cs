using System;

namespace Statistics
{
    public class Standard_Deviation
    {
        public static double Index(long[] nums)
        {
            double mean = Mean.Index(nums);
            double res = 0;

            foreach (long num in nums)
            {
                Convert.ToDouble(mean - num);
                res += Math.Pow(mean - num, 2);
            }

            return Math.Sqrt(res / nums.Length);
        }
    }
}
