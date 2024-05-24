using SampleWPF.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWPF.ViewModel
{
    public class AgencyVM
    {
        private ObservableCollection<AgencyModel> _agencies;
        public ObservableCollection<AgencyModel> Agencies
        {
            get { return _agencies; }
            set { _agencies = value; }
        }

        private AgencyModel _sagency;
        public AgencyModel SAgency
        {
            get { return _sagency; }
            set { _sagency = value; }
        }

        // Constructor for the AgencyVM class
        public AgencyVM()
        {
            Agencies = new ObservableCollection<AgencyModel>()
            {
                new AgencyModel() { AgencyCode = "LAKU", AgencyName = "LAKU"},
                new AgencyModel() { AgencyCode = "STM", AgencyName = "TELEKOM MALAYSIA"},
                new AgencyModel() { AgencyCode = "SESCO", AgencyName = "SARAWAK ELECTRICITY SUPPLY CORPORATION"},
                new AgencyModel() { AgencyCode = "GAS", AgencyName = "SARAWAK GAS"},
                new AgencyModel() { AgencyCode = "B1", AgencyName = "MAJLIS BANDARAYA MIRI"}
            };
        }
    }
}
