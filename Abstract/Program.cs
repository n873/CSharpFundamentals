using System;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student();
            student.Name = "Abstract Nate";
            student.PrintName();

            Console.Read();
        }
    }

    abstract class Person {
        public int Age { get; set; } = 21;
        public abstract void PrintName();
    }

    class Student : Person {
        public string Name { get; set; }
        public override void PrintName()
        {
            Console.WriteLine($"Student name is {Name} and is {Age}.");
        }
    }
}
