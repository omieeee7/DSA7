using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTwoStringReverse
{
    internal class Program
    {
       public string ReverseTheString()
        {
            string Data = "omkar";
            string Output = "";
            for(int i=Data.Length-1; i>=0; i--)
            {
                Output+= Data[i];
            }
            return Output;
        }
        
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.ReverseTheString());
            Console.ReadLine();
        }
    }
}
