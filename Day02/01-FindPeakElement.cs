using System;

namespace AlgorithmII.Day02
{
    public class FindPeakElementProblem
    {
        public static void Run()
        {
            Console.WriteLine(FindPeakElement(new[] {1, 2, 1, 3, 5, 6, 5, 7, 8, 9}));
            Console.WriteLine(FindPeakElement(new[] {1, 2, 3, 1}));
        }

        public static int FindPeakElement(int[] nums)
        {
            //     3
            //       1
            //   2
            // 1

            //   / \
            //  /
            // /
            // so you check the slope if the middle in increasing slope that's mean there is a peak in the right
            // other wise there is  a peak in the left
            return FindPeakElement(nums, 0, nums.Length - 1);
        }

        public static int FindPeakElement(int[] nums, int begin, int end)
        {
            if (begin == end)
            {
                return end;
            }

            var mid = (end + begin) / 2;

            if (nums[mid] > nums[mid + 1])
                return FindPeakElement(nums, begin, mid);

            return FindPeakElement(nums, mid + 1, end);
        }
    }
}