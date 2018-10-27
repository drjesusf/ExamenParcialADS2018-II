using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenParcialADS
{
    public class Pregunta04
    {
        public bool AssignBooleansImplicitlyDirty()
        {
            bool isNaturalPerson = false;
            if (isNaturalPerson == true) return true;

            return true;
        }

        public bool AssignBooleansImplicitlyClean()
        {
            return false;
        }

        public bool ReturnEarlyDirty(Person person)
        {
            if (person != null)
            {
                if (person.Age > 18 && !string.IsNullOrEmpty(person.Name))
                {
                    return true;
                }
                else if (person.Age < 18) return false;
            }
            else if (person == null)
            {
                return false;
            }
            return false;
        }
        public bool ReturnEarlyClean(Person person)
        {
            if (person == null) return false;
            if (person.Age < 0) return false;
            if (string.IsNullOrEmpty(person.Name)) return false;
            int ageMax = 18;

            if (person.Age > ageMax) return true;
            return false;
        }


    }

    public class Person
    {
        public int Age{ get; set; }
        public string Name { get; set; }
    }
}
