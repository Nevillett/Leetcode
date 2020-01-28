using System;
using System.Collections.Generic;

namespace _41_FirstMissingPositive
{
    class Program
    {

        public static int FirstMissingPositive(int[] nums)
        {
            
            HashSet<int> hs = new HashSet<int>(nums);
            foreach(var item in nums){
                hs.Add(item);
            }
            //Console.WriteLine(string.Join(",", hs));
            for (int i = 0; i < nums.Length; i++){
                if (!hs.Contains(i + 1)){
                    return i+1;
                }
            }
            return nums.Length + 1;
        }
        public static int FirstMissingPositive2(int[] nums)
        {
            if (nums.Length == 0) return 1;
            HashSet<int> hs = new HashSet<int>();
            int MaxNum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > MaxNum)
                MaxNum = nums[i];
                if (nums[i] > 0)
                hs.Add(nums[i]);
            }
            for (int i = 1; i <= MaxNum; i++)
            {
                if (!hs.Contains(i))
                return i;
            }
            return MaxNum + 1;
        }
        static void Main(string[] args)
        {
            int[] nums = new int[]{3,4,1,-1};
            var result = FirstMissingPositive(nums);
            var result2 = FirstMissingPositive2(nums);
            Console.WriteLine(result);
            Console.WriteLine(result2);
        }
    }
}
