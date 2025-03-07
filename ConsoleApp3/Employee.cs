using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Employee:Person
    {
        private string company;
        private string job;
        public string Company
        {
            get { return company; }
            set { company = value; }
        }
        public string Job
        {
            get { return job; }
            set { job = value; }
        }
        public Employee(string name, string surname, int age, string company, string job) : base(name,surname,age)
        {
            this.Company = company;
            this.Job = job;
        }
        new public void Output()
        {
            base.Output();
            Console.WriteLine($"Компания:{Company}\nРабота:{Job}");
        }
    }
}
