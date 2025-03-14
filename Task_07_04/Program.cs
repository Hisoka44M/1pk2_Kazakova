namespace Task_07_04
{
    //Массив параметров (params): Напишите метод, который принимает массив чисел и возвращает 
    //их среднее значение.Используйте ключевое слово params 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа через пробел:");
            string input = Console.ReadLine();

            int[] numbers = Array.ConvertAll(input.Split(), int.Parse);

            double avg = AverageVulue(numbers);
            Console.WriteLine($"Среднее значение: {avg}");
        }

        static double AverageVulue(params int[] numbers)
        {
            if (numbers.Length == 0) 
                return 0;
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return (double)sum / numbers.Length;
        }
    }
}
