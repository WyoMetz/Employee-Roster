using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemonstration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Building an employee Roster");
            ConsoleView view = new ConsoleView();
            view.Execute();
        }
    }
}
