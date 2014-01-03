using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee()
            {
                Age = 11,
                Name = "Dabit Smith",
                Salary = 4500,
                StartingDate = new DateTime(2012, 01, 01),
                PhoneNumber = "784016969"
            };
            
            emp1.Bonus(0.2);
            emp1.TotalSalary();
            Console.WriteLine("employee Name is {0} \nAge: {1}, \nMonthly Salary: {2}, \nStarted on: {3} \nBonus Value: {4} \nTotalSalary Value: {5} \n", emp1.Name, emp1.Age, emp1.Salary, emp1.StartingDate.ToShortDateString(), emp1.BonusValue, emp1.TotalSalaryValue);
            

            Employee emp2 = new Employee(33, "Tomasz Mazurek", 4500, new DateTime(2012, 01, 01), "784016969");
            Console.WriteLine("employee name: {0} \nAge:{1} \nMonthly Salary{2} \nStarted on:{3} \nBonus Value:{4} \nTotal Salary:{5} \n", emp2.Name, emp2.Age, emp2.Salary, emp2.StartingDate, emp2.BonusValue, emp2.TotalSalaryValue);
            emp2.Bonus(0.10);
            emp2.TotalSalary();
            Console.WriteLine("employee name: {0} \nAge:{1} \nMonthly Salary{2} \nStarted on:{3} \nBonus Value:{4} \nTotal Salary with Bonus:{5}", emp2.Name, emp2.Age,  emp2.Salary, emp2.StartingDate, emp2.BonusValue, emp2.TotalSalaryValue);
            Console.ReadLine();
        }
    }
}
