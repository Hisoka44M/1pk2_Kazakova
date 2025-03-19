namespace Task_14_04
{
    //Определите класс User, который будет иметь статическое свойство CurrentUser, представляющее текущего 
//пользователя, и метод для его установки
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("Ваня", 25, "Мужской");
            User user2 = new User("Марго", 20, "Женский");

            User.SetCurrentUser(user1);

            Console.WriteLine("Текущий пользователь:");
            User.CurrentUser.DisplayInfo();

            User.SetCurrentUser(user2);

            Console.WriteLine("Теперь текущий пользователь:");
            User.CurrentUser.DisplayInfo();
        }

    }
    class User
    {
        public static User CurrentUser;

        public string Name;
        public int Age;
        public string Gender;

        public User(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Имя: {Name}, Возраст: {Age}, Пол: {Gender}");
        }
        public static void SetCurrentUser(User user)
        {
            CurrentUser = user;
        }
    }
}
