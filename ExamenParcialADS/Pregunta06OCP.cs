using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenParcialADS
{
    class Pregunta06OCP
    {
        static void main(string[] args)
        {

        }
    }
    public class Employee
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }

        public string GetFullName()
        {
            return Name + Lastname;
        }
    }
    public class SalaryCalculateEm
    {
        public int Calculate(Employee person, int workedDays)
        {
            var limitAge = 50;
            var salaryByDayUnder50 = 100;
            var salaryByDayOver50 = 120;
            var salary = 0;
            if (person == null) return 0;

            if (person.Age > limitAge) salary = workedDays * salaryByDayOver50;
            if (person.Age <= limitAge) salary = workedDays * salaryByDayUnder50;

            return salary;
        }
    }
}
