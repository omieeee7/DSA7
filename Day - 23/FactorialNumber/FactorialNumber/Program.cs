using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialNumber
{
    internal class Program
    {
        public void FindFactorial()
        {
            Console.WriteLine("Enter Number To Find Factorial Of It :-");
            int input=Convert.ToInt32(Console.ReadLine());
            int Output = 1;
            for (int i = 1; i <= input; i++)
            {
                 Output = Output * i;
            }
            Console.WriteLine("your Factorial Number Is :- "+Output);

        }
        static void Main(string[] args)
        {
            Program p =new Program();
            p.FindFactorial();
            Console.ReadLine();
        }
    }
}
