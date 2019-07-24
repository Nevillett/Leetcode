using System;

namespace _242_Valid_Anagram
{
    class Program
    {
        public static bool IsAnagram (string s, string t) {
            if (s.Length != t.Length)
            return false;

            char[] source = s.ToCharArray(), target = t.ToCharArray();

            Array.Sort(source);
            Array.Sort(target);

            for (int i = 0; i < s.Length; i++) {
                if (source[i] != target[i])
                    return false;
            }
            return true;
        }
        // using array 
        public static bool IsAnagram2 (string s, string t) {
            if (s.Length != t.Length)
            return false;

            int[] array = new int[26];
            for (int i = 0; i < s.Length; i++) {
                array[s[i] - 'a']++;   // [s[i] - 'a'] means shift the ascii value so that a ~ z have values 0 ~ 25 ; suitable as an array index;
                array[t[i] - 'a']--; 
            }
            foreach (var item in array) {
                if (item != 0) 
                return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            string s = "rat";
            string t = "car";
            var result = IsAnagram(s, t);
            Console.WriteLine(result);

            var result2 = IsAnagram2(s, t);
            Console.WriteLine(result2);

// Test how to print char ASCII;
            int x = 'a';            
            Console.WriteLine(x); 
            Console.WriteLine((int)'z') ;  
            Console.WriteLine((char) 4);         
        }
    }
}
