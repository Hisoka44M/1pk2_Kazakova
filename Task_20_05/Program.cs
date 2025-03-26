namespace Task_20_05
{
    enum AccessLevel
    {
        Guest = 1,
        User,
        Moderator,
        Admin
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Выберите уровень доступа:\n" +
                    "1 - Guest\n" +
                    "2 - User\n" +
                    "3 - Moderator\n" +
                    "4 - Admin");

                int levelInput = Convert.ToInt32(Console.ReadLine());
                AccessLevel userLevel = (AccessLevel)Math.Clamp(levelInput, 1, 4);

                Console.WriteLine("Выберите действие:\n" +
                    "1 - Читать пост\n" +
                    "2 - Комментировать пост\n" +
                    "3 - Удалить пост\n" +
                    "4 - Управление пользователями");

                int actionInput = Convert.ToInt32(Console.ReadLine());
                PerformAction(userLevel, actionInput);
                Console.ReadKey();
            }
        }
        public static void PerformAction(AccessLevel level, int action)
        {
            switch (action)
            {
                case 1:
                    Console.WriteLine("Вы можете читать посты.");
                    break;
                case 2:
                    Console.WriteLine(level >= AccessLevel.User ? "Вы можете комментировать посты." : "Ошибка: Недостаточно прав!");
                    break;
                case 3:
                    Console.WriteLine(level >= AccessLevel.Moderator ? "Вы можете удалять посты." : "Ошибка: Недостаточно прав!");
                    break;
                case 4:
                    Console.WriteLine(level == AccessLevel.Admin ? "Вы можете управлять пользователями." : "Ошибка: Недостаточно прав!");
                    break;
                default:
                    Console.WriteLine("Неверный выбор действия.");
                    break;
            }
        }
    }
}
