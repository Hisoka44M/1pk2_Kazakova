namespace Task_04_10
{
    internal class Program
    {
        //Заполнить массив из 10 элементов случайными числами в интервале[-10..10] и сделать реверс элементов
        //отдельно для 1-ой и 2-ой половин массива.Реверс реализовать через цикл.Стандартные методы класса Array
        //использовать нельзя.
        //Например, исходный массив: [5, 2, -10, 0, 4, -6, 7, 2, 9, -7]
        //Результат: [4, 0, -10, 2, 5, -7, 9, 2, 7, -6]

        static void Main(string[] args)
        {
            int[] array = new int[10];

            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                array[i] = rnd.Next(-10, 11);
            }

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < 2; i++)
            {
                int temp = array[i];
                array[i] = array[4 - i];
                array[4 - i] = temp;
            }

            for (int i = 5; i < 7; i++)
            {
                int temp = array[i];
                array[i] = array[9 - i + 5];
                array[9 - i + 5] = temp;
            }

            Console.WriteLine("Массив после реверса двух половин:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
