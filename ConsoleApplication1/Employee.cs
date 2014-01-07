using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace ConsoleApplication1
{
    public class EmployeeList : ObservableCollection<Employee>
    {
        public EmployeeList() : base()
        {
            Add(new Employee(33,"tomasz", 4500, DateTime.Now,"784016969"));
            Add(new Employee(12,"mietek", 2344, DateTime.Now,"784016969"));

        }

    }
    
    public class Employee
    {
        public Employee(int age, string name, double salary, DateTime startingDate, string phonenumber)
        {
            Age = age;
            Name = name;
            Salary = salary;
            StartingDate = startingDate;
            PhoneNumber = phonenumber;
            //BonusValue = bonusValue;
            //TotalSalaryValue = totalsalaryvalue;
        }
        public Employee()
        { 
        }
        
        //private int age;
        //public int Age
        //{
        //    get { return age;}
        //    set{age =  value;}
        //}
        public int Age { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public DateTime StartingDate { get; set; }
        public string PhoneNumber { get; set; }
        public double BonusValue { get; set; }
        public double TotalSalaryValue { get; set; }
        
        public void Bonus(double bonusPercent)
        {
            BonusValue = bonusPercent;
            Salary += Salary * bonusPercent;
        }
        public void TotalSalary()
        {

            //int currentMonth = (DateTime.Now).Month;
            //int startingMonth = StartingDate.Month;
            //int currentYear = DateTime.Now.Year;
            //int startingYear = StartingDate.Year;
            //int iloscMiesiecy = (currentYear - startingYear) * 12 + currentMonth - startingMonth;

            TimeSpan t = DateTime.Now - StartingDate;
            double iloscMiesiecy = (t.TotalDays / 365.25) * 12;
            double iloscMiesiecyRounded = Math.Floor(iloscMiesiecy);
            TotalSalaryValue = iloscMiesiecyRounded * Salary;
        }


    }
}
