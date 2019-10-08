using System;

namespace classes_list_employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company1 = new Company("Amazon", new DateTime(2019, 10, 08));
            Console.WriteLine($"{company1.CompanyName} {company1.DateFounded}");

            Employee employee1 = new Employee();
            {
                employee1.FirstName = "Bob";
                employee1.LastName = "Richardson";
                employee1.Title = "CEO";
                employee1.StartDate = new DateTime(2019, 10, 08);
            };
            Employee employee2 = new Employee();
            {
                employee2.FirstName = "Chris";
                employee2.LastName = "Harrison";
                employee2.Title = "Producer";
                employee2.StartDate = new DateTime(2019, 10, 10);
            };
            Employee employee3 = new Employee();
            {
                employee3.FirstName = "Peter";
                employee3.LastName = "Something";
                employee3.Title = "The bachelor";
                employee3.StartDate = new DateTime(2019, 10, 20);
            };

            company1.Employees.Add(employee1);
            company1.Employees.Add(employee2);
            company1.Employees.Add(employee3);

            foreach (Employee employee in company1.Employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} works for {company1.CompanyName} as {employee.Title} since {employee.StartDate}");
            }
        }
    }
}
