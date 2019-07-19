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
        // solution2 : from grandyang
        public static bool isIsomorphic2(string s, string t) {
            int[] m1 = new int[256];
            int[] m2 = new int[256];
            for (int i = 0; i < s.Length; i++) {
                if (m1[s[i]] != m2[t[i]]) return false;
                m1[s[i]] = i + 1;                
                m2[t[i]] = i + 1;                  
                //printArray(m1);
            }

            return true;
        }
        public static void printArray(int[] m) {
            foreach (var item in m) {
                Console.Write(item);
            }
            Console.WriteLine();
        }     

//test dictionary   
        public static void testDic()
        {
            Dictionary<char, int> hs = new Dictionary<char,int>();
            hs.Add('a', 1);
            Console.WriteLine(string.Join(",", hs)); 
            hs['a']++;
            Console.WriteLine(string.Join(",", hs));            
        }
// assign char to an int variable ascii; internally C# converts the character to ASCII value;
        public static void testASCII() {
            int[] intArray = new int[256];
            int x = 'A';
            Console.WriteLine(x);
            intArray['a'] = 2;
            foreach(var item in intArray)
            {Console.Write(item);}
        }
        static void Main(string[] args)
        {
            //testDic();
            //testASCII();

            string s = "title";
            string t = "paper";
            var result = isIsomorphic2(s, t);
            
            Console.WriteLine(result);
        }
    }
}


// difference between HashSet, Dictionary, HashTable
