namespace Task_20_06
{
    enum TrafficLightColor
    {
        Red = 1,
        Yellow,
        Green
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TrafficLightColor currentColor = TrafficLightColor.Red;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Текущий сигнал светофора: " + currentColor);
                Console.WriteLine("1 - Переключить вручную");
                Console.WriteLine("2 - Автоматический режим");
                Console.WriteLine("3 - Выход");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Ошибка! Введите число от 1 до 3.");
                    Console.ReadKey();
                    continue;
                }

                if (choice == 3)
                    break;

                if (choice == 1)
                {
                    currentColor = GetNextColor(currentColor);
                }
                else if (choice == 2)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        Console.Clear();
                        Console.WriteLine("Текущий сигнал светофора: " + currentColor);
                        Thread.Sleep(3000);
                        currentColor = GetNextColor(currentColor);
                    }
                }

            }
        }

        public static TrafficLightColor GetNextColor(TrafficLightColor color)
        {
            if (color == TrafficLightColor.Red)
                return TrafficLightColor.Green;
            else if (color == TrafficLightColor.Green)
                return TrafficLightColor.Yellow;
            else
                return TrafficLightColor.Red;
        }

    }
}
