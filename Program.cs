using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace Statistics
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Howdy!\nWhat you'd like to calculate?\n\n0). Order numbers in ascending order\n1). Mean\n2). Median\n3). Mode\n4). Amplitude\n5). Standard deviation\n6). Frequency\n\n> Your choice: ");

            try
            {
                string input = Console.ReadLine();
                string[] range = new string[] { "0", "1", "2", "3", "4", "5", "6" };
                if (!range.Contains(input))
                    throw new IndexOutOfRangeException($"Expecting number in range [{range[0]}..{range.Last()}]. Got '{input}'");

                Console.Write("Enter numbers separated by a comma (e.g 1,2,3,4,5): ");
                long[] nums = Console.ReadLine().Split(',').Select(long.Parse).ToArray();

                if (new Regex(@"\d+(,\d+)*(\.\d*)?").Matches(input).Count < 1)
                    throw new FormatException($"Expecting number list to be in 'N1,N2,N3,N4,Nn' format. Got '{input}'");

                Console.Write(Program.Caller(input, nums));
            }
            catch (Exception exc)
            {
                Console.Write("Either you did something wrong or I did :(\n\nPress 'd' to read the excpetion or anything else to exit: ");
                if (Console.ReadLine() == "d")
                    Console.WriteLine($"{exc.GetType()}: {exc.Message}");

                Environment.Exit(-1);
            }
        }

        private static dynamic Caller(string input, long[] nums)
        {
            switch (input)
            {
                case "0":
                    return Order.ToString(Order.Index(nums));

                case "1":
                    return Mean.Index(nums);

                case "2":
                    return Median.Index(nums);

                case "3":
                    return Mode.Index(nums);

                case "4":
                    return Amplitude.Index(nums);

                case "5":
                    return Standard_Deviation.Index(nums);

                case "6":
                    return Frequency.Index(nums);

                default:
                    return -1;
            }
        }
    }
}
