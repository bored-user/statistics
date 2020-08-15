using System.Linq;

namespace Statistics
{
    public class Amplitude
    {
        public static long Index(long[] nums)
        {
            return nums.Max() - nums.Min();
        }
    }
}
