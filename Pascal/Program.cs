using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pascal
{
    internal class Program
    {
        public const int distance = 3;
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк : ");
            int n = int.Parse(Console.ReadLine());
            do
            {

                if (n >= 0)
                {
                    Console.Clear();
                }
                else
                {
                    Console.Write("Введите коректное число : ");
                    n = int.Parse(Console.ReadLine());
                    continue;
                }
                break;
            }
            while (true);


            int[][] triangle = new int[n][];
            int[] triangle2 = new int[n];
             // первая строка
            triangle[0] = new int[] { 1 };

            for (int i = 1; i < triangle.Length; i++)
            {

                triangle[i] = new int[i + 1];
                for (int j = 0; j <= i; j++)
                {

                    if (j == 0 || j == i)
                        triangle[i][j] = 1;
                    else
                    {
                        if(i == triangle.Length -1)
                        {
                            triangle2[j] = triangle[i - 1][j - 1] + triangle[i - 1][j];

                        }
                    
                        triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
                    }
                }
            }
            Array.Sort(triangle2);
            Array.Reverse(triangle2);
            int len = triangle2[0].ToString().Length;
            int left = len * n;

            for (int i = 0; i < triangle.Length; i++)
            {
                
                for (int j = 0; j <= i; j++)
                {
                    Console.SetCursorPosition(left, i + 1);
                    Console.Write($"{triangle[i][j]}");
                    left += len * 2;
                }
                left = len * n - len * (i + 1);

                Console.WriteLine();
            }


            Console.ReadKey();



        }
    }
}
