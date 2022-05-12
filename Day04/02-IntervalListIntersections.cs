using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmII.Day04
{
    public class IntervalListIntersections
    {
        public static void Run()
        {
            var result = IntervalIntersection(
                new int[][] {new int[] {0, 2}, new int[] {5, 10}, new int[] {13, 23}, new int[] {24, 25}},
                new int[][] {new int[] {1, 5}, new int[] {8, 12}, new int[] {15, 24}, new int[] {25, 26}});
        }

        public static int[][] IntervalIntersection(int[][] firstList, int[][] secondList)
        {
            var result = new List<int[]>();

            var first = 0;
            var second = 0;

            // new int[][] {new int[] {0, 2}, new int[] {5, 10}, new int[] {13, 23}, new int[] {24, 25}},
            // new int[][] {new int[] {1, 5}, new int[] {8, 12}, new int[] {15, 24}, new int[] {25, 26}});
            while (first < firstList.Length && second < secondList.Length)
            {
                var currentRangeFromFirst = firstList[first];
                var firstStartRange = currentRangeFromFirst[0];
                
                
                var currentRangeFromSecond = secondList[second];
                var secondEndRange = currentRangeFromSecond[1];
                
                if (firstStartRange > secondEndRange)
                {
                    second++;
                    continue;
                }

                var firstEndRange = currentRangeFromFirst[1];
                var secondStartRange = currentRangeFromSecond[0];
                if (firstEndRange < secondStartRange)
                {
                    first++;
                    continue;
                }

                
                // 0  1  2  3  4  5  6  7  8  9
                // *     *
                //    *           *
                var start = firstStartRange;
                var end = firstEndRange;
                if (secondStartRange >= firstStartRange)
                {
                    start = currentRangeFromSecond[0];
                }

                if (firstEndRange > secondEndRange)
                {
                    end = secondEndRange;
                    second++;
                }
                else
                {
                    first++;
                }
                result.Add(new[] { start, end });
            }
            
            return result.ToArray();
        }
    }
}