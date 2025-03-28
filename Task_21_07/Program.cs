namespace Task_21_07
{
    // Написать метод, который находит первый ключ в словаре, соответствующий заданному значению. Если значения 
    //нет, вернуть null.

    internal class Program
    {
        static string? FindKey(Dictionary<string, int> dict, int value)
        {
            foreach (var item in dict)
            {
                if (item.Value == value)
                    return item.Key;
            }
            return null;
        }

        static void Main()
        {
            var dolls = new Dictionary<string, int>
        {
            {"Draculaura", 1},
            {"Frankie", 2},
            {"Clawdeen", 3},
            {"Lagoona", 4}
        };

            while (true)
            {
                Console.Write("Введите число: ");
                if (int.TryParse(Console.ReadLine(), out int num))
                {
                    string? name = FindKey(dolls, num);
                    Console.WriteLine(name ?? "Не найдено");
                }
                else
                {
                    Console.WriteLine("Неправельный ввод, нужны числа от 1-4");
                }
            }
        }
    }
}
