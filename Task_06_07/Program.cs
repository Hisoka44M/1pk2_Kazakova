namespace Task_06_07
{
    internal class Program
    {
        //Создайте метод с помощью которого можно сгенерировать и вернуть символьный двумерный массив (состоящий 
        //из символов русского алфавита) и выведите на консоль данный массив с помощью другого метода(который
        //принимает данный массив в качестве параметра
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк:");
            int rows = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов:");
            int cols = int.Parse(Console.ReadLine());

            char[,] array = CreateChar(rows, cols);

            Console.WriteLine("Массив:");
            Array(array);
        }

        static char[,] CreateChar(int rows, int cols)
        {
            char[,] array = new char[rows, cols];

            string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

            Random rand = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int rnd = rand.Next(alphabet.Length);
                    array[i, j] = alphabet[rnd];
                }
            }

            return array;
        }

        static void Array(char[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
