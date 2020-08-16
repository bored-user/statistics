using System.Linq;
using System.Collections.Generic;

namespace Statistics
{
    public class Mode
    {

        public static dynamic Index(long[] nums)
        {
            nums = Order.Index(nums);
            long? last = 0,
                mode = null;

            foreach(long num in nums)
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
    }
}
