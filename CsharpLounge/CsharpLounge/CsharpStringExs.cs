using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine(strcap1+" capital check is "+instance.isCapitalOnly(strcap1) + " \n" + strcap2 +
                " capital check is "+ instance.isCapitalOnly(strcap2));
       

            Console.Read();
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
/        bool isPalindrome(string str)
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


    }
}
