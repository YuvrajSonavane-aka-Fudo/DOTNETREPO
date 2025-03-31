// Person.cs
using System;

public class Person : IWork
{
    public string Name { get; set; }
    public int Age { get; set; }

    // Public constructor
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Virtual method to be overridden
    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }

    // Interface method implementation
    public void Work()
    {
        Console.WriteLine($"{Name} is working as a Person.");
    }

    // Static constructor
    static Person()
    {
        Console.WriteLine("Static constructor of Person called.");
    }
}
