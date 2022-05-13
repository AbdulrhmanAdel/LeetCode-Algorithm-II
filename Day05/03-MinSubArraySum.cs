using System;

namespace AlgorithmII.Day05
{
    public class MinSubArraySum
    {public static void Run()
        {
            Console.WriteLine(MinSubArrayLen(7, new int[]
            {
                2,3,1,2,4,3
            }));
        }
        public static int MinSubArrayLen(int target, int[] nums)
        {
            if (nums.Length == 0) return 0;

            int sum = 0;
            int answer = int.MaxValue;
            // 2,3,1,2,4,3
            for (var right = 0; right < nums.Length; right++)
            {
                var current = nums[right];
                if (current >= target) return 1;
                
                var left = right + 1;
                sum += current;
                while (left < nums.Length && sum < target)
                {
                    sum += nums[left++];
                }

                if (sum < target)
                {
                    sum = 0;    
                    continue;
                }
                answer = Math.Min(answer, left - right);
                sum = 0;    
            }

            return answer == int.MaxValue 
                ? 0
                : answer;
        }
    }
}