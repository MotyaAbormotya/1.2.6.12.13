using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] text = new int[3, 5];
            Random random = new Random();

            for (int i = 0; i < text.GetLength(0); i++)
            {
                for (int j = 0; j < text.GetLength(1); j++)
                {
                    text[i, j] = random.Next(1, 15 + 1);
                    Console.Write(text[i, j] + " ");
                }
                Console.WriteLine();
            }

            Arifmetic(text);
            Console.ReadKey();
        }

        public static void Arifmetic(int[,] text)
        {
            int result = 0;
            int index = 1;
            int arifmetic = 0;

            for (int i = 0; i < text.GetLength(0); i++)
            {
                arifmetic += text[0, i];
            }

            arifmetic /= text.GetLength(1);

            for (int i = 1; i < text.GetLength(0); i++)
            {
                for (int j = 0; j < text.GetLength(1); j++)
                {
                    result += text[i, j];
                }
                result /= text.GetLength(0);
                if (arifmetic < result)
                {
                    arifmetic = result;
                    index = i + 1;
                }
                result = 0;
            }

            Console.WriteLine(index);
        }
    }
}
