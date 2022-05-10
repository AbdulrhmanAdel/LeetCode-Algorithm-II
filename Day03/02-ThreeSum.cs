using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;

namespace AlgorithmII.Day03
{
    public class ThreeSumProblem
    {
        public static void Run()
        {
            var result = ThreeSum(new int[] {-1, 0, 1, 2, -1, -4});
        }

        
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            var result = new List<IList<int>>();
            if (nums.Length < 3)
            {
                return result;
            }

            Array.Sort(nums);
            if (nums[0] > 0)
            {
                return result;
            }
            
            // -1,0,1,2,-1,-4
            // -4 -1 -1 0 1 2
            for (var i = 0; i + 2 < nums.Length; i++)
            {
                var current = nums[i];
                if (i > 0 && current == nums[i - 1])
                {
                    continue;
                }

                var j = i + 1;
                var k = nums.Length - 1;

                while (j < k)
                {
                    var sum = current + nums[j] + nums[k];
                    if (sum == 0)
                    {
                        result.Add(new List<int>() {current, nums[j], nums[k]});
                        k--;
                        while (j < k && nums[k] == nums[k + 1]) k--;
                    }
                    else if (sum > 0)
                    {
                        k--;
                        continue;
                    }

                    j++;
                }
            }

            return result;
        }
        
    }
}