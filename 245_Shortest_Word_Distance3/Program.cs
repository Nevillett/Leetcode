using System;

namespace _245_Shortest_Word_Distance3
{
    class Program
    {
        public static int shortestDistance(string[] words ,string word1, string word2) {
            int index1 = -1, index2 = -1, min = int.MaxValue;

            for (int i = 0; i < words.Length; i++) {
                int temp = index1; // set a temp pointer for tracking index1 last time value;
                
                // not sure about these three  if , cannot use else if anywhere; 
                // also has other ways to solve , didnt dig into it..

                if (words[i] == word1) {
                    index1 = i;
                } 
                if (words[i] == word2) {
                    index2 = i;
                }

                // Console.WriteLine("this is {0} times loop", i);
                // Console.WriteLine("this time words[i] = {0}", words[i]);
                // Console.WriteLine(" index1 = {0},       index2 = {1}", index1, index2);
                // Console.WriteLine(" temp = {0}", temp);
                
                if (index1 != -1 && index2 != -1) {
                     if (word1 == word2 && temp != -1 && temp != index1) {
                        Console.WriteLine("word1 == word2!!!");
                        min = Math.Min(min, Math.Abs(temp - index1));
                     } else if (index1 != index2) {
                        min = Math.Min(min, Math.Abs(index2 - index1));
                     }
                }
            }
            return min;
        }

        public static int shortestDistance2(string[] words, string word1, string word2) 
        {
            int index1 = -1, index2 = -1, min = int.MaxValue;

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == word1)
                    index1 = i;
                if (words[i] == word2)
                {
                    if (word1 == word2) {
                        index1 = index2; // i do not know why do this ?????????? it works
                    }
                    index2 = i;
                }
                if (index1 != -1 && index2 != -1) {
                    min = Math.Min(min, Math.Abs(index1 - index2));
                }
            }
            return min;
        }
        static void Main(string[] args)
        {
            string[] words = new string[]{"practice", "makes", "makes", "perfect", "makes", "coding"};
            string word1 = "makes";
            string word2 = "makes";
            var result = shortestDistance2(words, word1, word2);

            Console.WriteLine(result);
        }
    }
}
