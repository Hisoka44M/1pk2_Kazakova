namespace Task_07_05
{
    //Комбинирование ref и out: Напишите метод, который принимает два числа по ссылке (ref) и 
    //возвращает их сумму и произведение через выходные параметры(out). 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два числа:");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine($"До: X = {x}, N = {y}");
            Calculate(ref x, ref y, out int sum, out int product);
            Console.WriteLine($"После: Сумма = {sum}, Произведение = {product}");
        }

        static void Calculate(ref int x, ref int n, out int sum, out int product)
        {
            sum = x + n;
            product = x * n;
        }
    }
}
