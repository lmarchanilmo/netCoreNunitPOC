using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace TherapyBrandsAutomation.DriverManagement.Builder
{
    public abstract class RemoteDriverBuilder<T> : DriverBuilder<T> 
    {
        public string RemoteHost { get; set; }

        public RemoteDriverBuilder()
        {
        }

        public override IWebDriver Build()
        {
            Uri uri = new Uri(RemoteHost);
            return new RemoteWebDriver(uri, (ICapabilities)LoadCapabilities());
        }

        public override T LoadCapabilities()
        {
            throw new NotImplementedException();
        }
    }
}
