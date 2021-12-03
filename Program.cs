using System;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
         
        {
            Employee empl = new Employee("Vusal", "Ahmadzada", "developer", (decimal)5000);


               Console.WriteLine("Employee Name: {0}", empl.Name);
            Console.WriteLine("Employee Surname: {0}", empl.Surname);
            Console.WriteLine("Employee Positon: {0}", empl.Positon);
            Console.WriteLine("Employee DailySalary: {0:C}", empl.DailySalary);

            Console.ReadLine();

        }
    }
}
