using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoSwapByThirdAndWithotThird
{
    internal class Program
    {
        //There are two ways of swapping 
        // by using third  var and without third var
        //both are simple 
        //by third var is :-
        //                       temp = Number1;
        //                       Number1 = Number2;
        //                       Number2 = temp;
        // 
        // Withot third var :- 
        //                       Number1 =Number1 + Number2;
        //                       Number2 = Number1 - Number2;
        //                       Number1 =Number1 - Number2;
        public void SwapusingThirdVariable()
        {
            int Number1 = 10;
            int Number2 = 20;
            int temp;
            Console.WriteLine("Number before Swapping a={0},b={1}",Number1,Number2);

            temp = Number1;
            Number1 = Number2;
            Number2 = temp;
            Console.WriteLine("Number after Swapping a={0},b={1}", Number1, Number2);
        }

        public void SwapWithoutThirdVariable()
        {
            int Number1 = 10;
            int Number2 = 20;
            Console.WriteLine("Number before Swapping a={0},b={1}", Number1, Number2);
            Number1 =Number1 + Number2;
            Number2 = Number1 - Number2;
            Number1 =Number1 - Number2;
            Console.WriteLine("Number after Swapping a={0},b={1}", Number1, Number2);

        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.SwapusingThirdVariable();
            //p.SwapWithoutThirdVariable();
            Console.ReadLine();
        }
    }
}
