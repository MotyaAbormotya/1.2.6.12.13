using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {

            int days = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            СhoosingZodiacSign(days, month);
            Console.ReadKey();
        }
        public static void СhoosingZodiacSign(int days, int month)
        {
            if (days >= 1 && days <= 31 && month == 1)
            {
                Console.WriteLine("Водолей");
            }
            else
            if (days >= 1 && days <= 28 && month == 2)
            {
                Console.WriteLine("Рыбы");
            }
            else
            if (days >= 1 && days <= 31 && month == 3)
            {
                Console.WriteLine("Овен");
            }
            else
            if (days >= 1 && days <= 31 && month == 4)
            {
                Console.WriteLine("Телец");
            }
            else
            if (days >= 1 && days <= 31 && month == 5)
            {
                Console.WriteLine("Блицнезы");
            }
            else
            if (days >= 1 && days <= 31 && month == 6)
            {
                Console.WriteLine("Рак");
            }
            else
            if (days >= 1 && days <= 31 && month == 7)
            {
                Console.WriteLine("Лев");
            }
            else
            if (days >= 1 && days <= 31 && month == 8)
            {
                Console.WriteLine("Дева");
            }
            else
            if (days >= 1 && days <= 31 && month == 9)
            {
                Console.WriteLine("Весы");
            }
            else
            if (days >= 1 && days <= 31 && month == 10)
            {
                Console.WriteLine("Скорпион");
            }
            else
            if (days >= 1 && days <= 31 && month == 11)
            {
                Console.WriteLine("Стрелец");
            }
            else
            if (days >= 1 && days <= 31 && month == 12)
            {
                Console.WriteLine("Козерог");
            }
        }
    }
}
