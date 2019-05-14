using System;

namespace RotatedSortedArraySearch
{
    class Program
    {
        public static int Search(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            while(left <= right)   
            {
                int mid = left + (right - left)/2;
                if (nums[mid] == target) return mid;
                else if (nums[mid] < nums[right])
                {
                    if (nums[mid] < target && nums[right] >= target)
                    {
                        left = mid + 1;
                    } 
                    else right = mid - 1;
                } else {
                    if ( nums[left] <= target && nums[mid] >target)
                    {
                        right = mid - 1;
                    }
                    else left = mid + 1;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] nums = new int[] { 4, 6, 8, 9, 0, 1, 2};
            var result = Search(nums, 2);            
            var result0 = Search(nums, 3) ;
            Console.WriteLine(result);
            Console.WriteLine(result0);
        }
    }
}
