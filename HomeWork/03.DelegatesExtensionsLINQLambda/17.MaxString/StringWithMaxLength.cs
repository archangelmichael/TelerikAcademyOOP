using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaxString
{
    /* 
     * Task 17
     * Write a program to return the string with maximum length from an array of strings. Use LINQ.
     */

    class StringWithMaxLength
    {
        public static int longestString = 0;
        private static string[] GenerateStrings()
        {
            Random generator = new Random();
            string[] array = new string[generator.Next(20, 31)];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new string((char)generator.Next(65, 94), generator.Next(1, 50));
            }
            return array;
        }
        private static bool GetLongerStr(string inputString)
        {
            if (inputString.Length > longestString)
            {
                longestString = inputString.Length;
                return true;
            }
            return false;
        }

        static void Main()
        {
            string[] stringArray = GenerateStrings();

            string answerWithExtension = stringArray.Aggregate((max, cur) => max.Length > cur.Length ? max : cur);
            Console.WriteLine(answerWithExtension);
            

            var answerWithQuery = from currentString in stringArray
                                  where GetLongerStr(currentString)
                                  select currentString;
            Console.WriteLine(answerWithQuery.Last());
        }
    }
}
