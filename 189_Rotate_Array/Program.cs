using System;

namespace _189_Rotate_Array
{
    class Program
    {
        public static void Rotate(int[]nums, int k ) {
            while(k > 0 ) {
                int L = nums.Length;
                int temp = nums[L-1];
                
                for (int i = L - 1; i > 0; i--) {                    
                    nums[i] = nums[i-1];
                    //Console.WriteLine(i);
                    //Console.WriteLine(string.Join(",", nums));
                }
                nums[0] = temp;
                Console.WriteLine(string.Join(",", nums));
                k--;
            }
        }

        public static void Rotate2(int[] nums, int k) {
            int[] target = new int[k+1];
            int[] target2 = new int[nums.Length - k - 1];
            Array.Copy(nums, 0, target, 0, k+1);   
            //Console.WriteLine(string.Join(",", target));                     
            Array.Copy(nums, k+1, target2, 0, k);
            //Console.WriteLine(string.Join(",", target2));
            Array.Reverse(target);
            Array.Reverse(target2);
            int[] newArray = new int[nums.Length];
            Array.Copy(target, newArray, target.Length);
            //Console.WriteLine(string.Join(",", newArray));
            Array.Copy(target2, 0, newArray, target.Length, target2.Length);
            //Console.WriteLine(string.Join(",", newArray));
            Array.Reverse(newArray);
            Console.WriteLine(string.Join(",", newArray));
        }
        static void Main(string[] args)
        {
            int[] nums = new int[]{1,2,3,4,5,6,7};
            int[] nums2 = new int[]{-1,-100,3,99};
            //Rotate(nums, 3);
            //Console.WriteLine(string.Join(",", nums));
            Rotate2(nums, 3);
        }
    }
}

// copy first three elements in source to target from index[0]
// Array.Copy(source, 0, target, 0, 3)
