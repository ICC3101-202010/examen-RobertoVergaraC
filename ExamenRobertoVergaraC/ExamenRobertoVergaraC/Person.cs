using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenRobertoVergaraC
{
    public abstract class Person
    {
        protected string name;
        protected int age;
        protected string nacionality;
        protected double salary;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Nacionality { get => nacionality; set => nacionality = value; }
        public double Salary { get => salary; set => salary = value; }

        public Person(string name, int age, string nacionality, double salary)
        {
            this.name = name;
            this.age = age;
            this.nacionality = nacionality;
            this.salary = salary;
        }

        abstract public string Info();

        public void Show()
        {
            Console.WriteLine(this.Info());
        }
    }
}
