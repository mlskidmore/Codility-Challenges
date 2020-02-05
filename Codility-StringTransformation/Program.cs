using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility_StringTransformation
{
    class Program
    {
        static void Main(string[] args)
        {
            string S1 = "ACCAABBC";
            solution(S1);

            string S2 = "ABCBBCBA";
            solution(S2);

            string S3 = "BABABA";
            solution(S3);

            string S4 = "ABCCBAABCCBA";
            solution(S4);

            Console.ReadLine();
        }

        public static string solution(string S)
        {
            int index = 0;

            while (S.Contains("AA") || S.Contains("BB") || S.Contains("CC"))
            {
                while (S.Contains("AA"))
                {
                    index = S.IndexOf("AA");
                    S = S.Remove(index, 2);
                }

                while (S.Contains("BB"))
                {
                    index = S.IndexOf("BB");
                    S = S.Remove(index, 2);
                }

                while (S.Contains("CC"))
                {
                    index = S.IndexOf("CC");
                    S = S.Remove(index, 2);
                }
            }

            Console.WriteLine("S: " + S);
            return S;
        }
    }
}
