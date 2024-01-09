using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringIsPalendromeOrNot
{
    internal class Program
    {
        public string Operation()
        {
            //here we inserting hardcoded value omkar this not palendrome no
            //another e.g madam is palendrome 
            //palendrome no means if we are reading any value if such value is same from both side such number is palendrome
            string Data = "omkar";
            string Output = "";
            //data.length-1 means full string value as we know that if we view any value then such values index number starsts 
            // from 0 to length so for removing 0 we are - minusing 1 from length 
            for(int i = Data.Length - 1; i >= 0; i--)
            {
                Output += Data[i];
            }
            Console.WriteLine("Input is "+Data+" The Output is "+Output);
            if (Data == Output)
            {
                Console.WriteLine("This is Palendrome No");
            }
            else
            {
                Console.WriteLine("This is not Palendrome No");
            }
            return Output;
        }
        static void Main(string[] args)
        {
            Program p =new Program();
            Console.WriteLine(p.Operation());
            Console.ReadLine();
        }
    }
}
