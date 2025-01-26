namespace Task_03_07
{
    internal class Program
    {
        //  Написать программу, которая выводит таблицу скорости (через каждые 0,5с) свободно падающего тела v = g t , 
        //где 2 g = 9,8 м/с2 –ускорение свободного падения.
        static void Main(string[] args)
        {
            double g = 9.8;

            double maxTime = 5.0;

            double step = 0.5;

            Console.WriteLine("Время (с)\tСкорость (м/с)");

            for (double t = 0; t <= maxTime; t += step)
            {
                double v = g * t; 
                Console.WriteLine($"{t:F1}\t\t{v:F2}");
            }
        }
    }
}
