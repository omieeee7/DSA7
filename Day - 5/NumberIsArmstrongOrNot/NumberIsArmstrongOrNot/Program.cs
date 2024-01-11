using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberIsArmstrongOrNot
{
    internal class Program
    {
        public void Armstrong()
        {    //153 number is armstrong
            //any  other number like 159,252 if we taken in our input then no is 
            int input = 153;
            int rem;
            int cube;
            int output=0;
            int temp = input;

            while (input != 0)
            {
                rem = input%10;
                cube = rem * rem * rem;
                output = output + cube;
                input = input / 10;
            }
            input = temp;
            if (input == output)
            {
                Console.WriteLine( input+" number is armstrong");
            }
            else
            {
                Console.WriteLine(input+" No is not armstrong");
            }
        }

        static void Main(string[] args)
        {
            Program p=new Program();
            p.Armstrong();
            Console.ReadLine();
        }
    }
}
