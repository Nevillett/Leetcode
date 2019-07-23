using System;

namespace _242_Valid_Anagram
{
    class Program
    {
        public static bool IsAnagram (string s, string t) {
            if (s.Length != t.Length)
            return false;

            char[] source = s.ToCharArray(), target = t.ToCharArray();

            Array.Sort(source);
            Array.Sort(target);

            for (int i = 0; i < s.Length; i++) {
                if (source[i] != target[i])
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            string s = "rat";
            string t = "car";
            var result = IsAnagram(s, t);

            Console.WriteLine(result);
        }
    }
}
