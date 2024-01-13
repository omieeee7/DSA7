using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    internal class Program
    {
        void ReverseNumbers()
        {
            Console.WriteLine("Enter Your Number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int rem;
            Console.Write(" Your Reverse number is ");
            while (num > 0)
            {
                rem = num % 10;
                Console.Write(rem);
                num = num / 10;
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.ReverseNumbers();
            Console.ReadLine();
        }
    }
}
