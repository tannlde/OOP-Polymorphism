using System;

namespace OOP_Polymorphism
{
    // "Rectangle" class extents "Shape" abstract class
    class Rectangle : Shape
    {
        private int _length;
        private int _width;

        public Rectangle() { }

        public Rectangle(int length, int width)
        {
            Length = length;
            Width = width;
        }
        // public Rectangle(int length, int width,String color ):base(color){

        // }
        //public Rectangle(int length, int width, String color)
        //{
        //    Length = length;
        //    Width = width;
        //    base.Color = color;
        //}

        public int Length
        {
            get => _length;
            set => _length = value > 0 ? value : throw new Exception("Lenght must be greater than 0");
        }

        public int Width
        {
            get => _width;
            set => _width = value > 0 ? value : throw new Exception("Width must be greater than 0");
        }

        // Optional override
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

        // Must be overrdie
        public override double GetArea() => _length * _width;

        public override string ToString() => $"This is a {base.Color} Rectangle";
    }
}
