namespace Task_05_09
{
    internal class Program
    {
        //Дан квадратный массив размерность n*n. Произведите анализ данной матрицы и выясните является ли данная матрица
        //Z-матрицей  (это матрица, где все недиагональные элементы меньше нуля) 
        //Если данное условие выполняется то вывести данную матрицу с цветовой индикацией главной диагонали.Если не выполняется, то
        //вывести сообщение что данная матрица не является Z-матрицей
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

            bool isZMatrix = true;

            for (int i = 0; i < n && isZMatrix; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i != j && matrix[i, j] >= 0)
                    {
                        isZMatrix = false;
                    }
                }
            }
            if (isZMatrix)
            {
                Console.WriteLine("Матрица является Z-матрицей");
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
                Console.WriteLine("Матрица не является Z-матрицей");
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
    

