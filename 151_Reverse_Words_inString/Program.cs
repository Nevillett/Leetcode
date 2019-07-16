using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _151_Reverse_Words_inString
{
    class Program
    {
        public static string ReverseWordsInString(string s)
        {
            // using regular expression to split extra whitespace in the middle of the string
            string[] words =  Regex.Split( s.Trim() , @"\s+" );   // or @" +"
            Array.Reverse(words);
            return String.Join(" ", words);
        }
        public static string ReverseWordsInString2(string s)
        {
            // not using regex to split, output wrong when there are whitespaces in the middle of the string 
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
        public static void TrimandReplace()
        {
            var tmp = "   hello    world   ";
            var res1 = tmp.Trim();
            var res2 = tmp.Replace(" ", String.Empty);
            System.Console.WriteLine(res1);
            System.Console.WriteLine(res2);
        }

        static void Main(string[] args)
        {
            string s = " hello      world!  ";
            var result = ReverseWordsInString(s);
            Console.WriteLine(result);
            var result2 = ReverseWordsInString2(s);
            Console.WriteLine(result2);
            Console.WriteLine("*****************");
            TrimandReplace();

        }
    }
}
