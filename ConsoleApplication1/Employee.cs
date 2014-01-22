using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ConsoleApplication1
{
    public class EmployeeList : ObservableCollection<Employee>
    {
    }

    public class Employee : INotifyPropertyChanged
    {


        private int age;
        public int Age
        {

            get { return age; }
            set
            {
                age = value;
                OnPropertyChanged();
            }
        }


        string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }

        int salary;
        public int Salary
        {
            get { return salary; }
            set
            {
                salary = value;
                OnPropertyChanged();
            }
        }

        DateTime startingDate;
        public DateTime StartingDate
        {
            get { return startingDate; }
            set
            {
                startingDate = value;
                OnPropertyChanged();

            }
        }

        string phoneNumber;
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                phoneNumber = value;
                OnPropertyChanged();
            }
        }

        public double BonusValue { get; set; }
        public double TotalSalaryValue { get; set; }


        public static Employee getEmployee()
        {
            var emp = new Employee() { Age = 33, Name = "tomek", Salary = 44233, StartingDate = DateTime.Now, PhoneNumber = "343432444" };
            return emp;
        }

        public static ObservableCollection<Employee> getEmployees()
        {
            var employees = new ObservableCollection<Employee>();
            employees.Add(new Employee { Age = 33, Name = "tomek", Salary = 44233, StartingDate = DateTime.Now, PhoneNumber = "343432444" });
            employees.Add(new Employee { Age = 33, Name = "tomek", Salary = 44233, StartingDate = DateTime.Now, PhoneNumber = "343432444" });
            employees.Add(new Employee { Age = 33, Name = "tomek", Salary = 44233, StartingDate = DateTime.Now, PhoneNumber = "343432444" });
            employees.Add(new Employee { Age = 33, Name = "tomek", Salary = 44233, StartingDate = DateTime.Now, PhoneNumber = "343432444" });
            return employees;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string caller = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }

        }
    }
}
