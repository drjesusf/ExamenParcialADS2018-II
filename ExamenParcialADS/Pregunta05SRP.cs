using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenParcialADS
{
    class Pregunta05SRP
    {

        static void Main(string[] args)
        {
            var workPerson = new WorkPerson { Name = "Jesus", Lastname = "Ramirez", Age = 30 };
            var workedDays = 25;
            var calculator = new SalaryCalculate();
            Console.WriteLine("El sueldo por los " + workedDays + " trabajados es: " + calculator.Calculate(workPerson, workedDays));
            Console.WriteLine("Presione una tecla para salir");
            Console.ReadLine();
        }
    }
    public class WorkPerson
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }

        public string GetFullName()
        {
            return Name+Lastname;
        } 
    }
    public class SalaryCalculate
    {
        public int Calculate(WorkPerson person, int workedDays)
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
