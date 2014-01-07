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


        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Employee emp2 = new Employee(Convert.ToInt32(AgetextBox.Text) , NametextBox.Text , Convert.ToInt32(SalarytextBox.Text), Convert.ToDateTime(StartingDatetextBox.Text), PhoneNumbertextBox.Text);
            this.emp2txtblock.DataContext = emp2;
            
            
        }
    }
}
