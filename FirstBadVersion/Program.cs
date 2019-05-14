using System;

namespace FirstBadVersion
{

    class Program
    {
        static bool isBadVersion(int version)
        {
            if (version > 5)
            return true;
            else
            return false;
        }
        public static int firstBadVersion(int n)
        {
            int left = 1;
            int right = n;
            while(left < right)
            {
                int mid = left + (right - left) / 2;
                if (isBadVersion(mid))
                right = mid;
                else 
                left = mid + 1;
            }
            return left;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var result = firstBadVersion(8);
            Console.WriteLine(result); 
        }
    }
}
