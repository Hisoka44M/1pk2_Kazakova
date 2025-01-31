namespace Task_05_03
{
    internal class Program
    {
        //Даны два массива, заполненные символами английского алфавита размером 3*3. Проверить, являются ли матрицы равными, если 
        //да, то вывести сообщение о том, что они равны, если нет, то вывести повторно матрицы с цветовой индикацией только тех
        //элементов, которые равны. (матрицы считаются равными, если их соответствующие элементы равны.
        static void Main(string[] args)
        {
            Console.WriteLine("Не совпадающие символы выделаются синим");
            string[,] arr1 = new string[3, 3];
            string[,] arr2 = new string[3, 3];
            Random rnd = new Random();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr1[i, j] = ((char)rnd.Next('A', 'Z' + 1)).ToString();
                    arr2[i, j] = ((char)rnd.Next('A', 'Z' + 1)).ToString();
                }
            }

            bool equal = true;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (arr1[i, j] != arr2[i, j])
                    {
                        equal = false;
                    }
                }
            }

            if (equal)
            {
                Console.WriteLine("\nМатрицы равны");
            }
            else
            {
                Console.WriteLine("\nМатрицы не равны");

                for (int i = 0; i < 3; i++)
                {
                    for(int j = 0; j < 3; j++)
                    {
                        if (arr1[i,j] == arr2[i,j])
                        {
                            Console.Write(arr1[i,j] + " ");
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.Write(" " + arr1[i, j] + " "); 
                            Console.ResetColor();
                        }
                    }
                    Console.Write(" | ");
                    for (int j = 0; j < 3; j++)
                    {
                        if (arr1[i, j] == arr2[i, j])
                        {
                            Console.Write(arr2[i, j] + " ");
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.Write(" " + arr2[i, j] + " "); 
                            Console.ResetColor();
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
