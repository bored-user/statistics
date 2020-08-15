using System;
using System.Linq;

namespace Statistics
{
    public class Order
    {
        public static string Index(long[] nums)
        {
            Array.Sort(nums);

            return Order.ToString(nums);
        }

        private static string ToString(long[] nums)
        {
            string res = "";
            foreach (int num in nums)
                res += num.ToString() + ',';

            return res.Substring(0, res.Length - 1);
        }
    }
}
