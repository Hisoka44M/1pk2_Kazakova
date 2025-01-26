namespace Task_04_07
{
    internal class Program
    {
        // В массиве на 30 элементов содержатся данные по росту учеников в классе. Рост мальчиков условно задан 
        //отрицательными значениями.Вычислить и вывести количество мальчиков и девочек в классе и средний рост для
        //мальчиков и девочек.При выводе избавиться от отрицательных значений
        static void Main(string[] args)
        {
            int[] people = new int[30];
            Random rnd = new Random();

            for (int i = 0; i < people.Length; i++)
            {
                people[i] = rnd.Next(0, 2) == 0 ? rnd.Next(-190, -150) : rnd.Next(150, 190);
            }

            int boysCount = 0, girlsCount = 0, boysSum = 0, girlsSum = 0;

            foreach (int height in people)
            {
                if (height < 0)
                {
                    boysCount++;
                    boysSum += -height; 
                }
                else
                {
                    girlsCount++;
                    girlsSum += height;
                }
            }

            double boysAverage = boysCount > 0 ? (double)boysSum / boysCount : 0;
            double girlsAverage = girlsCount > 0 ? (double)girlsSum / girlsCount : 0;

            Console.WriteLine($"Количество мальчиков: {boysCount}");
            Console.WriteLine($"Средний рост мальчиков: {boysAverage:F2}");
            Console.WriteLine($"Количество девочек: {girlsCount}");
            Console.WriteLine($"Средний рост девочек: {girlsAverage:F2}");
        }
    }
}
