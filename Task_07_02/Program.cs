namespace Task_07_02
{
    //Передача по ссылке (ref): Напишите метод, который принимает два целых числа по ссылке и 
    //меняет их местами.Проверьте, изменились ли значения переменных вне метода
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два числа X и N");

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"До: X = {num1}, N = {num2}");

            SwapNumbers(ref num1, ref num2);

            Console.WriteLine($"По: X = {num1}, N = {num2}");
        }

        static void SwapNumbers(ref int x, ref int n)
        {
            int temp = x;
            x = n;
            n = temp;
        }


    }
}
