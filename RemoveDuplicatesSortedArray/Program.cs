// 26

using System;
using System.Collections.Generic;

namespace RemoveDuplicatesSortedArray
{
    class Program
    {   
        public static int RemoveDuplicatesSortedArray(int[] nums)
        {
            var hash = new HashSet<int>(nums);
            return hash.Count;
        }

        public static int RemoveDuplicatesSortedArray2(int[] nums)
        {
            int pre = 0, cur = 0, l = nums.Length;
            while(cur < l)
            {
                if (nums[pre] == nums[cur]) ++cur;
                else nums[++pre] = nums[cur++];
                // better understanding ++pre and cur++
                Console.WriteLine("pre:{0}; cur:{1}", pre, cur);
                Console.WriteLine(string.Join(",", nums));                
            }
            return pre + 1;
        }
        static void Main(string[] args)
        {
            int[] nums = new int[]{1,1,2,2,3,5,5,5};
            var result = RemoveDuplicatesSortedArray(nums);
            var result2 = RemoveDuplicatesSortedArray2(nums);
            Console.WriteLine(result);
            Console.WriteLine(result2);
        }
    }
}
