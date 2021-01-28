using System;
using OpenQA.Selenium;
using TherapyBrandsAutomation.DriverManagement.Builder;
using TherapyBrandsAutomation.DriverManagement.Factory;

namespace TherapyBrandsAutomation.DriverManagement.Factory
{
    public class DriverFactory
    {
        public string LocalPartialPath { get; set; }
        public BrowserType Browser { get; set; }
        public bool Remote { get; set; }
        public string RemoteHost { get; set; }

        public IWebDriver NewInstance()
        {
            IWebDriver driver;
            if (Remote)
            {
                driver = GetRemoteDriver();
            }
            else
            {
                driver = GetLocalDriver();
            }
            
            return driver;
        }

        private IWebDriver GetLocalDriver()
        {

            IWebDriver driver;

            switch (Browser)
            {
                case BrowserType.CHROME:
                    driver = new ChromeDriverBuilder(LocalPartialPath).Build();
                    break;
                case BrowserType.FIREFOX:
                    driver = null; 
                    break;
                case BrowserType.IE:
                    driver = null;
                    break;
                default:
                    driver = new ChromeDriverBuilder(LocalPartialPath).Build();
                    break;
            }

            return driver;
        }

        private IWebDriver GetRemoteDriver()
        {

            IWebDriver driver;

            switch (Browser)
            {
                case BrowserType.CHROME:
                    driver = new ChromeRemoteDriverBuilder(RemoteHost).Build();
                    break;
                case BrowserType.FIREFOX:
                    driver = null;
                    break;
                case BrowserType.IE:
                    driver = null;
                    break;
                default:
                    driver = new ChromeRemoteDriverBuilder(RemoteHost).Build();
                    break;
            }
            return driver;
        }
    }
}
