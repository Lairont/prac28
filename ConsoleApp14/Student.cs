using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Student : Person
    {
        private string date;
        private int course;

        public Student(string name, string surname, int age, string date, int course)
            : base(name, surname, age)
        {
            this.date = date;
            this.course = course;
        }

        public new void Output()
        {
            base.Output();
            Console.WriteLine($"Дата рождения: {date}\nКурс: {course}");
        }
    }
}
