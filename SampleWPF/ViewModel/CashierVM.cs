using SampleWPF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWPF.ViewModel
{
    class CashierVM : Utilities.ViewModelBase
    {
        private readonly CashierModel _cashierModel;
        public string CashierID
        {
            get { return _cashierModel.UserID; }
            set { _cashierModel.UserID = value; OnPropertyChanged(); }
        }

        public CashierVM()
        {
            _cashierModel = new CashierModel();
            CashierID = "sitihawa86";
        }
    }
}
