namespace Task_13_02
{
    // создать класс питомца 
//свойства:
 //кличка, вид животного, возраст, вес, отметка о состонии здоровья(здоров/нездоров)
 //методы:
 //вывод информации об объекте
 //изменение значения веса животного
 //изменение отметки о состоянии здоровья
 //конструторы:
 //предусмотрите разные варианты инициализации объектов
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание объекта с разными конструкторами
            Pet pet1 = new Pet();
            Pet pet2 = new Pet("Кузя", "Кот", 12, 4.0, true);
            Pet pet3 = new Pet("Генадий", "Змея");

            pet1.DisplayInfo();
            pet2.DisplayInfo();
            pet3.DisplayInfo();

            pet2.ChangeWeight(5.0);
            pet2.ChangeHealthStatus(false);

            pet2.DisplayInfo();
        }
    }
    
    class Pet
    {
        // Свойства
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public bool Healthy { get; set; }

        public Pet(string name = "Неизвестно", string species = "Неизвестно", int age = 0, double weight = 0.0, bool healthy = true)
        {
            Name = name;
            Species = species;
            Age = age;
            Weight = weight;
            Healthy = healthy;
        }

        // Метод для вывода информации
        public void DisplayInfo()
        {
            Console.WriteLine($"Кличка: {Name}, Вид: {Species}, Возраст: {Age} лет, Вес: {Weight} кг, Здоровье: {(Healthy ? "Здоров" : "Нездоров")}");
        }

        public void ChangeWeight(double newWeight)
        {
            Weight = newWeight;
        }
        public void ChangeHealthStatus(bool newHealthy)
        {
            Healthy = newHealthy;
        }
    }

}
