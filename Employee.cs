using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Employee
    {
        public string Name;
        public string Surname;
        public string Position;
        public int DailySalary;
        public int DayCount = 30;

        public void MonthlySalary()
        {
            Console.WriteLine(
                $" Name : {Name}\n" +
                $" Surname : {Surname}\n" +
                $" Position :  {Position}\n" +
                $" Salary : {DayCount * DailySalary}\n"
                );
        }
    }
}
