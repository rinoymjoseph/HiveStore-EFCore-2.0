using HiveStore.DataAccess;
using HiveStore.DataAccess.Employee.Repository;
using HiveStore.DataAccess.Employee.Repository.Interface;
using HiveStore.Entity.Employee;
using System;

namespace HiveStore.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            InsertEmployees();
            Console.ReadKey();
        }

        private static void InsertEmployees()
        {
            CreateEmployee("Joy", "Smith", "Los Angeles", "USA");
            CreateEmployee("Abram", "Ivanov", "Moscow", "Russia");
            CreateEmployee("Aryan", "Sodhi", "Delhi", "India");
            CreateEmployee("James", "Williams", "Sidney", "Australia");
            CreateEmployee("Muhammed", "Emir", "Istanbul", "Turkey");
        }

        private static void CreateEmployee(string firstName, string lastName, string city, string country)
        {
            EmployeeEntity employee = new EmployeeEntity();
            employee.City = city;
            employee.Country = country;
            employee.FirstName = firstName;
            employee.LastName = lastName;
            employee.CreatedBy = System.Environment.UserName;
            employee.ModifiedBy = System.Environment.UserName;
            employee.CreatedDate = DateTime.Now;
            employee.ModifiedDate = DateTime.Now;
            using (HiveDataContext hsDataContext = new HiveDataContext())
            {
                IEmployeeRepository empRepository = new EmployeeRepository(hsDataContext);
                empRepository.AddEmployee(employee);
                string message = empRepository.SaveChanges();
                Console.WriteLine(message);
            }
        }
    }
}
