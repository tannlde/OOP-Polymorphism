using System;

namespace OOP_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            // Abstract class is intended only to be
            // a base class of other classes, not instantiated on its own.
            //Shape shape = new Shape();

            try
            {
                // If the constructor in "Rectangle" do not have "color" param,
                // we can use this syntax
                Shape rectangle = new Rectangle(10, 3)
                {
                    Color = "Red"
                };

                Console.WriteLine(rectangle.ToString());
                rectangle.Draw();

                // When we initialize a Rectangle with base Shape,
                // we cannot access getter Width and Length in Rectangle class
                // so we can use "as" keyword
                Console.WriteLine($"Width = {(rectangle as Rectangle).Width}");
                Console.WriteLine($"Length = {(rectangle as Rectangle).Length}");
                Console.WriteLine($"Area of Retangle is {rectangle.GetArea()}");
                //Using "is" keyword to check
                Console.WriteLine($"Is Rectangle? {rectangle is Rectangle}");
                Console.WriteLine($"Is Triangle? {rectangle is Triangle}");
                Console.WriteLine($"Is Shape? {rectangle is Shape}");

                Console.WriteLine("\n\n************************************");
                Triangle triangle = new(10, 2);
                Console.WriteLine(triangle.ToString());
                Console.WriteLine($"Base = {triangle.Base}");
                Console.WriteLine($"Height = {triangle.Height}");
                triangle.Draw();

                //By using "new" keyword we also can access old "Draw" method
                (triangle as Shape).Draw();

                Console.WriteLine($"Area of Triangle is {triangle.GetArea()}");

                Console.WriteLine("\n\n************************************");

                // Example of validation 
                Console.WriteLine("Shape shape = new Triangle(3,-2);");
                Shape shape = new Triangle(3, -2);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error message: {e.Message}");
            }
        }
    }
}
