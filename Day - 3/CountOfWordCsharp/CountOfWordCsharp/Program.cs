using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOfWordCsharp
{
    class Program
    {
       public void CharCountWithSpace()
        {

            string str = "omkar";
            int tem = 0;
            tem = str.Count();
            {
                Console.WriteLine("count=" + tem);
            }

        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.CharCountWithSpace();
            Console.ReadLine();
        }
    }
}
