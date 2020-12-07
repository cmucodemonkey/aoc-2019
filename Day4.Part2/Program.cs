using System;
using System.Collections.Generic;
using System.Linq;

namespace Day4.Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> passwords = new List<int>();
            int min = 156218;
            int max = 652527;

            foreach (int number in Enumerable.Range(min, max - min))
            {
                if (HasExactlyTwoRepeatingDigits(number) && DigitsIncreaseOrRepeat(number))
                    passwords.Add(number);
            }

            Console.WriteLine(passwords.Count);
        }

        private static bool HasExactlyTwoRepeatingDigits(int number)
        {
            string temp = number.ToString();

            for (int i = 0; i < temp.Length - 2; i++)
            {
                if ((i - 1 < 0 || temp[i - 1] != temp[i]) && temp[i] == temp[i + 1] && (i + 2 >= temp.Length || temp[i + 1] != temp[i + 2]))
                {
                    return true;
                }
            }

            return false;
        }

        private static bool DigitsIncreaseOrRepeat(int number)
        {
            int[] temp = number.ToString().ToCharArray().Select(Convert.ToInt32).ToArray();

            for (int i = 0; i < temp.Length - 1; i++)
            {
                if (temp[i] > temp[i + 1])
                    return false;
            }

            return true;
        }
    }
}
