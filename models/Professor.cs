using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCollege.models
{
    internal class Professor : Person
    {
        public double Salary { get; set; }

        public Professor() { }

        public Professor(int id, string address, DateTime dateofbirth, double salary) : base(id, address, dateofbirth)
        {
            Salary = salary;
        }

        public double CalculateSalary(double grossPay, double totalAllowances)
        {
            return Salary = grossPay - totalAllowances;
            
        }

        public override string PrintDetails()
        {
            return $"{base.PrintDetails()}\nSalary: {Salary}";
        }



    }
}
