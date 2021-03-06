﻿using System;

namespace Inheritance
{
    /// 1. What's Inheritance
    /// 
    ///    When an object or a class is based on a parent object 
    ///    or class taking on its characteristics
    ///    
    public class Employee
    {
        public virtual void CalculateWeeklySalary(int weeklyHours, int wage)
        {
            var salary = 40 * wage;
            Console.WriteLine($"\nThis Employee worked {weeklyHours} hrs. "
                + $"Paid for 40 hrs (no overtime) at $ {wage}"
                + $"/hr = ${salary} \n");
            Console.WriteLine("-------------------------------------------");
        }
    }
    public class Contractor : Employee
    {
        public override void CalculateWeeklySalary(int weeklyHours, int wage)
        {
            var salary = weeklyHours * wage;
            Console.WriteLine($"\nThis Contractor work {weeklyHours} hrs. "
                + $"Paid for {weeklyHours} hrs (w/ overtime) at $ {wage}"
                + $"/hr = ${salary}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            const int hours = 50, wage = 70;

            var person = new Employee();
            person.CalculateWeeklySalary(hours, wage);

            var contractor = new Contractor();
            contractor.CalculateWeeklySalary(hours, wage);

            Console.Read();
        }
    }
}
