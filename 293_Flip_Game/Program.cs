using System;
using System.Collections.Generic;

namespace _293_Flip_Game
{
    class Program
    {
        public static List<string> Flip(string s) {
            List<string> list = new List<string>();       
            for (int i = 1 ; i < s.Length; i++) {
                char[] charArray = s.ToCharArray();
                if (s[i] =='+' && s[i-1] == '+') {
                    charArray[i] = '-' ;
                    charArray[i-1] = '-'; 
                }                
                list.Add(new string(charArray));
            }
            return list;
        }
//using Substring() mehthod
        public static List<string> Flip2(string s) {
            List<string> list = new List<string>();
            for (int i = 1; i < s.Length; i++) {
                if (s[i] == '+' && s[i-1] == '+') {
                    var newStr = s.Substring(0,i-1) + "--" + s.Substring(i + 1);
                    list.Add(newStr);
                }
            }
            return list;
        }
        static void Main(string[] args)
        {
            string s = "++++";            
            var result = Flip2(s);
            result.ForEach(item => Console.WriteLine(item));
        }
    }
}

// using List instead of array; cause array does not have add/push method to insert new item;
