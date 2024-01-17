using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialNumber
{
    internal class Program
    {
        //FactorialNumber means multiplication of all integers from 1 to given Number
        //suppose number is 4 
        // 24 = 4*3*2*1 mhnje 1 la 1 ni divide kel output madhe store next i = 2 zhala
        // output 1 je hot te 1*2 aani output madhe store kel now output 2 zhal aani 2*3=6
        // 6 he output aani 6*4 = 24; condition madhe check zhal output <= 4 ;
        // now condition false zhali aani  end zhal 
        public void FactorialByUser()
        {
            Console.WriteLine("Enter Your Number :- ");
            int input =Convert.ToInt32(Console.ReadLine());
            int output = 1;
            for (int i = 1; i <= input; i++)
            {
                output = output * i;
            }
            Console.WriteLine(output);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.FactorialByUser();
            Console.ReadLine();
        }
    }
}
