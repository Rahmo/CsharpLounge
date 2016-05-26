using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
namespace CsharpLounge
{
    class ExcOnline1
    {
        /*Write a function that takes a list of strings an prints them, one per line, in a rectangular frame. 
         * For example the list ["Hello", "World", "in", "a", "frame"] gets printed as:
        *********
        * Hello *
        * World *
        * in    *
        * a     *
        * frame *
        ********* 
        */
     static List<string> arrStr = new List<string> { "Worlds aaaff", "Hello", "in", "a", "Framess" };
 
            //this sorts the vals from longest to shortest.
         int LongesLength =  arrStr.OrderByDescending(s => s.Length).First().Length;

        public void run()
        {
           Console.WriteLine(this.printAllStarts());
            IEnumerable<string> results = arrStr.Select(a => a.ToString());

            foreach (var str in results )
            { 
                  Console.WriteLine("* " + DoPadding(str) +" *"); 
            }
            Console.WriteLine(this.printAllStarts());
            Console.ReadLine();
        }

        public StringBuilder printAllStarts()
        {
            try
            {
            int Length = this.LongesLength + 4; 
            StringBuilder sb = new StringBuilder( );
            for (int i = 0; i < Length ; i++)
            {
                sb.Append("*");
            }
            return sb; 
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public StringBuilder DoPadding(string s)
        {
            try
            {
                 int LengthDif = this.LongesLength - s.Length ;
                 StringBuilder sb = new StringBuilder();
                    sb.Append(s);
                    for (int i = 0; i < LengthDif; i++)
                    {
                        sb.Append(" ");
                    }
                    return (sb);
               }
            catch (Exception e)
            {   
                throw e;
            }
        }
    }

}
