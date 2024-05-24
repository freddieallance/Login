using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWPF.Model
{
    public class AgencyModel
    {
        private string agency_code;

        public string AgencyCode
        {
            get { return agency_code; }
            set { agency_code = value; }
        }
        private string agency_name;

        public string AgencyName
        {
            get { return agency_name; }
            set { agency_name = value; }
        }
    }
}
