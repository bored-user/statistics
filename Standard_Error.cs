using System;

namespace Statistics
{
    public class Standard_Error
    {
        public static double Index(long[] nums)
        {
            return Standard_Deviation.Index(nums) / Math.Sqrt((double)nums.Length);
        }
    }
}
