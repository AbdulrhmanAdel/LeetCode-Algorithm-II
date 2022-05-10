using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AlgorithmII.Day01;
using AlgorithmII.Day02;

namespace AlgorithmII
{
    static class Program
    {
        static void Main(string[] args)
        {
            // FindPeakElementProblem.Run();
            FindMinInRotatedArray.Run();
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