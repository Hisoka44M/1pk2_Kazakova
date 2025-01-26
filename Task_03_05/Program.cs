namespace Task_03_05
{
    internal class Program
    {
        /*Написать программу, которая выводит на экран таблицу соответствия температуры в градусах Цельсия и 
          Фаренгейта (F = C*1,8 + 32). Диапазон изменения температуры в градусах Цельсия и шаг должны вводиться во 
          время работы программы
        */
        static void Main(string[] args)
        {
            Console.Write("Введите начальную температуру в градусах Цельсия: ");
            double startCelsius = double.Parse(Console.ReadLine());

            Console.Write("Введите конечную температуру в градусах Цельсия: ");
            double endCelsius = double.Parse(Console.ReadLine());

            Console.Write("Введите шаг изменения температуры: ");
            double step = double.Parse(Console.ReadLine());

            // Проверка корректности ввода
            if (endCelsius < startCelsius)
            {
                Console.WriteLine("Конечная температура меньше начальной");
                return;
            }

            if (step <= 0)
            {
                Console.WriteLine("Шаг должен быть больше 0.");
                return;
            }

            // Вывод таблицы
            Console.WriteLine("\nЦельсий  | Фаренгейт");

            for (double celsius = startCelsius; celsius <= endCelsius; celsius += step)
            {
                double fahrenheit = celsius * 1.8 + 32;
                Console.WriteLine($"{celsius} | {fahrenheit}");
            }
        }
    }
}
