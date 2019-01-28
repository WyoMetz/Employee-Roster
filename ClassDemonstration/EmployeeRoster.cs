using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemonstration
{
    public class EmployeeRoster
    {
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public List<Manager> Managers { get; set; } = new List<Manager>();

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public void AddManagers(Manager manager)
        {
            Managers.Add(manager);
        }
    }
}
