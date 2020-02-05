using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Codility_IncrementArrayPositions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = new int[] { 0, 4, 3, 9, 9 };
            solution(Numbers);

            Console.ReadLine();
        }

        public static int[] solution (int[] A)
        {
            int[] tempArray = new int[A.Length];

            if (Array.TrueForAll(A, n => n >= 0 && n <= 9))
            {
                Console.WriteLine("A contains only integers 0 to 9 ...");

                if (A[0] != 0)
                {
                    // Convert the array to a string
                    string tempString = String.Join("", A.Select(p => p.ToString()).ToArray());
                    Console.WriteLine("Numbers: " + tempString);

                    // Convert the string to an integer;
                    int tempInt = Convert.ToInt32(tempString);                    
                    //Console.WriteLine("tempInt " + tempInt);

                    // Increment the integer.
                    tempInt++;
                    //Console.WriteLine("tempInt: " + tempInt);

                    // Convert the integer into an integer array
                    tempArray = digitArr(tempInt);
                    Console.WriteLine("[" + string.Join(", ", tempArray) + "]");
                }
                else
                {
                    Console.WriteLine("A has a leading 0 ...");
                    Array.Resize(ref tempArray, 0);
                    Console.WriteLine("[" + string.Join(", ", tempArray) + "]");
                }
            }

            else
            {
                Console.WriteLine("A contains other integers ...");
                Array.Resize(ref tempArray, 0);
                Console.WriteLine("[" + string.Join(", ", tempArray) + "]");
            }

            return tempArray;
        }
        public static int[] digitArr(int n)
        {
            if (n == 0)
                return new int[1] { 0 };

            var digits = new List<int>();

            for (; n != 0; n /= 10)
                digits.Add(n % 10);

            var arr = digits.ToArray();
            Array.Reverse(arr);

            return arr;
        }
    }
}
