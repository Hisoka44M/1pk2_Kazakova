namespace Task_04_05
{
    internal class Program
    {
        //*В массиве хранятся сведения о количестве осадков за месяц (30 дней). Необходимо определить общее 
        //количество осадков, выпавших за каждую декаду месяца, вывести день с самыми сильными осадками за месяц и
        //отдельно вывести дни без осадков.Массив с осадками заполнятся с помощью рандома в диапазоне от 0 – нет
        //осадков, до 300 мм выпавших осадков
        static void Main(string[] args)
        {
            int[] rain = new int[30]; 
            Random rnd = new Random();

            for (int i = 0; i < 30; i++)
            {
                rain[i] = rnd.Next(0, 301); 
            }

            Console.WriteLine("Осадки за каждый день месяца:");
            for (int i = 0; i < 30; i++)
            {
                Console.Write(rain[i] + " ");
            }
            Console.WriteLine();

            int totalDecade1 = 0, totalDecade2 = 0, totalDecade3 = 0;

            for (int i = 0; i < 10; i++) 
            {
                totalDecade1 += rain[i];
            }

            for (int i = 10; i < 20; i++) 
            {
                totalDecade2 += rain[i];
            }

            for (int i = 20; i < 30; i++) 
            {
                totalDecade3 += rain[i];
            }

            Console.WriteLine("Общее количество осадков за первую декаду: " + totalDecade1 + " мм");
            Console.WriteLine("Общее количество осадков за вторую декаду: " + totalDecade2 + " мм");
            Console.WriteLine("Общее количество осадков за третью декаду: " + totalDecade3 + " мм");

            int maxRain = rain[0];
            int dayWithMaxRain = 0;
            for (int i = 1; i < 30; i++)
            {
                if (rain[i] > maxRain)
                {
                    maxRain = rain[i];
                    dayWithMaxRain = i;
                }
            }

            Console.WriteLine("День с самыми сильными осадками: день " + (dayWithMaxRain + 1) + " с " + maxRain + " мм осадков.");

            Console.WriteLine("Дни без осадков:");
            for (int i = 0; i < 30; i++)
            {
                if (rain[i] == 0)
                {
                    Console.Write((i + 1) + " ");
                }
            }
        
        }
    }
}
