using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home1
{
    internal class Program
    {
        private static void HomeWork1(int number)
        {
            if (number >= 1 && number <= 100)
            {
                if (number % 3 == 0 && number % 5 == 0)
                {
                    Console.WriteLine("Fizz Buzz");
                }
                else if (number % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (number % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(number);
                }
            }
        }
        private static void HomeWork2(double num, double procent)
        {
            double percent = num / 100 * procent;
            Console.WriteLine($"{procent} процентов от числа {num} = " + percent);
        }
        private static void HomeWork3()
        {
            string[] number;
            string num = Console.ReadLine();
            number = num.Split(' ', ',');
            foreach (string s in number)
            {
                Console.Write(s);
            }
            Console.WriteLine();
        }
        private static void HomeWork4()
        {
            char[] number = Console.ReadLine().ToCharArray();
            if (number.Length == 6)
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                if (n1 >= 0 && n1 < 6 && n2 >= 0 && n2 < 6)
                {
                    char temp = number[n1];
                    number[n1] = number[n2];
                    number[n2] = temp;

                }
                Console.WriteLine(number);
            }
            else Console.WriteLine("Число не 6- значное", number);
        }
        private static void HomeWork5()
        {
            string data = Console.ReadLine();
            DateTime dateTime = DateTime.Parse(data);

            switch (dateTime.Month)
            {
                case 1:
                case 2:
                case 12:
                    Console.Write("Зима ");
                    break;
                case 3:
                case 4:
                case 5:

                    Console.Write("Весна ");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.Write("Лето ");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.Write("Осень ");
                    break;
            }
            Console.WriteLine(dateTime.DayOfWeek);
        }
        private static void HomeWork6()
        {
            double temper = double.Parse(Console.ReadLine());
            Console.WriteLine("Цельсий ->1\nФаренгейт ->2");
            int n = int.Parse(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Console.WriteLine((temper - 32) * 5 / 9);
                    break;
                case 2:
                    Console.WriteLine((temper * 9 / 5) + 32);
                    break;
            }
        }
        private static void HomeWork7(int a,int b)
        {
            string count;
            for (int i = Math.Min(a, b); i <= Math.Max(a, b); i++)
            {
                if (i % 2 == 0)
                {
                    count = i.ToString();
                    Console.Write(count+" ");
                }
            }
            Console.WriteLine();
        }
        
        static void Main(string[] args)
        {
            // HomeWork1(15);
            // HomeWork2(87, 3);
            // HomeWork3();
            // HomeWork4();
            // HomeWork5();
            // HomeWork6();
            // HomeWork7(24, 11);
        }
        
    }
}
