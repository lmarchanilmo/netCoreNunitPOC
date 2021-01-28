using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace TherapyBrandsAutomation.DriverManagement.Builder
{
    public class ChromeRemoteDriverBuilder : RemoteDriverBuilder<ICapabilities>
    {
        public ChromeRemoteDriverBuilder(string remoteHost)
        {
            RemoteHost = remoteHost;
        }

        public override ICapabilities LoadCapabilities()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.cookies", 2);
            chromeOptions.AddUserProfilePreference("profile.block_third_party_cookies", true);
            return chromeOptions.ToCapabilities();
        }
    }
}
