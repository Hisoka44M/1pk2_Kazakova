namespace Task_05_05
{
    internal class Program
    {
        //*У пользователя в консоли запрашивается числа n и m, генерируется прямоугольный массив целых числе [n*m]. Заполнение 
        //случайными числами в диапазоне от -99 до 99 включительно.Осуществите без создания нового массива преобразование
        //текущего по следующему правилу: 
        //• Если элемент меньше нуля, то отбрасываем знак и выделяем при выводе зеленым цветом 
        //• Если элемент равен нулю, то перезаписываем единицу и выделяем при выводе красным цветом 
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сколько будет строк в массиве");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сколько будет столбцов в массиве");
            int m = Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[n, m];

            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = rnd.Next(-99, 100);
                }
            }

            for (int i = 0;i < n; i++)
            { 
                for (int j = 0;j < m; j++)
                {
                    if (arr[i, j] < 0)
                    {
                        arr[i, j] = Math.Abs(arr[i, j]);
                    }
                    else if (arr[i, j] == 0)
                    {
                        arr[i, j] = 1;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (arr[i, j] > 0 && arr[i, j] <= 99) 
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else if (arr[i, j] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }

                    Console.Write(arr[i, j] + " ");
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }
    }
}
