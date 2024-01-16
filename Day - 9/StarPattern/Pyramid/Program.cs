using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyramid
{
    internal class Program
    {

        public void StarTriangle()
        {
            for(int i = 1; i <= 5; i++)
            {
                for(int j=5;j>=i; j--)
                {
                    Console.Write(" ");
                }
                for(int k=1;k<=i; k++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Program p=new Program();
            p.StarTriangle();
            Console.ReadLine();
        }
    }
}
