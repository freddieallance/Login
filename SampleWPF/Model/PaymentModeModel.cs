using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWPF.Model
{
    public class PaymentModeModel
    {
        private string mode_code;

        public string ModeCode
        {
            get { return mode_code; }
            set { mode_code = value; }
        }
        private string mode_payment;

        public string ModePayment
        {
            get { return mode_payment; }
            set { mode_payment = value; }
        }

    }
}
