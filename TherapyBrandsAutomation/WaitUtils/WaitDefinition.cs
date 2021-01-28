using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TherapyBrandsAutomation.DriverManagement.Manager;

namespace TherapyBrandsAutomation.WaitUtils
{
    public class WaitDefinition
    {
        public WaitDefinition()
        {
        }

        public DefaultWait<IWebDriver> SetWait(int timeoutSeconds = 30, int pollingMills = 250, params Type[] exceptionTypes)
        {
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(DriverManager.GetDriver());
            fluentWait.Timeout = TimeSpan.FromSeconds(timeoutSeconds);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(pollingMills);
            fluentWait.IgnoreExceptionTypes(exceptionTypes);
            fluentWait.Message = "Element to be searched not found";

            return fluentWait;
        }

        public DefaultWait<IWebDriver> SetWait(int timeoutSeconds = 30, int pollingMills = 250)
        {
            return SetWait(timeoutSeconds, pollingMills, new Type[] { typeof(NoSuchElementException) });
        }
    }
}
