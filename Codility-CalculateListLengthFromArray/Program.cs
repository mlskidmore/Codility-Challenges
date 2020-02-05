using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility_CalculateListLengthFromArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] { 1, 4, -1, 3, 2 };

            solution(A);

            Console.ReadLine();
        }
        
        public static int solution(int[] A)
        {
            //int length = 0;

            int ans = 1, cur = 0;

            while ( A[cur] != -1)
            {
                cur = A[cur];
                ans++;
            }

            Console.WriteLine("Length: " + ans);
            return ans;

            //return length;
        }
    }
}
