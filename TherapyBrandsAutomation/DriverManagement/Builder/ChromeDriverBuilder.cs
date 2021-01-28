using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TherapyBrandsAutomation.DriverManagement.Builder
{
    public class ChromeDriverBuilder : DriverBuilder<ChromeOptions>
    {
        private string LocalPartialPath { get; set; }

        public ChromeDriverBuilder(string localPartialPath)
        {
            LocalPartialPath = localPartialPath;
        }

        public override IWebDriver Build()
        {
            return new ChromeDriver(@TestContext.CurrentContext.TestDirectory + LocalPartialPath, LoadCapabilities());
        }

        public override ChromeOptions LoadCapabilities()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.cookies", 2);
            chromeOptions.AddUserProfilePreference("profile.block_third_party_cookies", true);
            return chromeOptions;
        }
    }
}
