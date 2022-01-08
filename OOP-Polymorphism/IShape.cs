
using System;
namespace OOP_Polymorphism
{
    // Default is internal 
    // But can only be internal or public
    interface IShape
    {
        // Default is public
        String Color { get; set; }

        // If it has implement (default interface methods)
        // it becomes a virtual extension method
        double GetArea() => 0;
    }

}

