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
        Person person;
        Employee employee;
        Manager manager;

        public void Execute()
        {
            Console.WriteLine("Please Enter the Persons Name");
            GetPerson();

            Console.WriteLine($"Please enter {person.Name}'s Employee ID");
            MakeEmployee();

            Console.WriteLine($"Please set {employee.Person.Name}'s Wage");
            SetWage();

            Console.WriteLine($"Would you like to make {employee.Person.Name} a Manager?");
            string newManager = Console.ReadLine();
            if (newManager.ToLower().Contains("yes"))
            {
                MakeManager();
            }
            else
            {
                Console.WriteLine($"{employee.Person.Name}'s Wage is {employee.Wage:c}");
            }

            Console.WriteLine("\nWould you like to set another employee?");
            string input = Console.ReadLine();
            if (input.ToLower().Contains("yes"))
            {
                Execute();
            }
        }

        public void GetPerson()
        {
            string name = validate.String(Console.ReadLine());
            if(validate.Invalid != true)
            {
                person = new Person(name);
            }
            else
            {
                Console.WriteLine("Please enter a valid Name");
                GetPerson();
            }
        }

        public void MakeEmployee()
        {
            int id = validate.Int(Console.ReadLine());
            if(validate.Invalid != true)
            {
                employee = new Employee(person, id);
            }
            else
            {
                Console.WriteLine("Please enter a valid ID number");
                MakeEmployee();
            }
        }

        public void SetWage()
        {
            int wage = validate.Int(Console.ReadLine());
            if (validate.Invalid != true)
            {
                employee.Wage = wage;
            }
            else
            {
                Console.WriteLine("Please enter a valid number for Wage");
                SetWage();
            }
        }

        public void MakeManager()
        {
            Console.WriteLine($"{employee.Person.Name} is now a Manger");
            manager = new Manager(employee);
            Console.Write($"{manager.Employee.Person.Name}'s Wage is now {manager.Wage:c}");
        }
    }
}
