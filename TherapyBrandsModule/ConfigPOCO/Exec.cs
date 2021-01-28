using System;
using TherapyBrandsAutomation.DriverManagement.Factory;

namespace TherapyBrandsModule.ConfigPOCO
{
    public class Exec
    {
        public string RemoteHost { get; set; }
        public bool Remote { get; set; }
        public BrowserType Browser { get; set; }
        public string LocalPartialPath { get; set; }
        public string Url { get; set; }

        public Exec()
        {
        }
    }
}
