using MVVMpracticalJoelCochran.Helpers;
using MVVMpracticalJoelCochran.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMpracticalJoelCochran.ViewModels
{
    public class MainWindowsViewModel : ViewModelBase
    {
        //parameterless constructor for BLEND
        public MainWindowsViewModel()
        {

        }
        
        string _SearchOwnerName;
        public string  SearchOwnerName {
            get 
            {
                return _SearchOwnerName;
            }

            set
            {
                value = _SearchOwnerName;
                RaisePropertyChanged("SearchOwnerName");
            }
        }
        private ObservableCollection<RealEstateMaster> _realEstateRecords;
        public ObservableCollection<RealEstateMaster> RealEstateRecords {
            get
            {
                return _realEstateRecords;
            }
            set
            {
                value = _realEstateRecords;
                RaisePropertyChanged("RealEstateRecords");

            }
        }
    }
}
