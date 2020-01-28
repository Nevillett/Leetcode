using System;

namespace _274_H_Index
{
    class Program
    {   
        public static int HIndex(int[] citations) {
            Array.Sort(citations);
            Array.Reverse(citations);
            Console.WriteLine(string.Join("," , citations));
            for (int i = 0; i < citations.Length; i++) {
                if (i >= citations[i]) 
                return i;
            }
            return citations.Length;
        }
        static void Main(string[] args)
        {
            int[] citations = new int[]{3,0,6,1,5};
            var result = HIndex(citations);
            Console.WriteLine(result);
        }
    }
}
