using System;

namespace AlgorithmII.Day05
{
    public class SubarrayProductLessThanK
    {
        public static void Run()
        {
            Console.WriteLine(NumSubarrayProductLessThanK(new int[]
            {
                10, 5, 2, 6
            }, 100));
        }

        public static int NumSubarrayProductLessThanK(int[] nums, int k)
        {
            if (k <= 1) return 0;
            int prod = 1, answer = 0, left = 0;
            // 10,5,2,6
            for (var right = 0; right < nums.Length; right++)
            {
                prod *= nums[right];
                while (prod >= k) prod /= nums[left++];
                answer += right - left + 1;
            }

            return answer;
        }
    }
}