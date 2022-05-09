using System;
using AlgorithmII.Helpers;

namespace AlgorithmII.Day01
{
    public class SearchInRotatedSortedArrayProblem
    {
        public static void Run()
        {
            Console.WriteLine(SearchV2(new[] {5, 6, 7, 9, 15, 16, 0, 1, 2, 3, 4}, 0));
            Console.WriteLine(SearchV2(new[] {3, 1}, 1));
            // Console.WriteLine(SearchV2(new[] {0, 1, 2, 3, 4, 5, 6, 7, 9, 15}, 9));
        }
        
        public static int SearchV2(int[] nums, int target)
        {
            return nums[0] >= nums[^1]
                ? BinarySearchRotatedArray(nums, target)
                : nums.BinarySearch(target);
        }
        
        private static int BinarySearchRotatedArray(int[] nums, int target)
        {
            var first = nums[0];
            if (first == target) return 0;

            var begin = 0;
            var end = nums.Length - 1;
            while (begin <= end)
            {
                var mid = begin + (end - begin) / 2;
                var middleNumber = nums[mid];
                if (nums[mid] == target)
                {
                    return mid;
                }

                if (target > middleNumber)
                {
                    begin = mid + 1;
                    continue;
                }

                // {5, 6, 7,9,15, 0, 1, 2, 3, 4}
                if (middleNumber > begin)
                {
                    if (target > begin)
                    {
                        end = mid - 1;
                        continue;
                    }
                    else
                    {
                        begin = mid + 1;
                        continue;
                    }
                }


                end = mid - 1;
            }

            return -1;
        }
    }
}