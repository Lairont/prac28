using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Васька", "Млындыш", 42);
            person.Output();
            Console.WriteLine();
            Employee empl = new Employee("Васька", "Млындыш", 42, "Апл", "уборщик");
            empl.Output();
            Console.WriteLine();
            Person  perempl= new Employee("Васька", "Млындыш", 42, "Апл", "уборщик");
            perempl.Output();
            Console.ReadLine();
                
        }
    }
}
