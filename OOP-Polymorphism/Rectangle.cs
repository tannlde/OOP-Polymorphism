using System;

namespace OOP_Polymorphism
{
    class Rectangle : Shape
    {

        private int _length;
        private int _width;

        public Rectangle() { }

        public Rectangle(int length, int width)
        {
            _length = length > 0 ? length : throw new System.Exception("Lenght must be greater than 0");
            _width = width > 0 ? width : throw new System.Exception("Width must be greater than 0");
        }

        public int Length
        {
            get => _length;
            set => _length = value > 0 ? value : throw new System.Exception("Lenght must be greater than 0");
        }

        public int Width
        {
            get => _width;
            set => _width = value > 0 ? value : throw new System.Exception("Width must be greater than 0");
        }

        public override void Draw()
        {
            if (base.Color == "Red")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            string row = new('_', _length * 2);
            for (int i = 0; i < _width; i++)
            {
                Console.WriteLine(row);
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }

        public override double GetArea() => _length * _width;

        public override string ToString() => $"This is a {base.Color} Rectangle";

    }
}
