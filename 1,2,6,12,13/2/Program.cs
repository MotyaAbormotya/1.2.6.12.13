using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Сut(ref text);
            Console.ReadKey();
        }
        public static void Сut(ref string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]) == true)
                {
                    text = text.Remove(i, 1);
                }
            }
            Console.WriteLine(text);
        }
    }
}
