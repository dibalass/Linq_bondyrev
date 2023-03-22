using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Person
    {
        string name,lastname,secondname;
        int age, weight;
        public string LastName { get { return lastname; } set { lastname = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string SecondName { get { return secondname; } set { secondname = value; } }
        public int Age { get { return age; } set { age = value; } }
        public int Weight { get { return weight; } set { weight = value; } }

        public Person(string lastname, string name, string secondname, int age, int weight)
        {
            LastName = lastname;
            Name = name;
            SecondName = secondname;
            Age = age;
            Weight = weight;
        }
        public string Info()
        {
            return $"{LastName} {Name} {SecondName} {Age} {Weight}";
        }
    }
}
