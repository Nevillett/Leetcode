using System;
using System.Collections.Generic;

namespace _412_Fizz_Buzz
{    
    class Program
    {
        public static IList<string> FizzBuzz(int n) {
            var result = new List<string>();

            for (int i = 1; i <= n; i++) {
                if (i % 3 == 0 && i % 5 == 0)
                    result.Add("FizzBuzz");
                else if (i % 3 == 0)
                    result.Add("Fizz");
                else if (i % 5 == 0)
                    result.Add("Buzz");
                else 
                    result.Add(i.ToString());
            }
            return result;
        }        
        static void Main(string[] args)
        {
            var result = FizzBuzz(15);
            // string.Join() display all the item in the list
            Console.WriteLine(string.Join(",", result));   
            FizBuz3();
        }


        // 0723 test; my stupid solution 
        public static string[] FizBuz(string[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (Int32.Parse(nums[i]) % 3 == 0 && Int32.Parse(nums[i]) % 5 == 0)
                    nums[i] = "FizBuz";
                else if (Convert.ToInt32(nums[i]) % 3 == 0)
                    nums[i] = "Fiz";
                else if (Int32.Parse(nums[i]) % 5 == 0)
                    nums[i] = "Buz";
            }
            return nums;
        }
        // short cut
        public static void FizBuz2()
        {
            for (int i = 1; i < 100; i++)
            {
                if (i % 15 == 0)
                    Console.WriteLine("FizBuz");
                else if (i % 3 == 0)
                    Console.WriteLine("Fiz");
                else if (i % 5 == 0)
                    Console.WriteLine("Buz");
                else
                    Console.WriteLine($"{i}");
            }
        }
        // short cut 2  using C# ternary operator
        public static void FizBuz3()
        {
            for (int i = 1 ; i < 100; i++) {
                string s = i % 15 == 0 ? "FizzBuzz" : i % 3 == 0 ? "Fizz" : i % 5 == 0 ? "Buzz" : i.ToString();
                Console.WriteLine(s);
            }
        }
    }
}

 //Enumerable.Range(1,n)??