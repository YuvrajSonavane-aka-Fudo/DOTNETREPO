// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        // Demonstrating Static Constructor
        Console.WriteLine("Creating a Person object...");
        Person person = new Person("John Doe", 30);
        person.DisplayDetails();
        person.Work();

        Console.WriteLine();

        // Demonstrating Employee class with Static Constructor
        Console.WriteLine("Creating an Employee object...");
        Employee employee = new Employee("Alice Smith", 28, "Software Engineer");
        employee.DisplayDetails();
        employee.Work();

        Console.WriteLine();

        // Demonstrating Interface Implementation
        IWork work1 = new Person("Bob", 35);
        work1.Work(); // Calls Person's Work method

        IWork work2 = new Employee("Charlie", 25, "Manager");
        work2.Work(); // Calls Employee's Work method
    }
}
