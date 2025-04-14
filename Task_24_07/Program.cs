namespace Task_24_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\work\test.txt"; // путь к файлу
            string wordToFind = "пример"; // слово для поиска

            List<string> foundLines = FindLinesWithWord(filePath, wordToFind);

            Console.WriteLine("Строки, содержащие слово:");
            foreach (string line in foundLines)
            {
                Console.WriteLine(line);
            }
        }

        static List<string> FindLinesWithWord(string path, string word)
        {
            List<string> result = new List<string>();

            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();

                        // Сравниваем без учёта регистра
                        if (line.ToLower().Contains(word.ToLower()))
                        {
                            result.Add(line);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при чтении файла: " + ex.Message);
            }

            return result;
        }
    }
}
