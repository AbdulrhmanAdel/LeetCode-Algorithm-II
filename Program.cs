using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using AlgorithmII.Day01;
using AlgorithmII.Day02;
using AlgorithmII.Day03;
using AlgorithmII.Day04;
using AlgorithmII.Day05;

namespace AlgorithmII
{
    static class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(new int[] {1,2,3,4}.SequenceEqual(new int[] {1,2,3,4}));
            // FindAllAnagramsInAString.Run();
            // SubarrayProductLessThanK.Run();
            MinSubArraySum.Run();
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