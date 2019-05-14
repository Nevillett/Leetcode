using System;

namespace RotatedSortedArraySearch2
{
    class Program
    {
        public static bool Search(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left)/2;
                if (nums[mid] == target) return true;
                else if (nums[mid] < nums[right])
                {
                    if (nums[mid] < target && nums[right] >= target)
                    {
                        left = mid + 1;
                    } 
                    else right = mid - 1;
                } else if (nums[mid] > nums[right])
                {
                    if (nums[mid] > target && nums[left] <= target)
                    {
                        right = mid - 1;
                    }
                    else left = mid + 1;
                } else --right;
                // cause they are same, we can simply remove one; just check the boolean
            }
            return false;
        }
        static void Main(string[] args)
        {
            //int[] nums = new int[]{1, 2, 3, 3, 3, 1, 1};
            int[] nums = new int[]{1, 3, 1, 1};
            var result = Search(nums, 3);
            Console.WriteLine(result);
        }
    }
}
