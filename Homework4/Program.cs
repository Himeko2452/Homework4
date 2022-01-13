using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"{ "Месяць",7} | {"Доход, тыс. руб",30} | { "Расход, тыс. руб",30} | { "Прибыль, тыс. руб",30}");
            int[] income = new int[12];
            int[] cost = new int[12];
            int[] result = new int[12];
            int[] month = new int[12];
            int a = 0; // Переменная для отр прибыли
            int b = 0; // Переменная для пол. прибыли
            int c = 0;
            Random random = new Random();

            for (int i = 0; i < income.Length; i++)
            {
                income[i] = random.Next(0, 100) * 100;
                cost[i] = random.Next(100) * 100;
                result[i] = income[i] - cost[i];
            }
            int[] result2 = result;
            for (int i = 0; i < income.Length; i++)
            {
                month[i] = i + 1;
                Console.WriteLine($"{month[i],4} {income[i],30} {cost[i],30} {result2[i],30}");
            }
            // Вывод месяцев с пол. прибилью
            
            Console.WriteLine("\n Месяцы с положительной прибилью:");
            for (int i = 0; i < result2.Length; i++)
            {
                if (result2[i] > 0)
                {
                    b++;
                }

            }
            Console.WriteLine($"{b}");
            //Вывод месяцев с отр. прибылью
            Console.WriteLine("\n Месяцы с отрицательной прибилью:");
            for (int i = 0; i < result2.Length; i++)
            {
                if (result2[i] < 0)
                {
                    a++;
                }

            }
            Console.WriteLine($"{a}");

            // Вывод 3 или более худших месяцев
            Array.Sort(result2, month);
            Console.WriteLine("\n Худшая прибыль в месяцах:");

            for (int j = 0; j < result2.Length; j++)
            {
                if (j < 3)
                {
                    c = month[j];
                    Console.WriteLine($" {c}");
                }
                else if (j >= 4 && c == month[j])
                {
                    Console.WriteLine($" {c}");
                }

            }
            Console.ReadKey();



        }
                
    }
}
