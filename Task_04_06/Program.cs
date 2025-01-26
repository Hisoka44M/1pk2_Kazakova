namespace Task_04_06
{
    internal class Program
    {
        // Заполнить массив случайными положительными и отрицательными числами таким образом, чтобы все числа по 
        //модулю были разными.Это значит, что в массиве не может быть ни только двух равных чисел, но не может быть
        //двух равных по модулю.В полученном массиве найти наибольшее по модулю число.
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов массива:");

            int n = int.Parse(Console.ReadLine());

            Random rnd = new Random();
            int[] numbers = new int[n];

            for (int i = 0; i < numbers.Length; i++)
            {
                int newNumber;
                bool isUnique;

                do
                {
                    newNumber = rnd.Next(-50, 50); // Генерация случайного числа
                    isUnique = true;

                    // Проверка на уникальность по модулю
                    for (int j = 0; j < i; j++)
                    {
                        if (Math.Abs(newNumber) == Math.Abs(numbers[j]))
                        {
                            isUnique = false;
                            break;
                        }
                    }
                }
                while (!isUnique);

                numbers[i] = newNumber;
            }

            // Вывод сгенерированного массива
            Console.WriteLine("Сгенерированный массив:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }

            // Поиск наибольшего по модулю числа
            int maxAbsValue = numbers[0];
            foreach (int num in numbers)
            {
                if (Math.Abs(num) > Math.Abs(maxAbsValue))
                {
                    maxAbsValue = num;
                }
            }

            Console.WriteLine("\nНаибольшее по модулю число: " + maxAbsValue);
        }
    }
}
