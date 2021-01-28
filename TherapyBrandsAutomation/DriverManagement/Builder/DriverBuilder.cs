using System;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace TherapyBrandsAutomation.DriverManagement.Builder
{
    public abstract class DriverBuilder<T>
    {
        public abstract IWebDriver Build();

        public abstract T LoadCapabilities();
    }
}
