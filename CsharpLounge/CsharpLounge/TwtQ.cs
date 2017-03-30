using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLounge
{
    class TwtQ
    {

        static void strairCase(int n)
        {
            int j = n;
            for (int i = 0; i <= n; i++)
            {
                for (j = n; j >= 0; j--)
                {
                    if (j <= i)
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
            Console.ReadLine();
        }

        static void WhatKindOfTriAgnle()
        {
            var res = "";
            var n = Console.ReadLine();
            int inputs = Convert.ToInt32(n);
            for (int i = 0; i < inputs; i++)
            {
                string[] tokens = new string[3];
                tokens = Console.ReadLine().Split();
                int a = int.Parse(tokens[0]);
                int b = int.Parse(tokens[1]);
                int c = int.Parse(tokens[2]);
                if (a == b && b == c)
                    Console.WriteLine("Equilateral");
                else if (a >= (b + c) || c >= (b + a) || b >= (a + c))
                    Console.WriteLine("Not a triangle");
                else if ((a == b && b != c) || (a != b && c == a) || (c == b && c != a))
                    Console.WriteLine("Isosceles");
                else if (a != b && b != c && c != a)
                    Console.WriteLine("Scalene");
            }
        }
    }
}
