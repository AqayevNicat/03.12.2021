using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.Name = "Nicat";
            employee1.Surname = "Aqayev";
            employee1.Position = "Administrator";
            employee1.DailySalary = 40;
            employee1.MonthlySalary();

            Employee employee2 = new Employee();
            employee2.Name = "John";
            employee2.Surname = "Lennon";
            employee2.Position = "Director";
            employee2.DailySalary = 500;
            employee2.DayCount = 20;
            employee2.MonthlySalary();
        }
    }
}