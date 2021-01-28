using System;
using System.Threading;
using OpenQA.Selenium;
using TherapyBrandsAutomation.DriverManagement.Factory;

namespace TherapyBrandsAutomation.DriverManagement.Manager
{
    public class DriverManager
    {
        private static DriverFactory DriverFactory { get; set; }

        public static ThreadLocal<IWebDriver> threadLocal = new ThreadLocal<IWebDriver>();

        public DriverManager()
        {
        }

        public static void SetDriver(string remoteHost, bool remote, BrowserType browser, string localPartialPath)
        {
            DriverFactory = new DriverFactory
            {
                RemoteHost = remoteHost,
                Remote = remote,
                Browser = browser,
                LocalPartialPath = localPartialPath
            };
            IWebDriver driver = DriverFactory.NewInstance();
            threadLocal.Value = driver;
        }

        public static IWebDriver GetDriver()
        {
            return threadLocal.Value;
        }

        public static void KillDriver()
        {
            threadLocal.Value.Quit();
            threadLocal.Dispose();
        }
    }
}
