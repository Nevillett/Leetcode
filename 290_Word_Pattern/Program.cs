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

        // solution 2: use one dictionary
        public static bool wordPattern2(string pattern, string str) {
            string[] words = str.Split(" ");
            Dictionary<char, string> map = new Dictionary<char, string>();
            if (pattern.Length != words.Length) return false;

            for (int i = 0; i < pattern.Length; i++) {
                if (map.ContainsKey(pattern[i])) {
                    if (map[pattern[i]] != words[i]) return false;
                } else if (map.ContainsValue(words[i])) return false;
                else map.Add(pattern[i], words[i]); // or: map[pattern[i]] = words[i];
            }
            return true;
        }
        static void Main(string[] args)
        {
            string pattern = "abba";
            string str = "dog cat cat dog";
            var result = wordPattern(pattern, str);
            Console.WriteLine(result);
            string str2 = "dog dog dog dog";  // this case is for --map.ContainsValue(words[i]) return false--;
            var result2 = wordPattern2(pattern, str2);
            Console.WriteLine(result2);
        }
    }
}
