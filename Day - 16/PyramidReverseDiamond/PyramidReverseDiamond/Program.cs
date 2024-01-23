using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyramidReverseDiamond
{
    internal class Program
    {
        void diamond()
        {
            int i, j;
            for (i = 1; i <= 5; i++)
            {
                for (j = 4; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                for (j = 2; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (i = 1; i <= 5; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 4; j >= i; j = (j - 1))
                {
                    Console.Write("*");
                }
                for (j = i; j <= 3; j = j + 1)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Program p=new Program();
            p.diamond();
            Console.ReadLine();
        }
    }
}
