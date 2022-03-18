using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio_Listas
{
    internal class Employee
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public double Salary { get; set; }




        public Employee(int id, string name, double salary)
        {
            ID = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(double percentage)
        {
            Salary += Salary * percentage / 100;
        }

        public override string ToString()
        {
            return ID + ", " + Name + ", " + Salary;
        }


    }
}
