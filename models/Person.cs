using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCollege.models
{
    //parent
    internal class Person
    {
        public int Id { get; set; }
        public string Address { get; set; }

        public DateTime DateOfBirth { get; set; }

        //constructors
        public Person() { }

        public Person(int id,string address, DateTime dateofbirth)
        {
            Id = id;
            Address = address;
            DateOfBirth = dateofbirth;
        }

        public virtual string PrintDetails()
        {
            return $"Id: {Id}\n" +
                $"Address: {Address}\n" +
                $"Date Of Birth: {DateOfBirth.ToString("MM/dd/yyyy")}";
        }


    }
}
