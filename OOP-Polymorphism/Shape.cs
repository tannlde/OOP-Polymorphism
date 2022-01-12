using System;

namespace OOP_Polymorphism
{
    // A abstract class has implement "IShape" interface
     abstract class Shape : IShape 
    {
        //sealed = final
        public String Color { get; set; } = "Blue";
        // public Shape (String color) {
        //     this.Color = color;
        // }

        // virtual: provide a default implementation.
        // Can be overridden if necessary

        public virtual void Draw() => Console.WriteLine("Drawing is not override!!!");

        // Must be override
        public abstract double GetArea();
        public abstract override String ToString();
    }
}
