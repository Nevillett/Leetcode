using System;
using System.Collections.Generic;

namespace _299_BullsAndCows
{
    class Program
    {
        public static string GetHint(string secret, string guess)
        {
            int bulls = 0, cows = 0;
            int[] m = new int[256];
        // for cows maintain an array that stores count of the number appearances in secret (which are not in bulls)             
            for (int i = 0; i < secret.Length; i++)
            {
                if (secret[i] == guess[i]){
                    bulls++;
                } else {
                    m[secret[i]]++;
                }
            }
            //Console.WriteLine(string.Join(" ", m));        
            for (int i = 0; i < secret.Length; i++)
            {
        // if the count number > 0, means secret has same one with guess 
                if ((secret[i] != guess[i]) && (m[guess[i]] > 0)) {
                    cows++;
                    m[guess[i]]--;
                }
            }
            //Console.WriteLine(string.Join(" ", m));
            string s = bulls +"A" + cows + "B";
            return s;

            //Console.WriteLine("{0}A{1}B", bulls, cows);
        }
        
        public static string GetHint2(string secret, string guess)
        {
            int bulls = 0, cows = 0;
            int[] nums = new int[10];
            for (int i = 0; i < secret.Length; i++)
            {
                int s = secret[i] - '0';
                int g = guess[i] - '0';
                if (s == g)
                {
                    bulls++;
                } else {
                    if (nums[g] > 0) {
                        cows++;
                    }
                    if (nums[s] < 0) {
                        cows++;
                    }
                    nums[g]--;
                    nums[s]++;
                }
            }
        // similar with above; one trick is firstly compare with 0 and then do the ++ or --
            // if (nums[s]-- < 0) cows++;
            // if (nums[g]++ > 0) cows++;
            string str = bulls +"A" + cows + "B";
            return str;
        }
        static void Main(string[] args)
        {
            string secret = "1807";
            string guess = "7810";
            var result = GetHint2(secret, guess);
            Console.WriteLine(result);
        }
    }
}
