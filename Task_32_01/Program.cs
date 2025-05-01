namespace Task_32_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kolobok kolobok = new Kolobok();
            List<IObstacle> obstacles = new List<IObstacle>
        {
            new Bush(),
            new Hare(),
            new Puddle(),
            new Wolf(),
            new Pit(),
            new Bear(),
            new Fox()
        };

            foreach (var obstacle in obstacles)
            {
                if (!kolobok.IsAlive)
                    break;

                kolobok.Roll();

                // Животное?
                if (obstacle is Animal animal)
                {
                    kolobok.MeetAnimal(animal);
                }
                // Препятствие?
                else
                {
                    obstacle.Interact(kolobok);
                }
            }

            if (kolobok.IsAlive)
            {
                Console.WriteLine("Колобок сбежал и стал Senior .NET-разработчиком!");
            }
            else
            {
                Console.WriteLine("Game Over. Колобок не выжил в этом жестоком ООП-мире.");
            }
        }
    }

    public interface IObstacle
    {
        void Interact(Kolobok kolobok);
    }

    public class Kolobok
    {
        public int Position { get; private set; }
        public int Speed { get; set; }
        public bool IsAlive { get; private set; }

        private int _skipTurns = 0;

        public Kolobok()
        {
            Position = 0;
            Speed = 1;
            IsAlive = true;
        }

        public void Roll()
        {
            if (_skipTurns > 0)
            {
                Console.WriteLine("Колобок пропускает ход.");
                _skipTurns--;
                return;
            }

            Position += Speed;
            Console.WriteLine($"Колобок катится, текущая позиция: {Position}");
        }

        public void MeetAnimal(Animal animal)
        {
            if (animal.CanEat(this))
            {
                IsAlive = false;
                Console.WriteLine($"Колобок был съеден {animal.Name}!");
            }
            else
            {
                Console.WriteLine($"Колобок убежал от {animal.Name}!");
            }
        }

        public void StopNextTurn()
        {
            _skipTurns = 1;
        }

        public void PushBack()
        {
            Position = Math.Max(0, Position - 2);
        }

        public void SlowDown()
        {
            if (Speed > 1)
            {
                Speed--;
                Console.WriteLine($"Скорость Колобка снижена до {Speed}.");
            }
            else
            {
                Console.WriteLine("Скорость Колобка уже минимальна.");
            }
        }
    }

    public abstract class Animal : IObstacle
    {
        public string Name { get; }

        protected Animal(string name)
        {
            Name = name;
        }

        public abstract bool CanEat(Kolobok kolobok);

        public void Interact(Kolobok kolobok)
        {
            kolobok.MeetAnimal(this);
        }
    }

    public class Hare : Animal
    {
        public Hare() : base("Заяц") { }

        public override bool CanEat(Kolobok kolobok)
        {
            return false;
        }
    }

    public class Wolf : Animal
    {
        public Wolf() : base("Волк") { }

        public override bool CanEat(Kolobok kolobok)
        {
            return false;
        }
    }

    public class Bear : Animal
    {
        public Bear() : base("Медведь") { }

        public override bool CanEat(Kolobok kolobok)
        {
            return false;
        }
    }

    public class Fox : Animal
    {
        public Fox() : base("Лиса") { }

        public override bool CanEat(Kolobok kolobok)
        {
            return true;
        }
    }

    public class Bush : IObstacle
    {
        public void Interact(Kolobok kolobok)
        {
            Console.WriteLine("Колобок запутался в кустах!");
            kolobok.SlowDown();
        }
    }

    public class Puddle : IObstacle
    {
        public void Interact(Kolobok kolobok)
        {
            Console.WriteLine("Колобок размяк в луже и остановился.");
            kolobok.StopNextTurn();
        }
    }

    public class Pit : IObstacle
    {
        public void Interact(Kolobok kolobok)
        {
            Console.WriteLine("Колобок угодил в яму и откатился назад!");
            kolobok.PushBack();
        }
    }
}
