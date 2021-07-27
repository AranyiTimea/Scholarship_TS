using System;

namespace optional_2_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Greeting();

            Student student = new Student();
            student.SetAge(22);
            student.Greeting();
            student.ShowAge();
            student.GoToClasses();

            Teacher teacher = new Teacher();
            teacher.SetAge(33);
            teacher.Greeting();
            teacher.Explain();
        }
    }
}
