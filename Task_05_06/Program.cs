namespace Task_05_06
{
    internal class Program
    {
        // Осуществить генерация двумерного [10*5] массива по следующему правилу: 
        //• 1 столбец содержит нули 
        //• 2 столбце содержит числа кратные 2 
        //• 3 столбец содержит числа кратные 3 
        //• 4 столбец содержит числа кратные 4 
        //• 5 столбец содержит числа кратные 5 
        //Осуществить переворот массива(поменять строки и столбцы местами) вывести обновленный массив
        static void Main(string[] args)
        {
            int[,] arr1 = new int[10, 5];
            int[,] arr2 = new int[5, 10];

            for (int i = 0; i < 10; i++)
            {
                arr1[i, 0] = 0;
                arr1[i, 1] = (i + 1) * 2;
                arr1[i, 2] = (i + 1) * 3;
                arr1[i, 3] = (i + 1) * 4;
                arr1[i, 4] = (i + 1) * 5;
            }

            for (int i = 0;i < 10; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr2[j, i] = arr1[i, j];
                }
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(arr1[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nПеревернутый массив:\n");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                { 
                    Console.Write(arr2[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
