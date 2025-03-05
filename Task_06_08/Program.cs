namespace Task_06_08
{
    internal class Program
    {
        //Создайте метод, который на вход принимает одномерный массив и число для поиска, верните индекс искомого 
        //элемента в массиве.Если элемента нет – верните индекс = -1

        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(1, 101);
            }

            Console.WriteLine("Массив:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Введите число для поиска:");
            int find = int.Parse(Console.ReadLine());

            int index = FindNumber(numbers, find);

            Console.WriteLine($"Индекс числа {find}: {index}");
        }

        static int FindNumber(int[] array, int find)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == find)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
