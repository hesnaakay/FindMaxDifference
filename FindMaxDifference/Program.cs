using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = {1, 1, 1, 1, 1, 1};
            int result = FindMaxDifference(inputArray);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        private static int FindMaxDifference(int[] inputArray)
        {
            int max = 0;
            for (int i = 0; i < inputArray.Length; i++ )
            {
                if(i == 0)
                {
                    max = Math.Abs(inputArray[i] - inputArray[i + 1]);
                }
                else if (i == (inputArray.Length - 1))
                {
                    if (max < (Math.Abs(inputArray[i - 1] - inputArray[i])))
                        max = Math.Abs(inputArray[i - 1] - inputArray[i]);
                }
                else
                {
                    if (max < (Math.Abs(inputArray[i - 1] - inputArray[i])))
                        max = Math.Abs(inputArray[i - 1] - inputArray[i]);
                    if (max < (Math.Abs(inputArray[i - 1] - inputArray[i])))
                        max = Math.Abs(inputArray[i - 1] - inputArray[i]);
                }
                
            }
            return max;
        }
    }
}
