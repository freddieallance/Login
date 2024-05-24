using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWPF.Model
{
    public class CashierModel
    {
        [Key] private int _ObjectID;
        private string _UserID;

        public string UserID { get; internal set; }
        private string _Username { get; set; }
       
    }
}
