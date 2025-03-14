namespace Task_11_08
{
    //Использование params и out: Напишите метод, который принимает переменное количество 
    //чисел и возвращает их сумму и максимальное значение через выходные параметры(out).
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа через пробел:");
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            SumAndMax(out int total, out int maximum, numbers);
            Console.WriteLine($"Сумма: {total}, Максимум: {maximum}");
        }

        static void SumAndMax(out int sum, out int max, params int[] numbers)
        {
            sum = 0;
            max = int.MinValue;
            foreach (int num in numbers)
            {
                sum += num;
                if (num > max)
                    max = num;
            }
        }

    }
}
