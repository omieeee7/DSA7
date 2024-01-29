using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeries
{
    internal class Program
    {
        public void Fibonacci()
        {
            Console.WriteLine("Enter Number of Length Of series :-");
            int input=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your Series will Be :- ");
            int Number1 = 0;
            int Number2 = 1;
            int sum;
                for(int i = 0; i < input; i++)
                {
                    sum = Number1 + Number2;
                    Console.WriteLine(sum);
                    Number1 = Number2;
                    Number2 = sum;

                }
        }

        static void Main(string[] args)
        {
            Program p =new Program();
            p.Fibonacci();
            Console.ReadLine();
        }
    }
}
