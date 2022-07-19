using OCPLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PersonModel> applicants = new List<PersonModel>
            {
                new PersonModel { FirstName = "T'Pol", LastName = "Vulcaness" },
                new PersonModel { FirstName = "Seven", LastName = "OfNine"},  // UNDO to keep OCP , TypeOfEmployee = EmployeeType.Manager 
                new PersonModel { FirstName = "Nurse", LastName = "Chapel"}  // ,  TypeOfEmployee = EmployeeType.Executive 
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();
            Accounts accountProcessor = new Accounts();

            foreach (var person in applicants)
            {
                employees.Add(accountProcessor.Create(person));
            }

            foreach (var emp in employees)
            {
                Console.WriteLine($"{ emp.FirstName } { emp.LastName }: { emp.EmailAddress } IsManager: { emp.IsManager } IsExecutive: { emp.IsExecutive }");
            }

            Console.ReadLine();
        }
    }
}
