using MVVMdemo.Models;
using MVVMdemo.Commands;
using MVVMdemo.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMdemo.ViewModels
{
    internal class CustomerViewModel
    {
        /// <summary>
        /// kontruktor ktory inicjalizuje klase customerviewmodel 
        /// </summary>
        public CustomerViewModel()
        {
            _Customer = new Customer("tomasz");
            UpdateCommand = new CustomerUpdateCommand(this);
        }

        private Customer _Customer;
        /// <summary>
        /// Gets the customer instance
        /// </summary>
        public Customer Customer {
            get { return _Customer;} 
             
        }
        /// <summary>
        /// Gets the UpdateCommand for the ViewModel
        /// </summary>
        public ICommand UpdateCommand
        {
            get;
            private set;
        }
        /// <summary>
        /// Gets or sets a System.Boolean value indicating whether the Customer can be updated.
        /// </summary>
        public bool CanUpdate {
            get
            {
                if (Customer == null)
                {
                    return false;
                }
                return !String.IsNullOrWhiteSpace(Customer.Name);
            } 
            
        }
        /// <summary>
        /// Saves changes made to the Customer instance
        /// </summary>
        public void SaveChanges()
        {
            Debug.Assert(false, string.Format("{0} was updated", Customer.Name));
        }

        
    }
}
