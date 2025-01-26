namespace Task_03_04
{
    internal class Program
    {
        /*Пользователь вводить в консоли произвольный текст. После каждого ввода консоль очищается. Когда 
            пользователь вводить слово «exit» или пустую строку – ввод останавливается и выводиться количество строк
            введенных пользователе*/
        
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();

            int count = 0;

            while (true)
            {
                if (text == "stop" || text == "")
                {
                    break;
                }
                count++;

                Console.Clear();

                Console.WriteLine("Веддите текст:");
                text = Console.ReadLine();
            }
            Console.WriteLine($"Всего {count} строк");
        }
    }
}
