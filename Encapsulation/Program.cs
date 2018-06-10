using System;

namespace Encapsulation
{
    /// 1. What is Encapsulation
    /// 
    ///    Is about preventing access to implementation details
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

        //Cant be access 
        private void test() { }
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
