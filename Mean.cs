namespace Statistics
{
    public class Mean
    {
        public static double Index(long[] nums)
        {
            return Mean.Sum(nums) / nums.Length;
        }

        private static double Sum(long[] nums)
        {
            long res = 0;
            foreach (long num in nums)
            {
                res += num;
            }

            return res;
        }
    }
}
