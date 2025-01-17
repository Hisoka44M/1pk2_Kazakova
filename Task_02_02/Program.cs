namespace Task_02_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите b:");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите c (в радианах):");
            double c = Convert.ToDouble(Console.ReadLine());

            double numerator = Math.Pow(b, 0.25) + Math.Pow(a - 1, 1.0 / 3.0);

            double sin2 = Math.Sin(c) * Math.Sin(c);
            double tanC = Math.Tan(c);
            double denominator = Math.Abs(a - b) * (sin2 + tanC);

            if (denominator == 0)
            {
                Console.WriteLine("Ошибка: деление на ноль.");
            }
            else
            {
                double result = numerator / denominator;
                Console.WriteLine("Результат: " + result);
            }
        }
    }
}


