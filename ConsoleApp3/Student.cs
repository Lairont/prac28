using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Student
    {
       private int year;
        private int course;
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public int Course
        {
            get { return course; }
            set { course = value; }
        }
        public Student(int year, int course)
        {
            this.Year = year;
            this.Course = course;
        }
        public void Output2()
        {
            Console.WriteLine($"Дата рождения:{Year}\nКурс обучения:{Course}");
        }
    }
}
