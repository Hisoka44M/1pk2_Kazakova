namespace Task_07_03
{
    //Выходной параметр (out): Напишите метод, который принимает строку и возвращает через 
    //выходной параметр количество гласных и согласных букв в этой строке
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string input = Console.ReadLine();

            CountVowelsAndConsonants(input, out int vowels, out int consonants);

            Console.WriteLine($"Гласных: {vowels}, Согласных: {consonants}");

        }

        static void CountVowelsAndConsonants(string input, out int vowels, out int consonants)
        {
            vowels = 0;
            consonants = 0;
            string vowelChars = "ARabbitRanOverMyGrave";

            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    if (vowelChars.Contains(c))
                        vowels++;
                    else
                        consonants++;
                }
            }
        }
    }
}
