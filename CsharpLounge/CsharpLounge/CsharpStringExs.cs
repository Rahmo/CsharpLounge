using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;


/// <summary>
///  Created by Abdulrahman on 2016-1-19.
/// </summary>
namespace CsharpLounge
{
    class CsharpStringExs
    { 
      
      public void run() { 

           
            // Print # in  descent triangle
            int num = 6;
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= num; j++)

                {
                    if ((i + j) > num)
                    {

                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();

            }
        
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

            string perm1 = "sumit";
            string perm2 = "tiums";
            Console.WriteLine(" Permutation check  " + instance.CheckPermutation(perm1, perm2));


           
            string UrlFyMe = "12   f";
            Console.WriteLine(" Permutation check  " + instance.urlfy(UrlFyMe,5));

            // Example Check if the first letter is capital in a typcal word 
            string Testword = "rahmo";
            Console.WriteLine(CheckCab(Testword).ToString() + " Check cab resultss");


            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);
            list.AddLast(5);
 

            int n = Console.Read();
            Console.WriteLine(n);
            for (int i = 0 ; i <= n; i++ )
            {
                int FirstSide = Console.Read();
                int SecondSide = Console.Read();
                int ThirdSide = Console.Read();
                if (FirstSide == SecondSide && FirstSide == ThirdSide)
                {
                    Console.WriteLine("Equilateral");
                }
                else if (FirstSide == SecondSide || FirstSide == ThirdSide)
                {
                    Console.WriteLine("Isosceles");
                }
                else
                {
                    Console.WriteLine("None of these");
                }
            }


            Console.WriteLine(" the list conents  " + list.Last.Value.ToString());
            //135789
            ListNode listNode = new ListNode(1);
            listNode.AddToTail(2);
            listNode.AddToTail(3);
            listNode.AddToTail(4);
            listNode.AddToTail(5);
            listNode.AddToTail(6);

            ListNode listNode2 = new ListNode(1);
            listNode2.AddToTail(2);
            listNode2.AddToTail(3);


            ListNode OddevenNode = listNode.reversell(listNode);
             OddevenNode = listNode.OddEvenList(listNode);

            while (OddevenNode.next != null)
            {
                
                Console.WriteLine(OddevenNode.val.ToString());
                if (OddevenNode.next != null)
                {
                    OddevenNode = OddevenNode.next; 
                }
               
            }

  
               
            Console.ReadLine();
        }
        //  public class ListNode
        //  {
        //public int val;
        //public ListNode next;
        //public ListNode(int x) { val = x; }

        //      public void printvals(ListNode n)
        //      {
        //          if (n == null) return ;
        //          while (n.next != null)
        //          {
        //              Console.WriteLine(n.val);
        //          }
        //      }
        //  }
        //public Node OddEvenList(LinkedList<int> head)
        //{
            

        //}
        string urlfy(string UrlChars, int length)
        {

    
            //1 ) finding the proper size of the string by counting the spaces 
            int spaces = 0, newlength , i ;
            for (i = 0 ; i < length; i++)

                if ( UrlChars[i].ToString() == " " )
                {
                    spaces++;
                }
            newlength = length + spaces * 2 ; 



            return  spaces.ToString(); 
        }

        /// <summary>
        /// 1) Sort the chac of the string using Array.sort() 
        /// 2) check if the two string are equal afetr the sort 
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        bool CheckPermutation(string s1, string s2)
        {
            if (s1.Length != s2.Length)
            return false;
            return  SortArrayChar(s1).Equals(SortArrayChar(s2));
        }
        // Helper methid for the permutation checing example
       public string SortArrayChar(string str)
        {
            if (str.Length <= 0 ) return "";

            
            char[] CharStr = str.ToCharArray();
            //This will sort according to the chr value from small to big 
            Array.Sort(CharStr);

            return new string(CharStr);
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

        /// <summary>
        /// This methos checks if the word has a first char as a prober upper case. 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool CheckCab(string str)
        {
            if (str == "") return false;
            char[] CharStr = str.ToCharArray();

            if (Char.IsUpper(CharStr[0]))
            {
                return true;
            }

            return false; 
        }

        public void findOccuringStringsInPhrase()
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            string sInput = "Hello World, This is a great World. I love this great World";
            sInput = sInput.Replace(",", ""); //Just cleaning up a bit
            sInput = sInput.Replace(".", ""); //Just cleaning up a bit
            string[] arr = sInput.Split(' '); //Create an array of words

            foreach (string word in arr) //let's loop over the words
            {
                if (word.Length >= 3) //if it meets our criteria of at least 3 letters
                {
                    if (dictionary.ContainsKey(word)) //if it's in the dictionary
                        dictionary[word] = dictionary[word] + 1; //Increment the count
                    else
                        dictionary[word] = 1; //put it in the dictionary with a count 1
                }
            }

            foreach (KeyValuePair<string, int> pair in dictionary) //loop through the dictionary
                Console.WriteLine(string.Format("Key: {0}, Pair: {1}<br />", pair.Key, pair.Value));

        }



        /// <summary>
        /// Given an array of positive integers. All numbers occur even number of times except one number which occurs odd number of times. Find the number in O(n) time & constant space.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
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
