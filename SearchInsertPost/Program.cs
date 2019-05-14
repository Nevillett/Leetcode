using System;

namespace SearchInsertPost
{
    class Program
    {
        //one way: 
        public static int SearchInsert(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= target)
                return i;
            }
            return nums.Length;
        }
        //binary search  improve O(time)?
        public static int SearchInsert2(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            while(left < right)
            {
                int mid = left + (right - left)/2;
                if (nums[mid] == target) return mid;
                else if (nums[mid] < target) left = mid + 1;
                else right = mid;
            }
            return left; // same with return right; after the while, left and right is same
        }
        static void Main(string[] args)
        {
            int[] nums = new int[] {2, 3, 4, 7, 9};
            var SearchResult = SearchInsert(nums, 4);
            var InsertResult = SearchInsert(nums, 6);
            //way 2
            var result2 = SearchInsert2(nums, 1);
            Console.WriteLine(SearchResult);
            Console.WriteLine(InsertResult);
            //way 2
            Console.WriteLine(result2);
        }
    }
}
