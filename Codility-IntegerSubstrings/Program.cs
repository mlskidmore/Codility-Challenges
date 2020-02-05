using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Codility_IntegerSubstrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 53;
            int b = 1953786;

            int position = solution(a, b);

            Console.WriteLine("Found {0} at position {1}", a, position + "\n");

            long c = 1553545355343;

            Regex regex = new Regex(Convert.ToString(a));

            foreach(Match match in regex.Matches(Convert.ToString(c)))
            {
                Console.WriteLine("Found {0} at position {1}", match.Value, match.Index);
            }

            Console.ReadLine();
        }

        public static int solution(int A, int B)
        {
            int position = Convert.ToString(B).IndexOf(Convert.ToString(A));

            if (position >= 0)
                return Convert.ToString(B).IndexOf(Convert.ToString(A));
            else
                return -1;
        }
    }
}
