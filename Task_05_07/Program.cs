namespace Task_05_07
{
    internal class Program
    {
        // У пользователя в консоли запрашивается число n, генерируется квадратный массив целых числе [n*n].
        // Заполнение случайными числами в диапазоне от 10 до 99 включительно.
        //Найти и вывести отдельно минимальный элемент в матрице(LINQ под запретом) Осуществить умножение матрицы на ее
        //минимальный элемент, при выводе цветом выделить пять максимальных значений в массиве
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число размера массива");

            int n = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[n, n]; 
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = rnd.Next(10, 100);
                }
            }

            int min = arr[0, 0];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                    }
                }
            }

            Console.WriteLine($"Минимальный элемент: {min}");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] *= min;
                }
            }

            int[] maxValues = new int[5] { int.MinValue, int.MinValue, int.MinValue, int.MinValue, int.MinValue };

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int current = arr[i, j];

                    for (int k = 0; k < 5; k++)
                    {
                        if (current > maxValues[k])
                        {
                            for (int l = 4; l > k; l--)
                            {
                                maxValues[l] = maxValues[l - 1];
                            }
                            maxValues[k] = current;
                            break;
                        }
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    bool isMax = false;

                    for (int k = 0; k < 5; k++)
                    {
                        if (arr[i, j] == maxValues[k])
                        {
                            isMax = true;
                            break;
                        }
                    }

                    if (isMax)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }

                    Console.Write(arr[i, j] + "\t");
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }
    }
}
