using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumber.model
{
    public class Palindrome
    {
        public static void CheckAndPrintPalindrome(int number)
        {
            int originalNumber = number;
            int reversedNumber = 0;

            while (number > 0)
            {
                int lastDigit = number % 10;
                reversedNumber = (reversedNumber * 10) + lastDigit;
                number /= 10;
            }
            string resultMessage = (originalNumber == reversedNumber) ? $"{originalNumber} is palindrome number" : $"{originalNumber} not a palindrome number";
            Console.WriteLine(resultMessage);
        }
    }
}
