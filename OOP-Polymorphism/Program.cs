using System;

namespace OOP_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            //Shape shape = new Shape();

            //Hello 
            try
            {
                Shape rectangle = new Rectangle(10, 3)
                {
                    Color = "Red"
                };

                Console.WriteLine(rectangle.ToString());
                rectangle.Draw();

                //
                Console.WriteLine($"Width = {(rectangle as Rectangle).Width}");
                Console.WriteLine($"Length = {(rectangle as Rectangle).Length}");
                Console.WriteLine($"Area of Retangle is {rectangle.GetArea()}");
                Console.WriteLine("************************************");

                //
                Shape triangle = new Triangle(10, 2);

                //
                Console.WriteLine(triangle.ToString());
                triangle.Draw();
                Console.WriteLine($"Area of Trianle is {triangle.GetArea()}");

                //
                Console.WriteLine(rectangle is Rectangle);
                Console.WriteLine(triangle is Triangle);

                Console.WriteLine("*************************************");
                Shape shape = new Triangle(3,-2);
                //
                Console.WriteLine(shape.GetArea());

                //

                // (shape as Triangle).Height = -4;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}
