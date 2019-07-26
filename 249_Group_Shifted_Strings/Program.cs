using System;
using System.Collections.Generic;

namespace _249_Group_Shifted_Strings
{
    class Program
    {
        public static IList<IList<string>> GroupShiftStrings(string[] strs) {
            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();

            foreach(var item in strs) {
                var testStr = shiftTest(item);
                if (!dic.ContainsKey(testStr)) {
                    dic.Add(testStr, new List<string>());
                }
                dic[testStr].Add(item);
            }
            return new List<IList<string>>(dic.Values);
        }
        public static string shiftTest(string str) {
            string s = "";
            int l = str.Length;
            for (int i = 1; i < l; i++) {
                int diff = (str[i] - str[i-1] + 26) % 26 ;  
                s += (char) diff;
                //s += diff;
            }            
            return s;
        }
        static void Main(string[] args)
        {
            string[] strs = new string[]{"abc", "bcd", "acef", "xyz", "az", "ba", "a", "z"};
            var result = GroupShiftStrings(strs);
            foreach(var item in result) {
                Console.WriteLine(string.Join(" ", item));
            }            
        }
    }
}
