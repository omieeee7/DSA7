using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoReverseAndPalendrome
{
    internal class Program
    {
     public void CheckPalindrome()
        {
            Console.WriteLine("Enter a number: ");
            int input = Convert.ToInt32(Console.ReadLine());
            int temp = input;
            int output = 0;

            while (input != 0)
            {
                int rem = input % 10;
                output = output * 10 + rem;
                input = input / 10;
            }

            if (temp == output)
            {
                Console.WriteLine(temp + " is a palindrome number.");
            }
            else
            {
                Console.WriteLine(temp + " is not a palindrome number.");
            }
        }




        static void Main(string[] args)
        {
            Program program = new Program();
            program.CheckPalindrome();
            Console.ReadLine();
        }
    }
}
