using System;

namespace RemoveElement
{
    class Program
    {
        public static int RemoveElement(int[] A, int val)
        {
            var count = 0;
            int l = A.Length;
            for (int i = 0; i < l; i++)
            {
                if (A[i] != val)
                    A[count++] = A[i];
            }
            return count;
        }
        static void Main(string[] args)
        {
            int[] A = new int[] {2 ,3 ,3 ,4 ,5 ,6};
            var result = RemoveElement(A,3);
            Console.WriteLine("so tm what+ {0}", result);
        }
    }
}
