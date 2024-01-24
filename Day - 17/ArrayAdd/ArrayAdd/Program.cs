using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAdd
{
    internal class Program
    {
        public void ArraSquare()
        {
            Console.WriteLine("Enter Numbers to create Square :- ");
            int[,] a = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Your Array Output Square :- ");
            for (int i = 0;i < 3; i++)
            {
                for(int j = 0;j < 3; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
           p.ArraSquare();
            Console.ReadLine();
        }
    }
}
