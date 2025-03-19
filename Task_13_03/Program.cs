namespace Task_13_03
{
    //создайте класс автомобиля
 //свойства:
 //номер авто, марка, цвет, текущая скорость
 //методы:
 //езда(симитировать равномерное ускорение скорости автомобиля)
 //торможение(при превышении скорости автомобиля свыше допустимой - он должен остановиться)
 //конструторы
 //предусмотрите разные варианты инициализации объектов

    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Car car2 = new Car("A123BC", "Toyota", "Красный", 50.0);
            Car car3 = new Car("B456DF", "Nissan", "Синий");

            car2.SpeedUp(30);
            car2.SpeedUp(50);
            car2.Stop();

            car3.SpeedUp(100);
            car3.SpeedUp(30);
            car3.Stop();

        }
    }

    class Car
    {
        public string LicensePlate { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public double CurrentSpeed { get; private set; }
        private const double MaxSpeed = 120.0; 

        public Car(string licensePlate = "Неизвестно", string brand = "Неизвестно", string color = "Неизвестно", double currentSpeed = 0.0)
        {
            LicensePlate = licensePlate;
            Brand = brand;
            Color = color;
            CurrentSpeed = currentSpeed;
        }

        public void SpeedUp(double raising)
        {
            CurrentSpeed += raising;
            Console.WriteLine($"Автомобиль {Brand} увеличивает скорость, текущая скорость: {CurrentSpeed} км/ч");
        }

        public void Stop()
        {
            if (CurrentSpeed > MaxSpeed)
            {
                Console.WriteLine($"Скорость {CurrentSpeed} км/ч превышает допустимую, останавливается");
                CurrentSpeed = 0;
            }
            else
            {
                Console.WriteLine($"Автомобиль {Brand} замедляется, текущая скорость: {CurrentSpeed} км/ч");
            }
        }
    }
}
