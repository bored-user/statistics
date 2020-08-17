using System;

namespace Statistics
{
    public class Standard_Deviation
    {
        public static double Index(long[] nums)
        {
            return Math.Sqrt(Variance.Index(nums));
        }
    }
}
