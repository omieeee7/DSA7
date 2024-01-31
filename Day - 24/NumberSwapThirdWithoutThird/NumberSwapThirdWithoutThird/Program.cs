using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSwapThirdWithoutThird
{
    internal class Program
    {
        private void NumberSwapWithThird()
        {
            int NumberOne = 10;
            int NumberTwo=20;
            int Swapper;
            Console.WriteLine("Number Before swapping Number One "+NumberOne+" Number Two "+NumberTwo);
            Swapper = NumberOne;
            NumberOne = NumberTwo;
            NumberTwo = Swapper;
            Console.WriteLine("Number After swapping Number One " + NumberOne + " Number Two " + NumberTwo);
        }

        private void NumberSwapWithoutThird()
        {
            int NumberOne = 13;
            int NumberTwo = 20;
            Console.WriteLine("Number Before swapping Number One " + NumberOne + " Number Two " + NumberTwo);
            NumberOne = NumberOne + NumberTwo;
            NumberTwo = NumberOne - NumberTwo;
            NumberOne= NumberOne - NumberTwo;
            Console.WriteLine("Number After swapping Number One = {0} , Number Two = {1}",NumberOne,NumberTwo);

        }
        static void Main(string[] args)
        {
            Program p =new Program();
            //p.NumberSwapWithThird();
            p.NumberSwapWithoutThird();
            Console.ReadLine();
        }
    }
}
