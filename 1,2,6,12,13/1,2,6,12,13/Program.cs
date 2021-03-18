using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2_6_12_13
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Cut(ref text);
            Console.ReadKey();
        }
        public static void Cut(ref string text)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            int minIndex = int.MaxValue;
            int maxIndex = int.MinValue;
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]) == true)
                {
                    if (text[i] > max)
                    {
                        max = text[i];
                        maxIndex = i;
                    }
                }
            }
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]) == true)
                {
                    if (text[i] < min)
                    {
                        min = text[i];
                        minIndex = i;
                    }
                }
            }
            text = text.Remove(maxIndex, 1);
            text = text.Remove(minIndex, 1);
            Console.WriteLine(text);
        }
    }
}
