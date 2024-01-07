using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicing
{
    internal class Program
    {
        public string DuplicateCharInString(string Data)
        {
            string garbage = "";
            string Output = "";
            foreach (char c in Data)
            {
                if(garbage.IndexOf(c) == -1)
                {
                    garbage += c;
                    Output += c;
                }
            }
            return garbage;
        }
        static void Main(string[] args)
        {
            Program p =new Program();
            Console.WriteLine(p.DuplicateCharInString("Omkkkarr"));
            Console.ReadLine();
        }
    }
}
