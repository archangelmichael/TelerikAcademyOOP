﻿namespace _02.IEnumerableFunctions
{
    /* 
     * Task 2
     * Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.
     */
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Extensions
    {

        //Any type can be converted to decimal
        public static decimal Sum<T>(this IEnumerable<T> collection)
        {
            decimal sum = 0;
            foreach (T item in collection) sum += Convert.ToDecimal(item);
            return sum;
        }

        public static decimal Product<T>(this IEnumerable<T> collection)
        {
            decimal product = 1;
            foreach (T item in collection) product *= Convert.ToDecimal(item);
            return product;
        }

        public static T Min<T>(this IEnumerable<T> collection) where T : IComparable
        {
            T min = collection.ElementAt(0);

            foreach (T item in collection)
            {
                if (item.CompareTo(min) < 0) min = item;
            }
            return min;
        }

        public static T Max<T>(this IEnumerable<T> collection) where T : IComparable
        {
            T max = collection.ElementAt(0);

            foreach (T item in collection)
            {
                if (item.CompareTo(max) > 0) max = item;
            }
            return max;
        }

        public static decimal Avg<T>(this IEnumerable<T> collection)
        {
            return collection.Sum<T>() / collection.Count<T>();
        }
    }
}
