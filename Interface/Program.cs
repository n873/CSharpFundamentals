using System;

namespace Interface
{
    /// 1. Whats an Interface?
    ///    They're used to specify methods and properties that a derived class
    ///    will have access to.
    ///    - Like a contract. If a class implements an interface, 
    ///    the interface guarantees that the class contains specific methods specified.
    ///    - DO NOT contain code or data
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student();
            student.Name = "Interface Nate";
            student.PrintName();
            Console.Read();
        }
    }

    interface Person { void PrintName(); }

    class Student : Person {
        public string Name { get; set; }
        public void PrintName() {
            Console.WriteLine($"Student name is {Name}.");
        }
    }
}
