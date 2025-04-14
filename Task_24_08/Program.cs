namespace Task_24_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\work\test.txt"; // путь к файлу

            Console.Write("Введите текст, который нужно найти: ");
            string oldText = Console.ReadLine();

            Console.Write("Введите текст, на который нужно заменить: ");
            string newText = Console.ReadLine();

            ReplaceTextInFile(filePath, oldText, newText);

            Console.WriteLine("Замена завершена.");
        }

        static void ReplaceTextInFile(string path, string oldText, string newText)
        {
            try
            {
                if (File.Exists(path))
                {
                    string content = File.ReadAllText(path); // читаем весь текст
                    content = content.Replace(oldText, newText); // замена
                    File.WriteAllText(path, content); // перезаписываем файл
                }
                else
                {
                    Console.WriteLine("Файл не найден.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }
        }
    }
}
