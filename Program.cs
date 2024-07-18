using StudentCollege.models;

namespace StudentCollege
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(1, "123 elm St", new(2002,5,10));

            Professor professor1 = new Professor(11, "983 llm St", new(1989, 4, 1), 0); //yr/month/date
            
            Student student1 = new Student(64, "Mumbai", new(2002,7,28), "SCM");

           

            professor1.CalculateSalary(7000, 1000);
            Details(person);
            Details(professor1);
            Details(student1);
           
           
        }

        static void Details(Person person)
        {
            Console.WriteLine($"========================={ person.GetType().Name}===========================================");
            Console.WriteLine($"{ person.PrintDetails()}\n");

        }
    }
}
