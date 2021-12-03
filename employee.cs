using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        private decimal Salary;
        public string Positon { get; set; }
        public Employee(string name, string surname, decimal dailySalary, string positon)
        {
            Name = name;
            Surname = surname;
            Positon = positon;
            Salary = dailySalary;
        }
        public decimal salary
        {
            get { return _salary; }
            set
            {
                if (value >= 0)
                    _salary = value;

            }
        }

        public decimal _salary { get; private set; }
    }
}
