
using System;
namespace OOP_Polymorphism
{
    // "Triangle" class extents "Shape" abstract class
    class Triangle : Shape
    {
       
        private int _base;
        private int _height;
        public Triangle() { }

        public Triangle(int @base, int height)
        {
            Base = @base;
            Height = height;
        }
        public Triangle(int @base, int height, String color)
        {
            Base = @base;
            Height = height;
            base.Color = color;
        }

        public int Base
        {
            get => _base;
            set => _base = value > 0 ? value : throw new Exception("Base must be greater than 0");
        }

        public int Height
        {
            get => _height;
            set => _height = value > 0 ? value : throw new Exception("Height must be greater than 0");
        }

        // Must be override
        public override double GetArea() => 0.5 * _base * _height;

        public override string ToString() => $"This is a {base.Color} Triangle";

        // We are not override "Draw" method but it still Ok
       
        // We can create a new method name "Draw"
        public new void Draw()
        {
            Console.WriteLine("Draw is not support!");
        }

        // Asserting that we are aware that the member
        // that it modifies hides a member
        // that is inherited from the base class
        // by using "new" keyword
    }
}
