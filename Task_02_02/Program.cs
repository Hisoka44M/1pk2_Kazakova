namespace Task_02_02
{
    internal class Program
    {
        // Найти значение выражения при a = 8, b = 14, с = π/4
        static void Main(string[] args)
        {
            double a = 8;
            double b = 14;
            double c = Math.PI / 4;

            double numerator = Math.Pow(b, 1.0 / 4) + Math.Pow(a - 1, 1.0 / 3); 
            double denominator = Math.Abs(a - b) * (Math.Pow(Math.Sin(c), 2) + Math.Tan(c)); 

            double result = numerator / denominator;

            Console.WriteLine($"Результат: {result}");

        }
    }
}


