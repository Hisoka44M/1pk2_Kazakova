namespace Task_21_10
{
    // Написать метод, который объединяет два словаря. Если ключ присутствует в обоих словарях, суммировать их 
    //значения.

    internal class Program
    {
        static Dictionary<string, int> MergeDictionaries(Dictionary<string, int> dict1, Dictionary<string, int> dict2)
        {
            Dictionary<string, int> mergedDict = new Dictionary<string, int>();

            foreach (var entry in dict1)
            {
                mergedDict[entry.Key] = entry.Value;
            }

            foreach (var entry in dict2)
            {
                if (mergedDict.ContainsKey(entry.Key))
                {
                    mergedDict[entry.Key] += entry.Value;
                }
                else
                {
                    mergedDict[entry.Key] = entry.Value;
                }
            }

            return mergedDict;
        }

        static void Main()
        {
            Dictionary<string, int> dict1 = new Dictionary<string, int>
        {
            { "Clawdeen", 2 },
            { "Draculaura", 3 },
            { "Frankie", 1 }
        };

            Dictionary<string, int> dict2 = new Dictionary<string, int>
        {
            { "Draculaura", 2 },
            { "Frankie", 4 },
            { "Lagoonna", 5 }
        };

            var mergedDict = MergeDictionaries(dict1, dict2);

            foreach (var entry in mergedDict)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }
    }
}
