using System;

namespace _186_Reverse_String_II
{
    class Program
    {
        public static void reverseWords(char[] chars)
        {            
            int left = 0, n = chars.Length;
            for (int i = 0;  i <= n; ++i)
            {
                // first reverse each words
                if (i == n || chars[i] == ' ')
                {
                    Reverse(chars, left, i-1);
                    left = i + 1;
                }
                //Console.WriteLine(chars);
            }
            // second reverse all the char string
            Reverse(chars, 0, n-1);
            Console.WriteLine(chars);
        }


        public static void Reverse(char[] chars, int left, int right )
        {
            while (left < right)
            {
                char t = chars[left];
                chars[left] = chars[right];
                chars[right] = t;
                ++left; --right;
            }
        }



        static void Main(string[] args)
        {
            string s = "the sky is blue";
            reverseWords(s.ToCharArray());
        }
    }
}
