using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNoOrNot
{
    internal class Program
    {
        public void Prime()
        {
            Console.WriteLine("Enter your No :- ");
            int input =Convert.ToInt32(Console.ReadLine());
            while (input != 0)
            {
                if (input % 2 == 0)
                {
                    Console.WriteLine("This is Prime Number");
                    break;
                }
                else
                {
                    Console.WriteLine("This is Not Prime Number");
                    break;
                }
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Prime();
            Console.ReadLine();
        }
    }
}
