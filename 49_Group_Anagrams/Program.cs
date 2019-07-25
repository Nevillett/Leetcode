using System;
using System.Collections.Generic;

namespace _49_Group_Anagrams
{
    class Program
    {
        public static IList<IList<string>> GroupAnagrams(string[] strs) {
            Dictionary<string, List<string>> dc = new Dictionary<string, List<string>>();

            List<string> listStrs = new List<string>();
            foreach (var item in strs) {                
                var charArray = item.ToCharArray();
                Array.Sort(charArray);
                listStrs.Add(new string (charArray));
            }
            //Console.WriteLine(string.Join(" ", listStrs));

            for (int i = 0 ; i < listStrs.Count; i++) {                
                if ( !dc.ContainsKey(listStrs[i])) {
                    dc.Add(listStrs[i], new List<string>());
                }
                // key point here: no matter the dictionary has key or not, add the string in the list
                dc[listStrs[i]].Add(strs[i]);                
            }
            // get all the value from dictionary;  List<IList> should pay attention; 
            return new List<IList<string>>(dc.Values);
            // var result = new List<IList<string>>();
            // foreach (var item in dc) {
            //     result.Add(item.Value);
            // }
            // return result;
        }
        // solution 2: using only one loop, foreach
        public static IList<IList<string>> GroupAnagrams2(string[] strs) {
            Dictionary<string, List<string>> dc = new Dictionary<string, List<string>>();

            foreach (var item in strs) {
                var charArray = item.ToCharArray();
                Array.Sort(charArray);
                string sortStr = new string(charArray);

                if (!dc.ContainsKey(sortStr)) {
                    dc.Add(sortStr, new List<string>());
                }
                dc[sortStr].Add(item);
            }
            return new List<IList<string>>(dc.Values);
        }
        static void Main(string[] args)
        {
            string[] strs = new string[]{"eat", "tea", "tan", "ate", "nat", "bat"};
            var result = GroupAnagrams2(strs);
            foreach (var item in result) {
                Console.WriteLine(string.Join(", ", item));
            }            
        }
    }
}
