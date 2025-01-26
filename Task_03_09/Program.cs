namespace Task_03_09
{
    internal class Program
    {
        /*      Вклад в банке составляет x рублей. Ежегодно он увеличивается на p процентов, после чего дробная часть копеек 
                отбрасывается. Каждый год сумма вклада становится больше. Определите, через сколько лет вклад составит не 
                менее y рублей.
                Примеры
                входные данные
                100
                10
                200
                выходные данные
                8 
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Какая сумма в банке:");
            double x = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Проценты в банке:");
            double p = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Напишите сумму, которую хоите узнать через сколько лет накопится:");
            double summ = Int32.Parse(Console.ReadLine());

            int years = 0;

            

            while (x < summ)
            {
                x += Math.Floor(x * p / 100);
                years++;
                
            }
            Console.WriteLine($"Через {years} накопится {summ} рублей");
        }
    }
}
