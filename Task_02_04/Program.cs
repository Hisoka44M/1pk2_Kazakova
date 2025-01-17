namespace Task_02_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите год рождения: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Введите месяц рождения: ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Введите день рождения: ");
            int day = int.Parse(Console.ReadLine());

            DateTime today = DateTime.Now;
            int age = today.Year - year;

            if (today.Month < month || (today.Month == month && today.Day < day))
            {
                age--;
            }

            if (age >= 18)
            {
                Console.WriteLine("Вы совершеннолетний.");
            }
            else
            {
                Console.WriteLine("Вы несовершеннолетний.");
            }
        }
    }
}

