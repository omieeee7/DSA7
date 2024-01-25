using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DualArrayAdd
{
    internal class Program
    {
        void arrayadd()
        {
            int[,] A = new int[3, 3];
            int[,] B = new int[3, 3];
            int[,] C = new int[3, 3];
            int i, j;
            Console.WriteLine("Enter Your 1St array values :-");
            for ( i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    A[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter your 2nd Array :- ");
            for(i = 0; i < 3; i++)
            {
                for(j = 0;j < 3; j++)
                {
                    B[i,j]=Convert.ToInt32(Console.ReadLine());
                }
            }
            for(i = 0;i < 3; i++)
            {
                for( j = 0;j < 3; j++)
                {
                    C[i, j] = A[i, j] + B[i,j];
                } 
            }

            Console.WriteLine("Your Array Addition = ");
            for(i = 0; i < 3; i++)
            {
                for(j=0;j < 3; j++)
                {
                    Console.Write(C[i,j]+" ");
                }
                Console.WriteLine();
            }
        }


static void Main(string[] args)
        {

            Program p = new Program();
            p.arrayadd();
            Console.ReadLine();
        }
    }
}
