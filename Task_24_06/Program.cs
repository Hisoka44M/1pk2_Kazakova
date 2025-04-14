namespace Task_24_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\work\test.txt"; // Пример пути к файлу
            int lineCount = CountLinesInFile(filePath);
            Console.WriteLine($"Количество строк в файле: {lineCount}");
        }

        static int CountLinesInFile(string path)
        {
            int count = 0;

            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    while (!reader.EndOfStream)
                    {
                        reader.ReadLine();
                        count++;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при чтении файла: " + ex.Message);
            }

            return count;
        }
    }
}
