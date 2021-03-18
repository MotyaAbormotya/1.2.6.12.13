using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            IsLetter(ref text);
            Console.ReadKey();
        }

        public static void IsLetter(ref string text)
        {
            int letter = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLetter(text[i]) == true)
                {
                    letter++;
                }
            }
            Console.WriteLine(letter);
        }
    }
}
