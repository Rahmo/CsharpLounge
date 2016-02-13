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

            //Ex.1
            string strTest = "Rahmo";
            string result = instance.ReverseString(strTest);
            Console.WriteLine(result);

            //Ex.2
            String strTest2 = "Hello, It's me ;)";
            string result2 = instance.ReverseSentence(strTest2); 
            Console.WriteLine(result2);

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

       
    }
}
