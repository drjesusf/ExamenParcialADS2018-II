using System;
using System.Collections.Generic;
using System.Text;

namespace Pregunta06OCP
{
    public class WorkPerson
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }

        public string GetFullName()
        {
            return Name + Lastname;
        }
    }
}
