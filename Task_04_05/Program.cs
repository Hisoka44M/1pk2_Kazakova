﻿namespace Task_04_05
{
    internal class Program
    {
        //*В массиве хранятся сведения о количестве осадков за месяц (30 дней). Необходимо определить общее 
        //количество осадков, выпавших за каждую декаду месяца, вывести день с самыми сильными осадками за месяц и
        //отдельно вывести дни без осадков.Массив с осадками заполнятся с помощью рандома в диапазоне от 0 – нет
        //осадков, до 300 мм выпавших осадков
        static void Main(string[] args)
        {
            int[] days = new int[30];
            Random random = new Random();

            for (int i = 0; i < days.Length; i++)
            {
                days[i] = random.Next(0, 301);
            }


        }
    }
}
