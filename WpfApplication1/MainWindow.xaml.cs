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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        
        public MainWindow()
        {
            InitializeComponent();
            
            
            
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            
            Employee emp1 = new Employee(22, "tomasz", 4500, new DateTime(2012, 01, 01), "784016969");
            this.emp1txtblock.DataContext = emp1;
            //this.textBlock1.Text = emp1.Name;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Employee emp2 = new Employee(22, "employee 2", 3300, new DateTime(2013, 01, 01), "55665566");
            this.emp2txtblock.DataContext = emp2;
            MessageBox.Show("dodales emp2");
            
        }
    }
}
