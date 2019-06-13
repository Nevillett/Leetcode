using System;
using System.Text;

namespace _151_Reverse_Words_inString
{
    class Program
    {
        public static string ReverseWordsInString(string s)
        {
            string[] words = s.Trim().Split(' ');
            Array.Reverse(words);
            return String.Join(" ", words);
        }
        public static string ReverseWordsInString2(string s)
        {
            string[] words = s.Trim().Split(' ');
            StringBuilder sb = new StringBuilder();
            for (int i = words.Length - 1; i >= 0; i--)
            {
                //StringBuilder sb = new StringBuilder();
                sb.Append(words[i]);                
                sb.Append(" ");
            }
            return sb.ToString();        
        }

        static void Main(string[] args)
        {
            string s = "the sky is blue ";
            var result = ReverseWordsInString(s);
            Console.WriteLine(result);
            var result2 = ReverseWordsInString2(s);
            Console.WriteLine(result2);
        }
    }
}
