namespace DivisibleBy3And7
{
    /*
     * Task 6
     * Write a program that prints from given array of integers 
     * all numbers that are divisible by 7 and 3. 
     * Use the built-in extension methods and lambda expressions. 
     * Rewrite the same with LINQ.
     */ 
    using System;
    using System.Linq;

    class GetNumbersFromArray
    {
        static void Main()
        {
            int[] arrayOfIntegers = new int[]
            {
                8400,4,5,3,654,35,54,23,123,3,4366,7,210,12,21,70,78,564,840,5,454
            };
            Console.WriteLine("With lambda expression"); 
            var numbersDivisibleBy7And3WithLambda = arrayOfIntegers.Where(x => x%35 == 0);
            foreach (var num in numbersDivisibleBy7And3WithLambda)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("With LINQ"); 
            var numbersDivisibleBy35 =
                from number in arrayOfIntegers
                where number % 35 == 0
                select number;
            foreach (var num in numbersDivisibleBy7And3WithLambda)
            {
                Console.WriteLine(num);
            }
        }
    }
}
