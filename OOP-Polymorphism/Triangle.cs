

namespace OOP_Polymorphism
{
    class Triangle : Shape
    {
        private int _base;
        private int _height;

        public Triangle() { }

        public Triangle(int @base, int height)
        {
            _base = @base > 0 ? @base : throw new System.Exception("Base must be greater than 0");
            _height = height > 0 ? height : throw new System.Exception("Height must be greater than 0");

        }

        public int Base
        {
            get => _base;
            set => _base = value > 0 ? value : throw new System.Exception("Base must be greater than 0");

        }

        public int Height
        {
            get => _height;
            set => _height = value > 0 ? value : throw new System.Exception("Height must be greater than 0");
        }

        public override double GetArea() => 0.5 * _base * _height;

        public override string ToString() => $"This is a {base.Color} Triangle";
    }
}
