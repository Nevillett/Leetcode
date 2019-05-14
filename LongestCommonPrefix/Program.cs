using System;
using System.Text;

namespace LongestCommonPrefix
{
    class Program
    {
        public static string longestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0 || strs == null) return "" ;
            //string res = new string("");
            StringBuilder res = new StringBuilder();
            for ( int j = 0; j < strs[0].Length; j++ )
            {
                char c = strs[0][j];
                for ( int i = 1; i < strs.Length; i++)
                {
                    if (j >= strs[i].Length || strs[i][j] != c)
                    return res.ToString();
                }
                //res += char.ToString(c);
                res = res.Append(c);
            }
            return res.ToString();
        }   
        static void Main(string[] args)
        {
            //test("hello");
            string[] strs = new string[]{"flower", "flow", "flight"};
            var result = longestCommonPrefix(strs);
            Console.WriteLine(result);
        }
    }
}


// check char and string type and varify char.ToString() can + ;

    // public static void test(string str)
    // {
    //     char c = str[1];
    //     char cc = str[2];
    //     Console.WriteLine(c.GetType());
    //     Console.WriteLine(cc);

    //     string x = char.ToString(c);
    //     string y = char.ToString(cc);
    //     Console.WriteLine(x.GetType());
        
    //     var result = x + y;
    //     Console.WriteLine(x+y);
    //     Console.WriteLine(result);
    //     Console.WriteLine(result.GetType());
    // }



