using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemonstration
{
    public class Employee
    {
        public string JobTitle { get; set; }
        public Person Person { get; set; }
        public int Wage { get; set; }
        public int EmployeeID { get; set; }

        public Employee(Person person, int ID)
        {
            Person = person;
            EmployeeID = ID;
        }
    }
}
