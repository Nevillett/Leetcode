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
        static void Main(string[] args)
        {
            string ransomNote = "abb";
            var magazine = "aabb";
            var result = canConstruct(ransomNote, magazine);
            Console.WriteLine(result);
        }
    }
}
