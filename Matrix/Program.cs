using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool isExit = false;
            do
            {
                int[,] matrix;
                int[,] matrix2;
                int[,] matrix3;
                Console.WriteLine("Введите количество строк 1 матрицы:");
                int a = Convert.ToInt32(Console.ReadLine());
                do
                {
                    
                    if (a >= 0)
                    {
                        
                    }
                    else
                    {
                        Console.WriteLine("Введите коректное число");
                        a = int.Parse(Console.ReadLine());
                        continue;
                    }
                    break;
                }
                while (true);
                Console.WriteLine("Введите количетсво столбцов 1 матрицы:");
                int b = Convert.ToInt32(Console.ReadLine());
                do
                {

                    if (b >= 0)
                    {

                    }
                    else
                    {
                        Console.WriteLine("Введите коректное число");
                        b = int.Parse(Console.ReadLine());
                        continue;
                    }
                    break;
                }
                while (true);
                Console.WriteLine("\n============");
                matrix = new int[a, b];
                Random rnd = new Random();
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = rnd.Next(100);
                        Console.Write($"{matrix[i, j]}\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("============\n");
                Console.WriteLine("Введите количество строк 2 матрицы:");
                int c = Convert.ToInt32(Console.ReadLine());
                do
                {

                    if (c >= 0)
                    {

                    }
                    else
                    {
                        Console.WriteLine("Введите коректное число");
                        c = int.Parse(Console.ReadLine());
                        continue;
                    }
                    break;
                }
                while (true);
                Console.WriteLine("Введите количество столбцов 2 матрицы:");
                int d = Convert.ToInt32(Console.ReadLine());
                do
                {

                    if (d >= 0)
                    {

                    }
                    else
                    {
                        Console.WriteLine("Введите коректное число");
                        d = int.Parse(Console.ReadLine());
                        continue;
                    }
                    break;
                }
                while (true);
                
                Console.WriteLine("\n============");
                

                matrix2 = new int[c, d];
                

                for (int i = 0; i < matrix2.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix2.GetLength(1); j++)
                    {
                        matrix2[i, j] = rnd.Next(100);
                        Console.Write($"{matrix2[i, j]}\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("============\n");
                Console.ReadKey();

                Console.Clear();
                Console.WriteLine("Выбирите пункт от 1 до 4");
                Console.WriteLine("Пункт 1 = умножение матрицы на число");
                Console.WriteLine("Пункт 2 = сложение матриц");
                Console.WriteLine("Пункт 3 = вычетание матриц");
                Console.WriteLine("Пункт 4 = умножение матриц");
                Console.WriteLine("Если хотите выйти введите exit");


                string current = Console.ReadLine();
                Console.Clear();
                if (int.TryParse(current, out int userAnswer))
                {
                    switch (userAnswer)
                    {
                        case 1:
                            Console.WriteLine("Умножение матрицы на число");

                            Console.WriteLine("Введите число на которое хотите умножить матрицу:");
                            int e = Convert.ToInt32(Console.ReadLine());
                            do
                            {

                                if (e >= 0)
                                {

                                }
                                else
                                {
                                    Console.WriteLine("Введите коректное число");
                                    e = int.Parse(Console.ReadLine());
                                    continue;
                                }
                                break;
                            }
                            while (true);
                            matrix3 = new int[matrix.GetLength(0), matrix.GetLength(1)];

                            for (int i = 0; i < matrix.GetLength(0); i++)
                            {
                                for (int j = 0; j < matrix.GetLength(1); j++)
                                {
                                    matrix3[i, j] = matrix[i, j] * e;
                                }

                            }
                            for (int i = 0; i < matrix.GetLength(0); i++)
                            {

                                for (int j = 0; j < matrix.GetLength(1); j++)
                                {
                                    if (i == matrix.GetLength(0) / 2 && j == 0)
                                    {
                                        Console.Write($" {e}  Х");
                                    }

                                    Console.Write($"\t{matrix[i, j]}");
                                    if (i == matrix.GetLength(0) / 2 && j == matrix.GetLength(1) - 1)
                                    {
                                        Console.Write($"  =  ");
                                    }

                                }
                                for (int j = 0; j < matrix.GetLength(1); j++)
                                {
                                    Console.Write($"\t{matrix3[i, j]}");
                                }
                                Console.WriteLine();
                            }
                            break;
                        case 2:
                            Console.WriteLine("Сложение матриц");
                            if (a == c && b == d)
                            {
                                matrix3 = new int[matrix.GetLength(0), matrix.GetLength(1)];
                                for (int i = 0; i < matrix.GetLength(0); i++)
                                {
                                    for (int j = 0; j < matrix.GetLength(1); j++)
                                    {
                                        matrix3[i, j] = matrix[i, j] + matrix2[i, j];
                                    }

                                }
                                for (int i = 0; i < matrix.GetLength(0); i++)
                                {

                                    for (int j = 0; j < matrix.GetLength(1); j++)
                                    {

                                        Console.Write($"{matrix[i, j]}\t ");
                                        if (i == matrix.GetLength(0) / 2 && j == matrix.GetLength(1) - 1)
                                        {
                                            Console.Write($" + ");
                                        }



                                    }
                                    for (int j = 0; j < matrix.GetLength(1); j++)
                                    {
                                        Console.Write($"\t{matrix2[i, j]}");
                                        if (i == matrix2.GetLength(0) / 2 && j == matrix.GetLength(1) - 1)
                                        {
                                            Console.Write($"  =  ");
                                        }
                                    }
                                    for (int j = 0; j < matrix.GetLength(1); j++)
                                    {
                                        Console.Write($"\t{matrix3[i, j]}");
                                    }
                                    Console.WriteLine();
                                }
                            }
                            else
                            {
                                Console.WriteLine("Заданны неверные размеры матрицы");

                            }
                            break;
                        case 3:
                            Console.WriteLine("Вычетание матриц");
                            if (a == c && b == d)
                            {
                                matrix3 = new int[matrix.GetLength(0), matrix.GetLength(1)];
                                for (int i = 0; i < matrix.GetLength(0); i++)
                                {
                                    for (int j = 0; j < matrix.GetLength(1); j++)
                                    {
                                        matrix3[i, j] = matrix[i, j] - matrix2[i, j];
                                    }

                                }
                                for (int i = 0; i < matrix.GetLength(0); i++)
                                {

                                    for (int j = 0; j < matrix.GetLength(1); j++)
                                    {

                                        Console.Write($"{matrix[i, j]}\t ");
                                        if (i == matrix.GetLength(0) / 2 && j == matrix.GetLength(1) - 1)
                                        {
                                            Console.Write($" - ");
                                        }

                                    }
                                    for (int j = 0; j < matrix.GetLength(1); j++)
                                    {
                                        Console.Write($"\t{matrix2[i, j]}");
                                        if (i == matrix2.GetLength(0) / 2 && j == matrix.GetLength(1) - 1)
                                        {
                                            Console.Write($"  =  ");
                                        }
                                    }
                                    for (int j = 0; j < matrix.GetLength(1); j++)
                                    {
                                        Console.Write($"\t{matrix3[i, j]}");
                                    }
                                    Console.WriteLine();
                                }
                                 
                            }
                            else
                            {
                                Console.WriteLine("Заданны неверные размеры матрицы");

                            }
                            break;
                        case 4:
                            Console.WriteLine("Умножение матриц");
                            if (b ==c)
                            {
                                matrix3 = new int[matrix.GetLength(0), matrix2.GetLength(1)];
                                for (int i = 0; i < matrix3.GetLength(0); i++)
                                {
                                    for (int j = 0; j < matrix3.GetLength(1); j++)
                                    {
                                        for (int k = 0; k < matrix.GetLength(1); k++)
                                        {
                                            matrix3[i, j] += matrix[i, k] * matrix2[k, j];
                                        }
                                    }
                                }
                                int g;
                                if (a > c)
                                    g = a;
                                else
                                    g = c;
                                for (int i = 0; i < g; i++)                                    
                                { 
                                    for (int j = 0; j < matrix.GetLength(1); j++)
                                    {   if( a > i)
                                        {
                                            Console.Write($"{matrix[i, j]}\t ");
                                            if (i == matrix.GetLength(0) / 2 && j == matrix.GetLength(1) - 1)
                                            {
                                                Console.Write($" X ");
                                            }

                                        }
                                        else
                                        {
                                            Console.Write(" \t");
                                        }
                                        

                                    }
                                    for (int j = 0; j < matrix2.GetLength(1); j++)
                                    {
                                        if( c > i)
                                        {
                                            Console.Write($"\t{matrix2[i, j]}");
                                            if (i == matrix2.GetLength(0) / 2 && j == matrix2.GetLength(1) - 1)
                                            {
                                                Console.Write($"  =  ");
                                            }

                                        }
                                        else
                                        {
                                            Console.Write(" \t");
                                        }
                                    }
                                    for (int j = 0; j < matrix3.GetLength(1); j++)

                                    {
                                        if (a > i)
                                        {
                                            Console.Write($"\t{matrix3[i, j]}");
                                        }
                                        
                                        else
                                        {
                                            Console.Write(" \t");
                                        }
                                    }
                                    Console.WriteLine();
                                }

                            }
                            else
                            {
                                Console.WriteLine("Умножать можно только согласованные матрицы.");
                            }

                            break;
                        default:
                            Console.WriteLine("Вы ввели неверное число, повторите ввод");
                            break;

                    }
                    Console.ReadKey();
                }
                else
                {

                    string errorUserAnswer = current.ToLower();
                    switch (errorUserAnswer)

                    {

                        case ("exit"):
                            isExit = true; break;
                        default:
                            Console.WriteLine("Неверный ввод");
                            break;
                    }



                }
            }
            while (!isExit);


        }

    }
}
