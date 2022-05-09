using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AlgorithmII.Day01;

namespace AlgorithmII
{
    static class Program
    {
        static void Main(string[] args)
        {
            SearchInRotatedSortedArrayProblem.Run();
            ;
            // Search2DMatrix.Run();
        }


        public static void PrintSequence<T>(this IEnumerable<T> source)
        {
            foreach (var x1 in source)
            {
                Console.Write(x1 + " ");
            }
        }
    }
}