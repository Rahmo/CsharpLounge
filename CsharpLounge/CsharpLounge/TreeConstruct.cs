using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization.Configuration;

namespace CsharpLounge
{
    class Node
    {
       
            public string value;
            public Node left;
            public Node right;

            private Node Right
            {
                get
                {
                    return right;
                }

                set
                {
                    right = value;
                }
            }
            private Node Left
            {
                get
                {
                    return left;
                }

                set
                {
                    left = value;
                }
            }
            public Node(string val)
            {
                this.value = val;
            }



        }
        //2*5+7*20     -->                    + 
        //                                  /     \
        //                                 *       *
        //                               /   \    /   \
        //                              2   5  7  20
       static public class Solution
        {
            static Node tree = new Node("+")
            {
                left = new Node("*")
                {
                    left = new Node("2"),
                    right = new Node("5")
                },
                right = new Node("*") { left = new Node("7"), right = new Node("20") }

            };

            static public string result = ReconstructFromTreeToString(tree);

           static string ReconstructFromTreeToString(Node root)
           {

            
             string result = "";
               if (root == null)
               {
                   return "";
               }

              
               else
               {

                int temp;
                   int temp2; 
                   bool isChildPrint = true;

          string rootval = root.value;
                Node Current = root; 
                   string result1 = ReconstructFromTreeToString(Current.left);
                   string result2; 
                  
                     result2 = Current.value;
                
                string result3 = ReconstructFromTreeToString(Current.right);


                   if (int.TryParse(result1, out temp) && int.TryParse(result3, out temp))
                   {
                    isChildPrint = false; 
                   }
                   if (result1 != "" && result3 != "" && isChildPrint == false )
                   {


                       result = "(" + result1 + result2 + result3 + ")";
                   }
                   
                   else 
                   {
                    result = result1 + result2 + result3;
                }
               }
               //TODO Your logic is here.
          

        return result; //The result must be returned.
            } }
        }
    

