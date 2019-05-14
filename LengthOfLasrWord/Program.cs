using System;

namespace LengthOfLasrWord
{
    class Program
    {
        public static int lengthOfLastWord (string s)
        {
            //TrimEnd() remove space at the last
            string[] strs = s.TrimEnd().Split(' ');
            var length = strs.Length;
            return strs[length - 1].Length;
        }
        public static int lengthOfLastWord2 (string s)
        {
            int length = s.Length;
            int i = length - 1;
            int count = 0;
            // start from tail - skip spaces
            while(i>=0 && s[i]==' ') i--;
            // length of next word
            while(i>=0 && s[i]!=' ') 
            {
                count++;
                i--;
            }
            return count;
        }
        static void Main(string[] args)
        {
            string s = "Hello World   ";
            var result = lengthOfLastWord(s);
            var result2 = lengthOfLastWord2(s);
            Console.WriteLine(result);
            Console.WriteLine(result2);

        }
    }
}
