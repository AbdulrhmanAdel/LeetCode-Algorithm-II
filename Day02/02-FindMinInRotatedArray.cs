using System;
using AlgorithmII.Helpers;

namespace AlgorithmII.Day02
{
    public class FindMinInRotatedArray
    {
        // 4,5,6,7,0,1,2
        public static void Run()
        {
            // Console.WriteLine(FindMin(new[] {4, 5, 6, 7, 0, 1, 2}));
            Console.WriteLine(FindMin(new[] {2, 1}));
        }

        //  / 
        // /
        public static int FindMin(int[] nums)
        {
            if (nums.Length == 0 || !nums.IsRotatedArray())
            {
                return nums[0];
            }

            var fistValue = nums[0];
            var begin = 0;
            var end = nums.Length - 1;

            // 4, 5, 6, 7, 0, 1, 2
            
            while (begin <= end)
            {
                var mid = begin + (end - begin) / 2;
                var middleNumber = nums[mid];

                // Check If you have the min in the next value
                if (middleNumber > nums[mid + 1]) {
                    return nums[mid + 1];
                }
                
                // Check If you have the min in the previous value 
                if (nums[mid - 1] > middleNumber) {
                    return nums[mid];
                }
                
                // 4, 5, 6, 7, 0, 1, 2
                // Check If the mid bigger than the first element so we are in this part and 4, 5, 6, 7
                // min in the right part 0, 1, 2
                if (middleNumber > fistValue)
                {
                    begin = mid + 1;
                    continue;
                }

                end = mid - 1;
            }

            return -1;
        }
    }
}