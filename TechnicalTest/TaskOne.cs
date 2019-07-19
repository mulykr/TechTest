using System;

namespace TechnicalTest
{
    public class TaskOne
    {
        public static string ReverseString(string value)
        {
            // We can also go through loop assigning values
            var charArray = value.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static bool IsPalindrome(string value)
        {
            if (value.Length == 0)
            {
                return true;
            }
            // Can just reverse and then compare with original string
            var valueToCheck = value.ToLower();
            var length = value.Length;
            for (var i = 0; i < length / 2; i++)
            {
                var isPalindrome = valueToCheck[i] == valueToCheck[length - i - 1];
                if (!isPalindrome)
                {
                    return false;
                }
            }

            return true;
        }

        public static int SumOfNumbersFromOne(int value)
        {
            var sum = 0;
            for (int i = 1; i <= value; i++)
            {
                sum += value;
            }

            return sum;
        }
    }
}
