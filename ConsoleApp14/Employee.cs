using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Employee : Person
    {
        private string company;
        private string job;

        public Employee(string name, string surname, int age, string company, string job)
            : base(name, surname, age)
        {
            this.company = company;
            this.job = job;
        }

        public new void Output()
        {
            base.Output();
            Console.WriteLine($"Компания: {company}\nРабота: {job}");
        }
    }
}
