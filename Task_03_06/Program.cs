namespace Task_03_06
{
    internal class Program
    {
        //  Написать программу, которая выводит таблицу значений функции: 𝑦=|𝑥|для -4≤x≤4, с шагом h = 0,5
        static void Main(string[] args)
        {
            double startX = -4.0;
            double endX = 4.0;
            double h = 0.5;

            Console.WriteLine("x   |   y");

            for (double x = startX; x <= endX; x += h)
            {
                double y = Math.Abs(x);

                Console.WriteLine($"{x,7:F1} | {y,7:F1}");
            }
        }
    }
}
