using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Calculate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите тип перевода:");
            Console.WriteLine("1 - Из десятичной в двоичную");
            Console.WriteLine("2 - Из десятичной в шестнадцатеричную");
            Console.WriteLine("3 - Из двоичной в десятичную");
            Console.WriteLine("4 - Из шестнадцатеричной в десятичную");
            string choice = Console.ReadLine();
            Console.Write("Введите число: ");
            string input = Console.ReadLine();
            try
            {
                switch (choice)
                {
                    case "1":
                        int type1 = int.Parse(input);
                        Console.WriteLine("Результат: " + Convert.ToString(type1, 2));
                        break;

                    case "2":
                        int type2 = int.Parse(input);
                        Console.WriteLine("Результат: " + Convert.ToString(type2, 16));
                        break;

                    case "3":
                        int type3 = Convert.ToInt32(input, 2);
                        Console.WriteLine("Результат: " + type3);
                        break;

                    case "4":
                        int type4 = Convert.ToInt32(input, 16);
                        Console.WriteLine("Результат: " + type4);
                        break;

                    default:
                        Console.WriteLine("Неправильный выбор. Попробуйте снова.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: неверный формат числа.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка: число выходит за пределы допустимого диапазона.");
            }        
        }
    }
}
