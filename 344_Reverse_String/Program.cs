using System;
using System.Text;

namespace _344_Reverse_String
{
    class Program
    {
        public static string reverseString(char[] s)    
        {
            StringBuilder sb = new StringBuilder();
            foreach( char c in s)
            {
                sb.Insert(0, c);
            }
            return sb.ToString();
        }
       
       public static string reverseString2(char[] s)
       {
           Array.Reverse(s);
           return new string(s);           
       }

       public static string reverseString3(char[] s)
       {
           int left = 0, right = s.Length - 1;
           while (left < right)
           {
               char t = s[left];
               s[left++] = s[right];
               s[right--] = t;
           }
           return new string (s);
       }
        static void Main(string[] args)
        {
            char[] s = new char[] {'h', 'e', 'l', 'l', 'o'};
            // just test :......
            var x= s.ToString();
            Console.WriteLine(x);
            Console.WriteLine(new string(s)[1]);
            Console.WriteLine("*************");

            var result = reverseString(s);    
            var result2 = reverseString2(s);
            var result3 = reverseString3(s);            

            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
        }
    }
}
