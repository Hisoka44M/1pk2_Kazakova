namespace Task_20_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VehicleManager manager = new VehicleManager();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Выберите действие:\n" +
                    "1 - Добавить транспортное средство\n" +
                    "2 - Подсчитать транспортные средства\n" +
                    "3 - Найти транспортное средство\n" +
                    "4 - Выйти");

                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 4) break;

                Console.WriteLine("Выберите тип транспорта:\n" +
                    "1 - Car\n" +
                    "2 - Bike\n" +
                    "3 - Bus\n" +
                    "4 - Truck\n" +
                    "5 - Motorcycle");

                int typeInput = Convert.ToInt32(Console.ReadLine());
                VehicleType type = (VehicleType)Math.Clamp(typeInput, 1, 5);

                switch (choice)
                {
                    case 1:
                        manager.AddVehicle(type);
                        break;
                    case 2:
                        Console.WriteLine($"Количество {type}: {manager.CountVehicles(type)}");
                        break;
                    case 3:
                        manager.FindVehicles(type);
                        break;
                }
                Console.ReadKey();
            }
        }
    }
    

    enum VehicleType
    {
        Car = 1,
        Bike,
        Bus,
        Truck,
        Motorcycle
    }

    class VehicleManager
    {
        private List<VehicleType> vehicles = new List<VehicleType>();

        public void AddVehicle(VehicleType type)
        {
            vehicles.Add(type);
            Console.WriteLine($"Добавлено транспортное средство: {type}");
        }

        public int CountVehicles(VehicleType type)
        {
            return vehicles.Count(v => v == type);
        }

        public void FindVehicles(VehicleType type)
        {
            int count = vehicles.Count(v => v == type);
            Console.WriteLine(count > 0 ? $"Найдено {count} транспортных средств типа {type}" : $"Транспортные средства типа {type} не найдены");
        }
    }
}
