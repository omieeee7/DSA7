using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverse
{
    internal class Program
    {
        public void StringReverse()
        {
            string input;
            string output="";
            Console.WriteLine("Enter Your String :-");
            input = Convert.ToString(Console.ReadLine());
            string temp = input;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                output += input[i];
            }
            Console.WriteLine("Your Output is = "+output);
            Console.WriteLine(output +" is Output and Input is "+temp);
            if(temp == output)
            {
                Console.WriteLine("String is palendrome");
            }
            else
            {
                Console.WriteLine("String is not palendrome");

            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.StringReverse();
            Console.ReadLine();
        }
    }
}
