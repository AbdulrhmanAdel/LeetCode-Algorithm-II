using System;
using static AlgorithmII.Helpers.ArrayHelpers;

namespace AlgorithmII.Day01
{
    public static class Search2DMatrix
    {
        public static void Run()
        {
            Console.WriteLine(SearchMatrix(
                new int[][]
                {
                    new[] {1, 3, 5, 7},
                    new[] {10, 11, 16, 20},
                    new[] {23,30,34,60}
                }, 3));
        }

        public static bool SearchMatrix(int[][] matrix, int target)
        {
            var rowLatestElementIndex = matrix[0].Length - 1;
            int[] rowHoldingTheTarget = null;
            foreach (var row in matrix)
            {
                var latestElementInTheRow = row[rowLatestElementIndex];
                if (latestElementInTheRow == target) return true;
                if (latestElementInTheRow < target) continue;

                rowHoldingTheTarget = row;
                break;
            }

            var index = rowHoldingTheTarget?.BinarySearch(target);
            return index > -1;
        }
    }
}