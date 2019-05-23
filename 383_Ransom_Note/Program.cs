using System;
using System.Collections.Generic;

namespace _383_Ransom_Note
{
    class Program
    {
        public static bool canConstruct(string ransomNote, string magazine)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            foreach( char c in magazine)
            {
                if (dic.ContainsKey(c))                
                    dic[c]+= 1;                
                else 
                    dic.Add(c, 1);
            }
            foreach ( char c in ransomNote)
            {
                if (dic.ContainsKey(c))
                {
                    // need to change the logic, not good 
                    dic[c]-=1;
                    if ( dic[c] < 0) 
                    return false;
                }
                else
                    return false;                    
            }
            return true;
        }
        //solution 2: easy and clearly
        public static bool canConstruct2(string ransomNote, string magazine)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            foreach( char c in magazine)
            {
                if (dic.ContainsKey(c)) 
                ++dic[c];
                else
                dic.Add(c,1);                
            }
            foreach ( char c in ransomNote)
            {
                if (--dic[c] < 0) 
                return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            string ransomNote = "abb";
            var magazine = "aabb";
            var result = canConstruct(ransomNote, magazine);
            var result2 = canConstruct2(ransomNote, magazine);
            Console.WriteLine(result);
            Console.WriteLine(result2);
        }
    }
}
