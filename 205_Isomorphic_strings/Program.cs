using System;
using System.Collections.Generic;

namespace _205_Isomorphic_strings
{
    class Program
    {
        // solution1: easy understanding, double loop;
        public static bool isIsomorphic(string s, string t) {
            Dictionary<char, int> dc1 = new Dictionary<char, int>();
            Dictionary<char, int> dc2 = new Dictionary<char, int>();
            int l1 = s.Length, l2 = t.Length;
            for (int i = 0;i < l1; i++) {
                if (!dc1.ContainsKey(s[i])) {
                    dc1.Add(s[i], 1);
                } else {
                    dc1[s[i]]++;
                }
                if (!dc2.ContainsKey(t[i])) {
                    dc2.Add(t[i], 1);
                } else {
                    dc2[t[i]]++;
                }
            }          
            for (int i = 0; i < s.Length; i++) {
                if (dc1[s[i]] != dc2[t[i]])
                return false;
            }   
            return true;
        }

        // public static void testDic()
        // {
        //     Dictionary<char, int> hs = new Dictionary<char,int>();
        //     hs.Add('a', 1);
        //     Console.WriteLine(string.Join(",", hs)); 
        //     hs['a']++;
        //     Console.WriteLine(string.Join(",", hs));            
        // }
        static void Main(string[] args)
        {
            //testDic();

            string s = "title";
            string t = "paper";
            var result = isIsomorphic(s, t);
            
            Console.WriteLine(result);
        }
    }
}


// difference between HashSet, Dictionary, HashTable
