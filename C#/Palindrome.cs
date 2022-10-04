using System;
using System.Linq;

namespace palindrome
{
    class Program
    {
        public static bool checkPalindrome(string mainString)
        {
            string firstHalf = mainString.Substring(0, mainString.Length / 2);
            char[] arr = mainString.ToCharArray();

            Array.Reverse(arr);

            string temp = new string(arr);
            string secondHalf = temp.Substring(0, temp.Length / 2);

            return firstHalf.Equals(secondHalf);
        }
        static void Main(string[] args)
        {
            bool palindrome = checkPalindrome("12321");
            Console.WriteLine(palindrome);
        }
    }
}
