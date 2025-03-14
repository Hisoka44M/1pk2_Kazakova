namespace Task_11_07
{
    //Передача массива по ссылке (ref): Напишите метод, который принимает массив целых чисел по 
    //ссылке и изменяет его элементы, увеличивая каждый на 1. Проверьте, изменился ли
    //оригинальный массив вне метода.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа для массива через пробел:");
            int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            Console.WriteLine("До: " + string.Join(", ", array));
            TransferArrayByRef(ref array);
            Console.WriteLine("После: " + string.Join(", ", array));
        }

        static void TransferArrayByRef(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i]++;
            }
        }
    }
}
