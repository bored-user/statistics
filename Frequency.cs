using System.Collections.Generic;

namespace Statistics
{
    public class Frequency
    {
        public static string Index(long[] nums)
        {
            nums = Order.Index(nums);
            Dictionary<long, long> frequency = new Dictionary<long, long>();
            string res = "";

            foreach (int num in nums)
            {
                if (!frequency.ContainsKey(num))
                    frequency[num] = 0;

                frequency[num]++;
            }

            foreach(var (key, val) in frequency)
            {
                res += $"Number {key} appeared {val} ";
                res += val > 1 ? "times.\n" : "time.\n";
            }

            return res;
        }
    }
}
