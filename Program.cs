using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AlgorithmII.Day01;
using AlgorithmII.Day02;
using AlgorithmII.Day03;
using AlgorithmII.Day04;

namespace AlgorithmII
{
    static class Program
    {
        static void Main(string[] args)
        {
            // BackspaceStringCompare.Run();
            IntervalListIntersections.Run();
            // ContainerWithMostWater.Run();
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