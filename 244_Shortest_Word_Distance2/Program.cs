using System;
using System.Collections.Generic;

namespace _244_Shortest_Word_Distance2
{
    class Program
    {
        class words{
            public string[] wordList;
            private Dictionary<string, List<int>> dic = new Dictionary<string, List<int>>();
            public words(String[] words) {
                //wordList = new string[]{"practice", "makes", "coding", "perfect", "makes"}; 
                this.wordList = words;                           
                for (int i = 0; i < words.Length; i++ ) {
                    if ( dic.ContainsKey(words[i])) 
                        dic[words[i]].Add(i);
                    else { 
                        List<int> l = new List<int>();
                        l.Add(i);
                        dic.Add(words[i], l);
                    }
                }                
            }

            public int shortestDistance(string word1, string word2) {
                List<int> index1 = dic[word1];
                List<int> index2 = dic[word2];
                int distance = int.MaxValue;
                
                // time: O(m * n)
                // for (int i = 0; i < index1.Count ; i ++) {
                //     for (int j = 0; j < index2.Count; j++) {
                //         distance = Math.Min(Math.Abs(index1[i] -index2[j]), distance);        
                //     }
                // }                                  
                // return distance;

                // time: O(m + n)   not really understand
                // need two index, initial value = 0; then compale the value, move the smaller one's index back one digit, until Traversal all this array;
                int i = 0, j = 0;
                while ( i < index1.Count && j < index2.Count) {
                    distance = Math.Min(distance, Math.Abs(index1[i] - index2[j]));
                    if (index1[i] < index2[j]) 
                        i++;
                    else 
                        j++;
                }
                return distance;
            }
    
        }


        static void Main(string[] args)
        {
            string[] words = new string[]{"practice", "makes", "coding", "perfect", "makes"};

            words ws = new words(words);
            var result = ws.wordList;
            Console.WriteLine(string.Join(',', result));


           

            string word1 = "practice";
            string word2 = "coding";

            var num = ws.shortestDistance(word1, word2);
            Console.WriteLine(num);

            
        }
    }
}
