namespace Task_33_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<IDrawable> list = new List<IDrawable>
                   {
                       new Circle(5),
                       new Square(2,7),
                       new Circle(5),
                       new Rectangle(6)
                   };


                foreach (var item in list)
                    item.Draw();

                list.Add(new Circle(0));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }

    interface IDrawable
    {
        void Draw();
    }

    internal class Circle : IDrawable
    {
        private int radius;
        public int Radius
        {
            get => radius;
            set
            {
                if (value < 1)
                    throw new ArgumentException("радиус должен быть больше 1");
                else radius = value;
            }
        }

        public Circle(int rad)
        {
            Radius = rad;
        }

        public void Draw()
        {

            for (int x = -Radius; x <= Radius; x++)
            {
                for (int y = -Radius; y <= Radius; y++)
                {
                    if (y * y + x * x <= Radius * Radius)

                        Console.Write("**");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }
        }
    }

    internal class Square : IDrawable
    {
        private int width;
        private int height;
        public int Width
        {
            get => width;
            set
            {
                if (value > 1)
                    width = value;
                else
                    throw new ArgumentException("ширина не должна быть меньше или равна 1");
            }
        }
        public int Height
        {
            get => height;
            set
            {
                if (value > 1)
                    height = value;
                else
                    throw new ArgumentException("высота не должна быть меньше или равна 1");
            }
        }

        public Square(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public void Draw()
        {
            Console.WriteLine();
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }

    internal class Rectangle : IDrawable
    {
        private int height;

        public int Height
        {
            get => height;
            set
            {
                if (value > 1)
                    height = value;
                else
                    throw new ArgumentException("высота треугольника должна быть больше 1");
            }
        }

        public Rectangle(int height)
        {
            Height = height;
        }

        public void Draw()
        {
            Console.WriteLine();
            for (int i = 1; i <= Height; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
}
