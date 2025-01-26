namespace Task_04_08
{
    internal class Program
    {
        //Дан массив, содержащий последовательность 50 случайных чисел. Найти количество пар элементов, значения 
        //которых равны.
        static void Main(string[] args)
        {
            int[] array = new int[50];
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 101);
            }

            int pairCount = 0;
            Array.Sort(array);

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    pairCount++;
                    i++;
                }
            }

            Console.WriteLine("Массив: " + string.Join(", ", array));
            Console.WriteLine($"Количество пар одинаковых элементов: {pairCount}");
        }
    }
}
