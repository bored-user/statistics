using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace Statistics
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Howdy!\nWhat you'd like to calculate?\n\n0). Order numbers in ascending order\n1). Mean\n2). Median\n3). Mode\n4). Amplitude\n5). Standard deviation\n\n> Your choice: ");

            try
            {
                string input = Console.ReadLine();
                if (!(input == "0" || input == "1" || input == "2" || input == "3" || input == "4" || input == "5"))
                    throw new IndexOutOfRangeException($"Expecting number in range [0..5]. Got '{input}'");

                Console.Write("Enter numbers separated by a comma (e.g 1,2,3,4,5): ");
                long[] nums = Console.ReadLine().Split(',').Select(long.Parse).ToArray();

                if (new Regex(@"\d+(,\d+)*(\.\d*)?").Matches(input).Count < 1)
                    throw new FormatException($"Expecting number list to be in 'N1,N2,N3,N4,Nn' format. Got '{input}'");

                switch (input)
                {
                    case "0":
                        Console.Write(Order.Index(nums));
                        break;

                    case "1":
                        Console.Write(Mean.Index(nums));
                        break;

                    case "2":
                        Median.Index(nums);
                        break;

                    case "3":
                        Console.Write(Mode.Index(nums));
                        break;

                    case "4":
                        Console.Write(Amplitude.Index(nums));
                        break;

                    case "5":
                        Console.Write(Standard_Deviation.Index(nums));
                        break;
                }
            }
            catch (Exception exc)
            {
                Console.Write("Either you did something wrong or I did :(\n\nPress 'd' to read the excpetion or anything else to exit: ");
                if (Console.ReadLine() == "d")
                    Console.WriteLine($"{exc.GetType()}: {exc.Message}");

                Environment.Exit(-1);
            }
        }
    }
}
