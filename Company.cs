using System;
using System.Collections.Generic;

namespace classes_list_employees {
   public class Company 
    {
        public Company(string name, DateTime date) {
        CompanyName = name;
        DateFounded = date;
    }
        public string CompanyName { get; }
        public DateTime DateFounded { get; }
        
        public List<Employee> Employees = new List<Employee>();

        public void ListEmployees()
        {
            foreach (Employee employee in Employees)
            {
                Console.WriteLine(employee.FirstName);
            }
        }
        
        

    }
}