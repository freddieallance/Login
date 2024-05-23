using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWPF
{
    //class to model data that is received from sample api
    public class APIData
    {
        public int count { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
        public double probability { get; set; }
    }
}
