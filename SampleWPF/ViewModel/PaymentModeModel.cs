using SampleWPF.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWPF.ViewModel
{
    public class PaymentModeVM
    {
        private ObservableCollection<PaymentModeModel> _modes;
        public ObservableCollection<PaymentModeModel> Modes
        {
            get { return _modes; }
            set { _modes = value; }
        }

        private PaymentModeModel _smode;
        public PaymentModeModel SMode
        {
            get { return _smode; }
            set { _smode = value; }
        }

        // Constructor for the AgencyVM class
        public PaymentModeVM()
        {
            Modes = new ObservableCollection<PaymentModeModel>()
            {
                new PaymentModeModel() { ModeCode = "2", ModePayment = "Cheque"},
                new PaymentModeModel() { ModeCode = "3", ModePayment = "Postal Order"},
                new PaymentModeModel() { ModeCode = "4", ModePayment = "Money Order"},
                new PaymentModeModel() { ModeCode = "5", ModePayment = "Bank Draft"},
                new PaymentModeModel() { ModeCode = "6", ModePayment = "Credit Card"},
                new PaymentModeModel() { ModeCode = "7", ModePayment = "Debit Card"},
                new PaymentModeModel() { ModeCode = "8", ModePayment = "Non Cash"},
                new PaymentModeModel() { ModeCode = "10", ModePayment = "Sarawak Pay"},
                new PaymentModeModel() { ModeCode = "11", ModePayment = "DuitNow"}
            };
        }
    }
}
