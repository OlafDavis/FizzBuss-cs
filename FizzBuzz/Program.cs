using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {

            // To try the different parts / versions, uncomment one of the lines below:

            // Part 1:
            Part1.FizzBuzz();

            // Part 2:
            //Part2.FizzBuzzBang();
            //Part2.FizzBuzzBangBong();
            //Part2.FizzFezzBuzzBangBong();
            //Part2.FizzFezzBuzzBangBongLazily();
            //Part2.FizzFezzBuzzBangBongReverse();
            //Part2.FizzBuzzBangGoesTheDictionary();    // This version uses a dictionary as another example of what you can do with that

            // Extensions:
            //StretchGoals.FizzBuzzBangViaEnumerable();
            //StretchGoals.FizzBuzzBangOneLiner();

            // With limit and options (uncommend all four lines below together):
            //var limit = PromptForLimit();
            //var enabledRules = CalculateEnabledRules(args);
            //Console.WriteLine("Fizzing with rules: " + string.Join(", ", enabledRules));
            //StretchGoals.FizzFezzBuzzBangBongReverseWithOptions(limit, enabledRules);

            Console.ReadLine();
        }

        private static int PromptForLimit()
        {
            int limit;

            while (true)
            {
                Console.Write("Please enter the number you'd like to FizzBuzz up to: ");
                string limitText = Console.ReadLine();

                if (int.TryParse(limitText, out limit))
                {
                    break;
                }
            }
            return limit;
        }

        private static int[] CalculateEnabledRules(string[] commandLineArguments)
        {
            return commandLineArguments.Length == 0
              ? new[] { 3, 5, 7, 11, 13, 17 }
              : commandLineArguments.Select(int.Parse).ToArray();
        }
    }
}