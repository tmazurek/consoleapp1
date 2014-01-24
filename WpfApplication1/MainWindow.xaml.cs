using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ConsoleApplication1;
using System.Collections.ObjectModel;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        EmployeeList ListaEmployow = new EmployeeList();
        List<Employee> NowaLista = new List<Employee>();
        ObservableCollection<Employee> nowaObser = new ObservableCollection<Employee>();
        
        
        public MainWindow()
        {
            InitializeComponent();
            //this.dataGrid1.DataContext = new object[] {new Test2() {ID=11, Name="name", Comment="comment" }};
            //Employee emp2 = new Employee(Convert.ToInt32(AgetextBox.Text) , NametextBox.Text , Convert.ToInt32(SalarytextBox.Text), Convert.ToDateTime(StartingDatetextBox.Text), PhoneNumbertextBox.Text);
            //Employee emp3 = new Employee(Convert.ToInt32(AgetextBox.Text), NametextBox.Text, Convert.ToInt32(SalarytextBox.Text), Convert.ToDateTime(StartingDatetextBox.Text), PhoneNumbertextBox.Text);
            

            this.dataGrid1.DataContext = nowaObser;
            this.EmployeeDisplayStackpanel.DataContext = Employee.getEmployee();
            this.ListViewTest.DataContext = Employee.getEmployees();
        }


        public void button2_Click(object sender, RoutedEventArgs e)
        {
            //this.dataGrid1.DataContext = new object[] { emp2, emp3 };

            //Employee emp2 = new Employee(Convert.ToInt32(AgetextBox.Text), NametextBox.Text, Convert.ToInt32(SalarytextBox.Text), Convert.ToDateTime(StartingDatetextBox.Text), PhoneNumbertextBox.Text);
            //Employee emp3 = new Employee(Convert.ToInt32(AgetextBox.Text), NametextBox.Text, Convert.ToInt32(SalarytextBox.Text), Convert.ToDateTime(StartingDatetextBox.Text), PhoneNumbertextBox.Text);
            //List<Employee> ListaEmploow = new List<Employee>();
            //ListaEmployow.Add(new Employee(Convert.ToInt32(AgetextBox.Text), NametextBox.Text, Convert.ToInt32(SalarytextBox.Text), Convert.ToDateTime(StartingDatetextBox.Text), PhoneNumbertextBox.Text));
            nowaObser.Add(new Employee(){Age=Convert.ToInt32(AgetextBox.Text),Name= NametextBox.Text,Salary =  Convert.ToInt32(SalarytextBox.Text),StartingDate= Convert.ToDateTime(StartingDatetextBox.Text),PhoneNumber=  PhoneNumbertextBox.Text});
            
            //ListaEmploow.Add(emp2);
            //ListaEmploow.Add(emp3);
            
            //this.emp2txtblock.DataContext = emp2;
        }
    }
}
