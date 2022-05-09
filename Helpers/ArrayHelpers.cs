namespace AlgorithmII.Helpers
{
    public static class ArrayHelpers
    {
        public static int BinarySearch(this int[] nums, int target)
        {
            var begin = 0;
            var end = nums.Length - 1;

            while (begin <= end)
            {
                var mid = begin + (end - begin) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }

                if (target < nums[mid])
                {
                    end = mid - 1;
                }

                if (target > nums[mid])
                {
                    begin = mid + 1;
                }
            }

            return -1;
        }
    }
}