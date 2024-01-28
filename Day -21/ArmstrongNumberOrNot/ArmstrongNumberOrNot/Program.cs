using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongNumberOrNot
{
    internal class Program
    {
        public void armstrongnumercheck() 
        {
            // list of all armstrong numbers :- 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 153, 370, 371, 407;
            Console.WriteLine("Enter Your input :-");
            int input = Convert.ToInt32(Console.ReadLine());
            int rem;
            int cube;
            int output = 0;
            int temp = input;
            while(input > 0)
            {
                rem = input % 10;
                cube = rem * rem * rem;
                output += cube;
                input=input / 10;
            }
            Console.WriteLine("Your output is "+output);
            if (output == temp)
            {
                Console.WriteLine("This number is Armstrong");
            }
            else
            {
                Console.WriteLine("This number is not Armstrong number");
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.armstrongnumercheck();
            Console.ReadLine();
        }
    }
}
