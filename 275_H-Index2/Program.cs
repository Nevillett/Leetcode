using System;

 //in the 274 : we try to find the last one >= its index, 
 //now we find the first one >= its index.
namespace _275_H_Index2
{
    class Program
    {
        public static int HIndex(int[] citations) {
            int len = citations.Length,
            left = 0,
            right = len - 1;

            while(left <= right) {
                int mid = (right + left)/2 ;

                if (citations[mid] == len -mid) return len-mid;
                else if (citations[mid] > len -mid) right = mid -1;
                else left = mid + 1;
            }
            return len - left;
        }

        static void Main(string[] args)
        {
            int[] citations = new int[]{3,3,5,8,25};
            var result = HIndex(citations);
            Console.WriteLine(result);
        }
    }
}
