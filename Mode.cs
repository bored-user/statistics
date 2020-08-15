using System.Linq;
using System.Collections.Generic;

namespace Statistics
{
    public class Mode
    {

        public static long Index(long[] nums)
        {
            List<long> mode = new List<long>();
            foreach (int num in nums)
            {
                Mode.FillList(mode, num);
                mode[num]++;
            }

            mode.Sort();
            return mode.Last();
        }

        private static void FillList(List<long> mode, int index)
        {
            for (int i = 0; i <= index; i++)
            {
                if (mode.ElementAtOrDefault(i) == 0)
                    mode.Insert(i, 0);
            }
        }

    }
}
