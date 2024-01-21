using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareAndNinetyDegreeStar
{
    internal class Program
    {

        //here we are making the square 
        // step 1 create 1 st loop to create 5/numbers of column 
        // step 2 inside such loop craate nested loop which has condition to run 5 times
        // step 3 after running 5 star it comes outside and again run up to length condition of base for loop 
        public void Square()
        {
            for (int i = 1; i <= 5; i++)
            {
                for(int A = 1;A<= 5; A++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        //here we are making 90 degree's star 
        //step 1 create  1st base for loop having 5/number of row condtion
        //step 2 inside base forloop write nested for loop initialization is 1 and condition runs upto parent length 
        //in this star will be printed upto the the no of row 
        public void NinetyStar()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int A= 1; A <= i; A++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// here we are making upper and lower 90 degree star 
        /// step 1 = it has same condtion as 90 degree star
        /// step 2 = only chage in nested for loop has initialization 
        /// as parent length and condition as same condition of base for loop 
        /// </summary>
        public void NinetyUpperLower() 
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int A = 1; A <= i; A++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 1; i <=4 ; i++)
            {
                for (int B = i; B <= 4; B++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
           
        }
        static void Main(string[] args)
        {
            Program p =new Program();
            //p.Square();
            //p.NinetyStar();
            p.NinetyUpperLower();
            Console.ReadLine();
        }
    }
}
