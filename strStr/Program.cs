using System;

namespace strStr
{
    class Program
    {
        public static int strStr(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(needle))
                return 0;
            int m = haystack.Length; 
            int n = needle.Length;
            if (m < n) return -1;
            // i<m-n; lower loop times
            for(int i = 0; i < m - n; i++)
            {
                int j = 0; // declare first
                for (j = 0; j < n; j++)
                {
                    if (haystack[i+j] != needle[j]) break; // not equal then jump out
                }
                if (j == n) return i;
            }
            return -1;
        }
        static void Main(string[] args)
        {
            string haystack = "hello";
            string needle = "ll";
            var result = strStr(haystack, needle);
            Console.WriteLine(result);
        }
    }
}

//KMP ??? 