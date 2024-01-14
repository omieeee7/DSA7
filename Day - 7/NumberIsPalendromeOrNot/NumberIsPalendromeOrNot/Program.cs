using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberIsPalendromeOrNot
{
    internal class Program
    {
        public void NumberIsPalendromeOrNot()
        {
            Console.WriteLine("Enter your Number");
            int Input = Convert.ToInt32(Console.ReadLine());
            int rem; 
            int output = 0;
            int temp = Input;
            while (Input > 0)
            {
                rem=Input%10;
                output = (output * 10) + rem;    //here we use simple codition we made int output and assigned as 0 and use for storing and if
                                                 //you trying to store by simply just output = rem it just repeated one time and over if we
                                                 //entered 123 output will be 3 and as know that this over not ans that's why it says not
                                                 //palendrome so this is not over ans we use condition output = (output*10)+rem;
                Input =Input/10;

            }
            Console.WriteLine("Your Output will be : "+output);
            if (temp == output)
            {
                Console.WriteLine(output+" is palendrome number");
            }
            else
            {
                Console.WriteLine(output+" is not palendrome number");
            }

        }
        static void Main(string[] args)
        {
            Program p =new Program();
            p.NumberIsPalendromeOrNot();
            Console.ReadLine();
        }
    }
}
