using System;
using System.Collections.Generic;

namespace FirstUniqueCharinString
{
    class Program
    {
        public static int FirstUniqueChar(String s)
        {
            if (string.IsNullOrEmpty(s)) return -1;
            var dic = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (dic.ContainsKey(s[i]))
                {
                    dic[s[i]] = -1;
                } else {
                    dic.Add(s[i], i);
                }            
            }
            foreach (var key in dic.Keys)
            {
                //Console.WriteLine(key);
                if (dic[key] != -1)
                return dic[key];
            }
            return -1;
        }
        static void Main(string[] args)
        {
            string s = "leetcode";
            string s2 = "loveleetcode";
            var result = FirstUniqueChar(s);
            var result2 = FirstUniqueChar(s2);
            Console.WriteLine(result);
            Console.WriteLine("result is {0}, {1}",result,result2);
        }
    }
}
