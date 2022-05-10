using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AlgorithmII.Day01;
using AlgorithmII.Day02;
using AlgorithmII.Day03;

namespace AlgorithmII
{
    static class Program
    {
        static void Main(string[] args)
        {
            // RemoveDuplicatesFromSortedListII.Run();
            ThreeSumProblem.Run();
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