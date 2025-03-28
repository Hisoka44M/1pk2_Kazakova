namespace Task_21_08
{
    // напишите метод, который на вход получается массив параметров (строк) и возвращает только уникальные строки
    internal class Program
    {
        static string[] GetUniqueStrings(string[] input)
        {
            string[] uniqueStrings = new string[input.Length];
            int index = 0;

            for (int i = 0; i < input.Length; i++)
            {
                bool isUnique = true;

                for (int j = 0; j < index; j++)
                {
                    if (uniqueStrings[j] == input[i])
                    {
                        isUnique = false;
                        break;
                    }
                }

                if (isUnique)
                {
                    uniqueStrings[index] = input[i];
                    index++;
                }
            }

            string[] result = new string[index];
            Array.Copy(uniqueStrings, result, index);
            return result;
        }

        static void Main()
        {
            string[] words = { "Clawdeen", "Draculaura", "Frankie", "Clawdeen", "Lagoonna", "Draculaura" };
            string[] uniqueWords = GetUniqueStrings(words);

            Console.WriteLine("Уникальные слова: " + string.Join(", ", uniqueWords));
        }
    }
}
