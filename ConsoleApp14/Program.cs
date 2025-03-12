using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Васька", "Млындыш", 42);
            person.Output();
            Console.WriteLine();

            Employee empl = new Employee("Васька", "Млындыш", 42, "Апл", "уборщик");
            empl.Output();
            Console.WriteLine();

            Person perempl = new Employee("Васька", "Млындыш", 42, "Апл", "уборщик");
            perempl.Output();

            Student[] students = new Student[3]
        {
            new Student("Ваня", "Дленжов", 19, "10.02.2006", 2),
            new Student("Петя", "Пляжник", 20, "15.08.2005", 3),
            new Student("Никита", "Банчу", 18, "22.11.2007", 2)
        };
            foreach (Student student in students)
            {
                student.Output();
                Console.WriteLine();
            }
            List<Student> studentList = new List<Student>
        {
            new Student("Олег", "Ткаченко", 18, "05.06.2007", 2)
        };
            Console.WriteLine();
            foreach (Student student in studentList)
            {
                student.Output();
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
