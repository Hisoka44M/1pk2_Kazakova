namespace Task_03_08
{
    internal class Program
    {
        //Даны натуральные числа от 20 до 50. Напечатать те из них, которые делятся на 3, но не делятся на 5
        static void Main(string[] args)
        {
            int num = 50;
            while (true)
            {
                if (num < 20)
                break;

                if (num % 3 == 0)
                {
                    if (num % 5 != 0)
                    {
                        Console.WriteLine(num);
                        
                    }
                }
                num--;
            }
        }
    }
}
