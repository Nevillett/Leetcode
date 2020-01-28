using System;
using System.Collections.Generic;

namespace _217_Contain_Duplicate
{
    class Program
    {

        public static bool ContainsDuplicate(int[] nums) {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            foreach(var i in nums) {
                if (dic.ContainsKey(i)) {
                    dic[i]++;
                    return true;
                } else {
                    dic.Add(i, 0);
                }
            }
            //dic.values return all the values in collection from this dictionary
            //System.Console.WriteLine(string.Join(" ", dic.Values));
            return false;
        }        

        static void Main(string[] args)
        {
            int[] nums = new int[]{1,2,3,4};
            int[] nums2 = new int[]{1,1,1,3,3,2,4,2};
            var result = ContainsDuplicate(nums);
            Console.WriteLine(result);
        }
    }
}
