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
            long last = 0;

            foreach (int num in nums)
            {
                if (!frequency.ContainsKey(num))
                    frequency[num] = 0;

                frequency[num]++;
            }

            foreach(var (key, val) in frequency)
            {
                res += $"Number {key}:\n\n";
                res += $"Absolute frequency: {val}\n";
                res += $"Relative frequency: {(double)val / (double)nums.Length}\n";
                res += $"Cumulative frequency: {val + last}\n\n\n";
                
                last = val;
            }

            return res.Substring(0, res.Length - 3);
        }
    }
}
