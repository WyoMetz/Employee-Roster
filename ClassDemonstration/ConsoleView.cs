using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemonstration
{
    public class ConsoleView
    {
        InputValidation validate = new InputValidation();
        EmployeeRoster roster = new EmployeeRoster();
        Person person;
        Employee employee;
        Manager manager;

        public void Execute()
        {
            Console.WriteLine("Please enter a Persons Name");
            GetPerson();

            Console.WriteLine($"Please enter {person.Name}'s Employee ID");
            MakeEmployee();

            Console.WriteLine($"Please set {employee.Person.Name}'s Wage per hour");
            SetWage();

            Console.WriteLine($"Would you like to make {employee.Person.Name} a Manager?");
            string newManager = Console.ReadLine();
            if (newManager.ToLower().Contains("yes"))
            {
                MakeManager();
            }
            else
            {
                roster.AddEmployee(employee);
                Console.WriteLine($"{employee.Person.Name}'s Wage is {employee.Wage:c}");
            }

            Console.WriteLine("\nWould you like to set another employee?");
            string input = Console.ReadLine();
            if (input.ToLower().Contains("yes"))
            {
                Execute();
            }
            else
            {
                GetRoster();
                Console.ReadLine();
            }
        }

        private void GetPerson()
        {
            string name = validate.String(Console.ReadLine());
            if(validate.InputInvalid != true)
            {
                person = new Person(name);
            }
            else
            {
                Console.WriteLine("Please enter a valid Name");
                GetPerson();
            }
        }

        private void MakeEmployee()
        {
            int id = validate.Int(Console.ReadLine());
            if(validate.InputInvalid != true)
            {
                employee = new Employee(person, id);
            }
            else
            {
                Console.WriteLine("Please enter a valid ID number");
                MakeEmployee();
            }
        }

        private void SetWage()
        {
            int wage = validate.Int(Console.ReadLine());
            if (validate.InputInvalid != true)
            {
                employee.Wage = wage;
            }
            else
            {
                Console.WriteLine("Please enter a valid number for Wage");
                SetWage();
            }
        }

        private void MakeManager()
        {
            Console.WriteLine($"{employee.Person.Name} is now a Manger");
            manager = new Manager(employee);
            roster.AddManagers(manager);
            Console.Write($"{manager.Employee.Person.Name}'s Wage is now {manager.Wage:c}");
        }

        private void GetRoster()
        {
            if(roster.Employees.Count > 0)
            {
                Console.WriteLine("Your Employees are:");
                foreach (var Employee in roster.Employees)
                {
                    Console.WriteLine($"{Employee.Person.Name} who's ID is {Employee.EmployeeID} and whose Wage is {Employee.Wage:c} per hour");
                }
            }
            if(roster.Managers.Count > 0)
            {
                Console.WriteLine("Your Managers are:");
                foreach (var Manager in roster.Managers)
                {
                    Console.WriteLine($"{Manager.Employee.Person.Name} who's ID is {Manager.Employee.EmployeeID} and whose Wage is {Manager.Wage:c} per hour");

                }
            }
        }
    }
}
