using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;




/// <summary>
///  Created by Abdulrahman on 2016-1-19.
/// </summary>
namespace CsharpLounge
{
    class CsharpStringExs
    {//1

        static void Main(string[] args)
        {

            //Setup 11
            CsharpStringExs instance = new CsharpStringExs();

            //Ex.1  Reverse a word Charactrers 
            string strTest = "Rahmo";
            string result = instance.ReverseString(strTest);
            Console.WriteLine(result);

            //Ex.2 Reverse the words in a sentence 
            String strTest2 = "Hello, It's me ;)";
            string result2 = instance.ReverseSentence(strTest2);
            Console.WriteLine(result2);

            //Ex.3 check if string is palindrome 
            string pan1 = "cocoococ";
            string pan2 = "qqaabb";
            Console.WriteLine(pan1 + " palindrome check is " + instance.isPalindrome(pan1) + " \n" + pan2 +
                              " palindrome check is " + instance.isPalindrome(pan2));


            //Ex.4 Check if String contains Only Capital Charactars
            string strcap1 = "Reeefe";
            string strcap2 = "SWEET";
            Console.WriteLine(strcap1 + " capital check is " + instance.isCapitalOnly(strcap1) + " \n" + strcap2 +
                              " capital check is " + instance.isCapitalOnly(strcap2));

            int[] reArrange = new[] {1, 2, 3, 4, 5, 6, 7};
            string reArrangeStr = String.Join(",", reArrange).ToString();
            string result1 = String.Join(",", instance.arrangeMaxMInts(reArrange)).ToString();

            Console.WriteLine("Rearrange an array in maximum minimum of " + reArrangeStr + " is: " + result1);
            //Ex.5 Arrang array Input  : 
            // arr[] = {1, 2, 3, 4, 5, 6, 7} 
            // Output: arr[] = { 7, 1, 6, 2, 5, 3, 4 }

            Console.WriteLine(Solution.result);

            int[] arr = {1,2,3,3,2,1,3};
            Console.WriteLine(" the Number Occurring Odd Number of Times " + instance.findNumberOccuringOdd(arr));


             string Rahm = "Rahmo";
            //string Rahm = "Rssmoo";
            Console.WriteLine(" isUnique check  " + instance.isUniqueChar(Rahm));


            Console.Read();
        }

        bool isUniqueChar(string s)
        {
            //this ensure all char are asci char 
            if (s.Length > 128) return false;
         
            bool[] check  = new bool[128];

            for (int i = 0; i < s.Length; i++)
            {
                //this will return the asci number of the char that is less than 128 
                int val = s[i];

                //means if the value is in the check boolean
                if (check[val])
                {
                    return false;
                }

                //Save in the boo array number [Char] true
                check[val] = true; 

            }
            return true;
        }

        //with while loop 
        int[] arrangeMaxMInts(int[] Arr)
        {
            int n = Arr.Length;
            int i = 0;
            int k = n - 1;
            int[] arr1 = new int[n];
            int m = 0;
            while (i <= k)
            {
                if (i == k)
                {
                    arr1[m] = Arr[i];
                }
                else {
                    arr1[m] = Arr[k];
                    arr1[m + 1] = Arr[i];
                }
                i++;
                k--;
                m = m + 2;
            }
            return arr1;

        }


        /// <summary>
        /// Reverses the string.
        /// Convert the str to charArray so we can use the method Reverse that. 
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns>System.String.</returns>
        string ReverseString(string str)
        {
            if (str == null) return null;
            char[] strToChar = str.ToCharArray();
            Array.Reverse(strToChar);
            return new string(strToChar);
        }


        string ReverseSentence(string str)
        {
            string result = String.Join(" ", str.Split(' ').Reverse());
            return result; 
        }


        /// <summary>
        /// Determines whether [is capital only] [for any given string].
        /// the idea is to convert the str to char array and then check IsUpper from Char library for char in the array
        /// </summary>
        bool isCapitalOnly(string str)
        {
            char[] CharArray = str.ToCharArray();
            for(int i = 0 ; i <= CharArray.Length -1 ;i++)
            {
                if (!Char.IsUpper(CharArray[i])) return false;
            }
         
            return true; 
        }




        /// <summary>
        /// Determines whether the specified string is papalindrome. 
        /// Converts the string into char array and refer to the start index to the end and compare consequetivly 
        /// and make the for loop stop in the mid /2 
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns><c>true</c> if the specified string is papalindrome; otherwise, <c>false</c>.</returns>
        bool isPalindrome(string str)
        {
            if (str == null)
            {
                return false;
            }

            char[] strChar = str.ToCharArray();
            for (int i = 0; i <= strChar.Length  / 2 ; i++)
            {
                if (strChar[i] != strChar[strChar.Length - i - 1])
                {
                    return false; 
                }
            }

            return true; 
        }

        public int findNumberOccuringOdd(int[] arr)
        {

            int count = 0;
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {

                count = 0;

                for (int j = 0; j < n; j++)
                {

                    if (arr[i] == arr[j])
                    {

                        count++;

                    }

                }

                if (count % 2 != 0)

                    return arr[i];

            }

            return -1;

        }



    }
     

   
    
}
