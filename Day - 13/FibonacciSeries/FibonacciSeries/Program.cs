using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeries
{
    internal class Program
    {
        //Fibonacci number :- it is series of number starts from 0 and 1. Next number will be the sum of last two numbers
        public void Fibonacci()
        {
            int number1 = 0;
            int number2 = 1;
            int sum;
            Console.WriteLine(number1);
            Console.WriteLine(number2);
       
                for (int i = 0; i < 10; i++)
                {
                    sum = number1 + number2;
                    Console.WriteLine(sum);
                    number1 = number2;
                    number2 = sum;

                }
        }
        static void Main(string[] args)
        {
            Program p = new Program();  
            p.Fibonacci();
            Console.ReadLine();
        }
    }
}
