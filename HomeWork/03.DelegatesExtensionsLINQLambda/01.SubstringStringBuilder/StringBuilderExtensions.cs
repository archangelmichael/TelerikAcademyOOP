namespace _01.SubstringStringBuilder
{
    using System;
    using System.Text;

    /*
     * Task 1
     * Implement an extension method Substring(int index, int length) for the class StringBuilder
     * that returns new StringBuilder and has the same functionality as Substring in the class String.
     */

    public static class StringBuilderExtensions
    {
        //both start and length
        public static StringBuilder Substring(this StringBuilder input, int startIndex, int length)
        {
            if (input.Length <= startIndex)
                throw new IndexOutOfRangeException("Start index larger than the length of input string.");
            if (input.Length < startIndex + length)
                throw new IndexOutOfRangeException("The length of the substring exceeds the characters of the StringBuilder after the start index.");
            return new StringBuilder(input.ToString().Substring(startIndex, length));
        }

        //only startIndex
        public static StringBuilder Substring(this StringBuilder input, int startIndex)
        {
            if (startIndex >= input.Length )
                throw new IndexOutOfRangeException("Start index larger than the length of input string.");
            return new StringBuilder(input.ToString().Substring(startIndex));
        }
        static void Main()
        {
            StringBuilder input = new StringBuilder();
            input.Append("This is a program to Test Method Extensions!");

            StringBuilder result1 = input.Substring(8);
            StringBuilder result2 = input.Substring(21, 23);

            Console.WriteLine(input);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }
    }
}
