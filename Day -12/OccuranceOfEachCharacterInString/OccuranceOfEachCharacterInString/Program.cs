using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OccuranceOfEachCharacterInString
{
    internal class Program
    {
        public void Countcharacter()
        {
            Console.WriteLine("Enter Your String :- ");
            string input=Convert.ToString(Console.ReadLine());

            Dictionary<char, int> cCount = new Dictionary<char, int>();

            foreach (var c in input)
            {
                if (c != ' ')
                {
                    if (!cCount.ContainsKey(c))
                    {
                        cCount.Add(c, 1);
                    }
                    else
                    {
                        cCount[c]++;
                    }
                }

            }
            foreach (var character in cCount)
            {
                Console.WriteLine("{0} - {1}", character.Key, character.Value);
            }
        }
        static void Main(string[] args)
        {
            Program p =new Program();
            p.Countcharacter();
            Console.ReadLine();
        }
    }
}
