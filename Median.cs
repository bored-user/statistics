namespace Statistics
{
    public class Median
    {
        public static double Index(long[] nums)
        {
            nums = Order.Index(nums);
            int half = nums.Length / 2;

            return nums.Length % 2.0 != 0 ? nums[half] : (nums[half] + nums[half - 1]) / 2.0;
        }
    }
}
