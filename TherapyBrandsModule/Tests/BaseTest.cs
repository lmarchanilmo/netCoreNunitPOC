using System;
using Allure.Commons;
using NUnit.Framework;
using OpenQA.Selenium;
using TherapyBrandsAutomation.Config;
using TherapyBrandsAutomation.DriverManagement.Manager;
using TherapyBrandsModule.ConfigPOCO;

[assembly: LevelOfParallelism(2)]
namespace TherapyBrandsModule.Tests
{
    [TestFixture]
    
    public class BaseTest
    {
        public ConnectionStrings ConnectionStrings { get; set; }
        public Exec Exec { get; set; }
        public IWebDriver driver;

        [OneTimeSetUp]
        public void Init()
        {
            AllureLifecycle.Instance.CleanupResultDirectory();
            ConnectionStrings = ConfigHandler.GetApplicationConfiguration<ConnectionStrings>(TestContext.CurrentContext.TestDirectory, "ConnectionStrings");
            Exec = ConfigHandler.GetApplicationConfiguration<Exec>(TestContext.CurrentContext.TestDirectory, "Exec");
        }

        [SetUp]
        public void BeforeMethod()
        {
            DriverManager.SetDriver(Exec.RemoteHost, Exec.Remote, Exec.Browser, Exec.LocalPartialPath);
            driver = DriverManager.GetDriver();
            driver.Navigate().GoToUrl(Exec.Url);
        }

        [TearDown]
        public void AfterMethod()
        {
            //DriverManager.KillDriver();
        }
    }
}
