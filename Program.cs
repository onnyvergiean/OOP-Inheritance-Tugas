using System;

namespace InheritanceTugas
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Mike", 20);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Rahma", 28, "16972", "Math");
            teacher.GetNameAndAge();

            Student student = new Student("Onny", 19, "19112731", "onny.s@students.amikom.ac.id");
            student.GetNameAndAge();

            Console.ReadKey();
        }
    }
}
