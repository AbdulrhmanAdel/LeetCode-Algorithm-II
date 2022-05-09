using System;
using System.Xml.Schema;

namespace AlgorithmII.Day01
{
    public class FindFirstAndLastPositionOfElementInSortedArrayProblem
    {
        public static void Run()
        {
            var result = SearchRange(new int[]
            {
                5,7,7,8,8,10
                
            }, 8);
            result.PrintSequence();
            // Console.WriteLine(result);
        }

        public static int[] SearchRange(int[] nums, int target)
        {
            var left = BinarySearchFirstElement(nums, target);

            if (left == -1)
            {
                return new int[] {-1, -1};
            }

            var right = left;

            while (nums[right] == target)
            {
                right++;
            }
            
            return new int[] {left, right - 1};
        }

        public static int BinarySearchFirstElement(int[] nums, int target)
        {
            var begin = 0;
            var end = nums.Length - 1;

            while (begin <= end)
            {
                var mid = begin + (end - begin) / 2;
                if (nums[mid] == target)
                {
                    if (begin == mid || nums[mid - 1] != target)
                        return mid;

                    end = mid - 1;
                }
                else if (target < nums[mid])
                {
                    end = mid - 1;
                }
                else if (target > nums[mid])
                {
                    begin = mid + 1;
                }
            }

            return -1;
        }

        public static int[] BinarySearchRange(int[] nums, int target)
        {
            var index = Array.BinarySearch(nums, target);
            if (index < 0)
            {
                return new[] {-1, -1};
            }

            var firstMatchIndex = index;
            for (var i = index - 1; i >= 0; i--)
            {
                if (nums[i] != target)
                {
                    break;
                }

                firstMatchIndex = i;
            }

            var lastMatchIndex = index;
            for (var i = index + 1; i < nums.Length; i++)
            {
                if (nums[i] != target)
                {
                    break;
                }

                lastMatchIndex = i;
            }

            return new[] {firstMatchIndex, lastMatchIndex};
        }
    }
}