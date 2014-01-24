using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MVVMdemo.Models
{
    public class Customer:INotifyPropertyChanged
    {
       public Customer (string customerName)
	{
           Name = customerName;
	}
        string _Name;
        public string Name 
        { 
            
            get{
                return _Name;
            } 
            set{
                _Name = value;
                OnPropertyChanged("Name");
            }
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
