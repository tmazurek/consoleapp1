using ConsoleApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ListBind
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            Dictionary<string, int> nowykupa = new Dictionary<string, int>();
            nowykupa.Add("ala ma kota", 1);
            nowykupa.Add("ala ma kota", 2);
            nowykupa.Add("ala ma kota", 3);
            nowykupa.Add("ala ma kota", 4);
            nowykupa.Add("ala ma kota", 5);
            DataContext = nowykupa;
        }
    }
}
