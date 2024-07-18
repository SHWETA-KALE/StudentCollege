using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCollege.models
{
    internal class Student : Person
    {
        public string Branch { get; set; }

        public Student() { }

        public Student(int id, string address, DateTime dateofbirth, string branch) : base(id, address, dateofbirth)
        {
            Branch = branch;
        }

        public override string PrintDetails()
        {
            return $"{base.PrintDetails()}\nBranch:{Branch}";
        }
    }
}
