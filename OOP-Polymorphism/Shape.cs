using System;

namespace OOP_Polymorphism
{
    abstract class Shape:IShape
    {
        public String Color { get; set; } = "Blue";
       
        public virtual void Draw()
        {
            Console.WriteLine("Drawing is not overrided!!!");
        }
        public abstract double GetArea();
        public abstract override String ToString();
    }
}
