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
        static void Main(string[] args)
        {
            int[] nums = new int[]{1,1,2,2,3,5,5,5};
            var result = RemoveDuplicatesSortedArray(nums);
            Console.WriteLine(result);
        }
    }
}
