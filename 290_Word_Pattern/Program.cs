using System;
using System.Collections.Generic;

namespace _290_Word_Pattern
{
    class Program
    {
        public static bool wordPattern(string pattern, string str) {
            Dictionary<char, int> dc1 = new Dictionary<char, int>();
            Dictionary<string, int> dc2 = new Dictionary<string, int>();
            string[] strs = str.Split(" ");
            if (pattern.Length != strs.Length) return false;
            for (int i = 0; i < pattern.Length; i++) {
                if (!dc1.ContainsKey(pattern[i])) {
                    dc1.Add(pattern[i], 1);
                } else {
                    dc1[pattern[i]]++;
                }
                
                if (!dc2.ContainsKey(strs[i])) {
                    dc2.Add(strs[i], 1);
                } else {
                    dc2[strs[i]]++;
                }                
            }            
            // Console.WriteLine("{0}, {1}", dc1.Count, dc2.Count);
            // Console.WriteLine( $"{dc1.Count}, {dc2.Count}");
            // Console.WriteLine(string.Join(",", dc1));
            // Console.WriteLine(string.Join(",", dc2));
            for (int i = 0; i < pattern.Length; i++) {
                if (dc1.ContainsKey(pattern[i]) != dc2.ContainsKey(strs[i]) && dc1.Count != dc2.Count) 
                return false;
            }
            return true;            
        }        
        static void Main(string[] args)
        {
            string pattern = "abba";
            string str = "dog cat cat dog";
            var result = wordPattern(pattern, str);
            Console.WriteLine(result);
        }
    }
}
