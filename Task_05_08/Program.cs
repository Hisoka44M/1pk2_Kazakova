namespace Task_05_08
{
    internal class Program
    {
        //Даны два массива размером 10*10, заполненные целыми числами в диапазоне от 1 до 9 вкл. Создать новый массив,
        //который будет произведением двух предыдущих(перемножить элементы первых двух массивов, стоящие на одинаковых
        //позициях и записать их в результирующий массив) Вывести результирующий массив
        static void Main(string[] args)
        {
            int[,] arr1 = new int[10, 10];
            int[,] arr2 = new int[10, 10];

            int[,] arrResult = new int[10, 10];

            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    arr1[i, j] = rnd.Next(1, 10);
                    arr2[i, j] = rnd.Next(1, 10);
                }
                
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    arrResult[i, j] = arr1[i, j] * arr2[i, j];
                }
            }

            Console.WriteLine("Первый массив:");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(arr1[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Второй массив:");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(arr2[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Результирующий массив:");

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(arrResult[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
