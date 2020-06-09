using System;
using System.Collections.Generic;

namespace _219_Contains_Duplicate2
{
    class Program
    {
        public static bool ContainsNearbyDuplicate(int[] nums, int k){
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++) {
                if (dic.ContainsKey(nums[i])) {
                    if (i - dic[nums[i]] <= k)
                        return true;
                } else {
                    dic.Add(nums[i], i);
                }               
            }
            return false;
        }
        static void Main(string[] args)
        {
            int[] nums = new int[]{1,2,3,1,2,3};
            int k = 2;
            var result = ContainsNearbyDuplicate(nums, k);

            Console.WriteLine(result);
        }
    }
}
