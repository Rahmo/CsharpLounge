using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLounge
{
    class NumberExs
    {
        public void run()
        {
            #region  
            // Generate a sequence of three integers starting at 4, 
            // and then select their squares.
            //Range function has two inputs the start number and the count 
            IEnumerable<int> squares = Enumerable.Range(4, 3).Select(x => x * x);
            
            foreach (int num in squares)
            {
                Console.WriteLine(num);
            }
            #endregion
            #region PrimeSieve
            //            *Computes the number of primes less than or equal to N using

            //*the Sieve of Eratosthenes
            IEnumerable<int> numbers = Enumerable.Range(0, 100);
            int count =  this.FindPrimeSievecounts(numbers, 25);
           Console.WriteLine(count);

            #endregion

            Console.Read();
        }


        /// <summary>
        /// Reverse a number using string 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int reverse(int n)
        {
            string input = n.ToString();
            string result = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                result = result + input[i];
            }
            int reversedInt = int.Parse(result);
            return reversedInt;
        }


        int FindPrimeSievecounts(IEnumerable<int> nums, int n)
        {
            int result = 0;
            if (n < nums.Min() || n > nums.Max())
            {
                return 0;
            }
            else
            {
                for (int i = 2 ; i < n; i++)
                {
                    int currentN = nums.ElementAt(i);
                    if (currentN % 2 != 0)
                    {
                        result = result + 1; 
                    }
                }
                return result;
            }
           
        }
    }
}
