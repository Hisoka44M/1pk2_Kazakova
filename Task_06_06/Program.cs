namespace Task_06_06
{
    // Создать Метод ArrayGeneration не возвращающий значения, принимает целое число n, выводит на консоль 
    //сгенерированный массив размерности n* n.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            int n = int.Parse(Console.ReadLine());
            ArrayGeneration(n);
        }

        static void ArrayGeneration(int n)
        {
            int[,] array = new int[n, n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = rnd.Next(1, 100);
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
