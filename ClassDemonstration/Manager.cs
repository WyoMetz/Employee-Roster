using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemonstration
{
    public class Manager
    {
        public Employee Employee { get; set; }
        public int Wage { get; private set; }

        public Manager(Employee employee)
        {
            Employee = employee;
            Wage = Employee.Wage * 2;
        }
    }
}
