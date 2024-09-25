using PalindromeNumber.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number to check if it is palindrome ");
            int inputNumber = int.Parse(Console.ReadLine());
            Palindrome.CheckAndPrintPalindrome(inputNumber);
            Console.ReadKey();
        }
    }
}
