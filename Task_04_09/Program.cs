using System.Xml;

namespace Task_04_09
{
    internal class Program
    {
        //В массиве найти элементы, которые в нем встречаются только один раз, и вывести их на экран. То есть найти и 
        //вывести уникальные элементы массива. (LINQ использовать нельзя)
        static void Main(string[] args)
        {
            int n = 0;

            // Ввод размера массива
            Console.WriteLine("Введите количество чисел в массиве:");
            string input = Console.ReadLine();

            while (true)
            {
                try
                {
                    n = int.Parse(input);
                    if (n > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Введите положительное число");
                        input = Console.ReadLine();
                    }
                }
                catch
                {
                    Console.WriteLine("Введите число.");
                    input = Console.ReadLine();
                }
            }

            int[] array = new int[n];
            Random rnd = new Random();

            Console.WriteLine("Массив:");
            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(1, 10);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Уникальные элементы:");
            for (int i = 0; i < n; i++)
            {
                bool unique = true;

                for (int j = 0; j < n; j++)
                {
                    if (i != j && array[i] == array[j])
                    {
                        unique = false;
                        break;
                    }
                }

                if (unique)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
    }
}
