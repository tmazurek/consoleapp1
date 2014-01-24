using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2
{
    public class MainWindowViewModel
    {
        public MainWindowViewModel()
        {
            MyDict = new Dictionary<string, string>
        {
            {"First", "Test1"},
            {"Second", "Test2"}
        };
        }
        private Dictionary<string, string> _MyDict;

        public Dictionary<string, string> MyDict
        {
            get { return _MyDict; }
            set { _MyDict = value; }
        }
    }
}
