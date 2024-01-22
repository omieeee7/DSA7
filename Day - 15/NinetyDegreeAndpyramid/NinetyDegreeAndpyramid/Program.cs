using System;

namespace NinetyDegreeAndPyramid
{
    internal class Program
    {
        // Method to print a pyramid pattern
        public void Pyramid()
        {
            // Outer loop controls the number of rows in the pyramid (5 rows in this case)
            for (int i = 1; i <= 5; i++)
            {
                // Inner loop for printing spaces before the asterisks on each row
                for (int space = 5; space >= i; space--)
                {
                    Console.Write(" ");
                }

                // First inner loop for printing the first set of asterisks on each row
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                // Second inner loop for printing the second set of asterisks on each row
                for (int k = 2; k <= i; k++)
                {
                    Console.Write("*");
                }

                // Move to the next line after completing a row
                Console.WriteLine();
            }
        }


        void userDefinePyramid()
        {
            // Declare variables for row, column, and user input
            int i, j, n;

            // Prompt the user to enter the number of rows for the pyramid
            Console.WriteLine("Enter the number of rows: ");

            // Read and convert user input to an integer
            n = Convert.ToInt32(Console.ReadLine());

            // Outer loop to control the number of rows in the pyramid
            for (i = 1; i <= n; i++)
            {
                // Inner loop to print spaces before the asterisks on each row
                for (j = n; j >= i; j--)
                {
                    Console.Write(" ");
                }

                // First inner loop to print the first set of asterisks on each row
                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                // Second inner loop to print the second set of asterisks on each row
                for (int k = 2; k <= i; k++)
                {
                    Console.Write("*");
                }

                // Move to the next line after completing a row
                Console.WriteLine();

                // Increment the value of 'j', but this seems unnecessary and can be removed
                j++;
            }
        }



        // Main method, the entry point of the program
        static void Main(string[] args)
        {
            // Create an instance of the Program class
            Program p = new Program();

            // Call the Pyramid method to print the pattern

            // calls hardcoded
            //p.Pyramid();

            //to call user define
            p.userDefinePyramid();

            Console.ReadLine();
        }
    }
}
