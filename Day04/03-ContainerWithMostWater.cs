using System;

namespace AlgorithmII.Day04
{
    public class ContainerWithMostWater
    {
        public static void Run()
        {
            var result = MaxArea(new[] {1, 8, 6, 2, 5, 4, 8, 3, 7});
            Console.WriteLine(result);
            Console.WriteLine(MaxArea(new[] {1, 1}));
        }

        public static int MaxArea(int[] height)
        {
            var first = 0;
            var last = height.Length - 1;
            var max = 0;
            while (first < last)
            {
                var width = last - first;

                var min = Math.Min(height[first], height[last]);
                max = Math.Max(max, width * min);
                if (height[first] == min)
                {
                    first++;
                    continue;
                }

                last--;
            }

            return max;
        }
    }
}