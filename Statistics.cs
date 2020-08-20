using System.Linq;
using System.Collections.Generic;
using System;

public class Statistics
{
    public static long Amplitude(long[] nums)
    {
        return nums.Max() - nums.Min();
    }

    public static string Frequency(long[] nums)
    {
        nums = Statistics.Order(nums);
        Dictionary<long, long> frequency = new Dictionary<long, long>();
        string res = "";
        long last = 0;

        foreach (int num in nums)
        {
            if (!frequency.ContainsKey(num))
                frequency[num] = 0;

            frequency[num]++;
        }

        foreach (var (key, val) in frequency)
        {
            res += $"Number {key}:\n\n";
            res += $"Absolute frequency: {val}\n";
            res += $"Relative frequency: {(double)val / (double)nums.Length}\n";
            res += $"Cumulative frequency: {val + last}\n\n\n";

            last = val;
        }

        return res.Substring(0, res.Length - 3);
    }

    public static double Mean(long[] nums)
    {
        return Statistics.Reduce(nums) / nums.Length;
    }

    private static double Reduce(long[] nums)
    {
        long res = 0;
        foreach (long num in nums)
        {
            res += num;
        }

        return res;
    }

    public static double Median(long[] nums)
    {
        nums = Statistics.Order(nums);
        int half = nums.Length / 2;

        return nums.Length % 2.0 != 0 ? nums[half] : (nums[half] + nums[half - 1]) / 2.0;
    }

    public static dynamic Mode(long[] nums)
    {
        nums = Statistics.Order(nums);
        long? last = 0,
            mode = null;

        foreach (long num in nums)
        {
            if (num == last)
                mode = num;

            last = num;
        }

        if (mode == null)
            return "There's no mode in the given set";
        else
            return mode;
    }

    public static long[] Order(long[] nums)
    {
        Array.Sort(nums);
        return nums;
    }

    public static string ToString(long[] nums)
    {
        string res = "";
        foreach (int num in nums)
            res += num.ToString() + ',';

        return res.Substring(0, res.Length - 1);
    }

    public static double StandardDeviation(long[] nums)
    {
        return Math.Sqrt(Statistics.Variance(nums));
    }

    public static double StandardError(long[] nums)
    {
        return Statistics.StandardDeviation(nums) / Math.Sqrt((double)nums.Length);
    }

    public static double Variance(long[] nums)
    {
        double mean = Statistics.Mean(nums);
        double res = 0;

        foreach (long num in nums)
        {
            res += Math.Pow(mean - num, 2);
        }

        return res / (double)nums.Length;
    }
}
