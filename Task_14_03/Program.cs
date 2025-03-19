namespace Task_14_03
{
    // Реализуйте статический метод Factorial, который принимает целое число и возвращает его факториал. Сделайте 
//так, чтобы метод работал только для неотрицательных чисел
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число для вычисления факториала: ");
            int number = int.Parse(Console.ReadLine());

            long factorial = Factorial(number);
            if (factorial != -1)
            {
                Console.WriteLine($"Факториал числа {number} равен {factorial}");
            }
        }

        public static long Factorial(int number)
        {
            if (number < 0)
            {
                Console.WriteLine("Число должно быть неотрицательным.");
                return -1; 
            }

            long result = 1;

            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }

    }
}
