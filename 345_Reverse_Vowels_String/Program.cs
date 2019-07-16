using System;
using System.Linq;
using System.Text;

namespace _345_Reverse_Vowels_String
{
    class Program
    {
        public static string ReverseVowels(string s) {
            var charStr = s.ToCharArray();
            var left = 0;
            var right = charStr.Length - 1;
            char[] vowels = new char[] {'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'}; 
            //var vowels = new HashSet<char>("aeiouAEIOU");

            while (left < right)
            {
                if (!vowels.Contains(charStr[left]))
                {
                    left++;
                } else if (!vowels.Contains(charStr[right]))
                {
                    right--;
                } else {
                    var temp = charStr[left];
                    charStr[left] = charStr[right];
                    charStr[right] = temp;
                    left++;
                    right--;
                }   
            }
         
            return new string(charStr);
        }
        // way 2
        public static bool isVowel(char c)
        {
            return c == 'a'|| c == 'e' || c == 'i'|| c == 'o' || c == 'u' || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U';
        }
        public static string ReverseVowels2(string s) {
            StringBuilder sb = new StringBuilder(s); //only use stringbuilder can do the string[index1] = string[index2]
            int left = 0 , right = s.Length - 1;
            while (left < right)
            {
                if ( isVowel(sb[left]) && isVowel(sb[right]))
                {
                    var temp = sb[left];
                    sb[left] = sb[right];
                    sb[right] = temp;
                    left++;
                    right--;
                    //Console.WriteLine("{0},{1}", left, right);
                } else if ( isVowel(sb[left])){
                    --right;
                } else {
                    ++left;
                }
            }
            return sb.ToString();
        }
        static void Main(string[] args)
        {
            char c = 'a';
            var result = isVowel(c);
            Console.WriteLine(result);

            string test = "hEllO";
            var result2 = ReverseVowels(test);
            Console.WriteLine(result2);

            string test2 = "leetcode";
            var result3 = ReverseVowels2(test2);
            Console.WriteLine(result3);
        }
    }
}
