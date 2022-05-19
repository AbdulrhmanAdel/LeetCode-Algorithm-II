using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using AlgorithmII.Day01;
using AlgorithmII.Day02;
using AlgorithmII.Day03;
using AlgorithmII.Day04;
using AlgorithmII.Day05;
using AlgorithmII.Day06;
using AlgorithmII.Day07;

namespace AlgorithmII
{
    static class Program
    {
        static void Main(string[] args)
        {
            
            SubtreeOfAnotherTree.Run();
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