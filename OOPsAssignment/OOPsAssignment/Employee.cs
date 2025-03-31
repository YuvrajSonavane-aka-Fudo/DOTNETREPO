// Employee.cs
using System;

public class Employee : Person
{
    public string JobTitle { get; set; }

    // Public constructor calling base constructor
    public Employee(string name, int age, string jobTitle)
        : base(name, age)
    {
        JobTitle = jobTitle;
    }

    // Override the DisplayDetails method
    public override void DisplayDetails()
    {
        base.DisplayDetails(); // Calls the base class method
        Console.WriteLine($"Job Title: {JobTitle}");
    }

    // Use 'new' to hide the Work method from the base class
    public new void Work()
    {
        Console.WriteLine($"{Name} is working as an Employee with the job title of {JobTitle}.");
    }

    // Static constructor
    static Employee()
    {
        Console.WriteLine("Static constructor of Employee called.");
    }
}
