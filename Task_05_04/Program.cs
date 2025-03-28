﻿namespace Task_05_04
{
    internal class Program
    {
        //Дан квадратный массив размерность n*n. Произведите анализ данной матрицы и выясните является ли данная матрица 
        //диагональной(все элементы вне главной диагонали равны нулю) Если матрица является диагональной, то вывести ее
        //повторно с цветовым выделением главной диагонали.Если нет, то вывеси
        //сообщение что матрица не является диагональной.
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[n, n];

            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rand.Next(-10, 11);
                }
            }

            bool isDiagonal = true;

            for (int i = 0; i < n && isDiagonal; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i != j && matrix[i, j] != 0)
                    {
                        isDiagonal = false;
                    }
                }
            }
            if (isDiagonal)
            {
                Console.WriteLine("Матрица является диагональной");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i == j)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        Console.Write(matrix[i, j] + "\t");
                        Console.ResetColor();
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Матрица не является диагональной");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(matrix[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
