using System;
using System.Collections.Generic;

namespace _243_Shortest_Word_Distance
{
    class Program
    {
        public static int shortestDistance(string[] words, string word1, string word2)
        {   
            int len = words.Length;
            int index1 = -1, index2 = -1, min = int.MaxValue ;
            

            for (int i = 0; i < len; i++)
            {
                if (words[i] == word1) 
                    index1 = i;
                else if (words[i] == word2)
                    index2 = i;
                
                if (index1 != -1 && index2 != -1)  // if find word1 and word2, save the samller distance
                {               
                System.Console.WriteLine(" this is {0} times, index1 = {1}", i, index1);
                System.Console.WriteLine(" this is {0} times, index2 = {1}", i, index2);
                
                System.Console.WriteLine( "the min number is " + min);
                System.Console.WriteLine( "the distance between each two words = " + Math.Abs(index1 - index2));
                // Math.Min(a, b) 
                    //Math.Abs(a - b)
                min = Math.Min(min, Math.Abs(index1 - index2));                
                }
            }
            return min;
        }
        
        static void Main(string[] args)
        {
            string[] words = new string[]{"practice", "makes", "coding", "perfect", "makes"};
            string word1 = "makes";
            string word2 = "coding";
            var result = shortestDistance(words, word1, word2);

            Console.WriteLine(result);
        }
    }
}
