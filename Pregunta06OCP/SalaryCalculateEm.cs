using System;
using System.Collections.Generic;
using System.Text;

namespace Pregunta06OCP
{
    public class SalaryCalculateEm
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
