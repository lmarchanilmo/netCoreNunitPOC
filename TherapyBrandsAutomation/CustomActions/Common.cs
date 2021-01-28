using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using TherapyBrandsAutomation.DriverManagement.Manager;
using TherapyBrandsAutomation.WaitUtils;

namespace TherapyBrandsAutomation.CustomActions
{
    public class Common
    {
        public Common()
        {
        }

        public static void SendText(By by, string value)
        {
            IWebElement searchResult = new WaitDefinition().SetWait().Until(x => x.FindElement(by));
            searchResult.SendKeys(value);
        }

        public static void ClickElement(By by)
        {
            IWebElement searchResult = new WaitDefinition().SetWait().Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(by));
            searchResult.Click();
        }

       
        public static void MouseOver(By by)
        {
            IWebElement searchResult = new WaitDefinition().SetWait().Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(by));
            Actions action = new Actions(DriverManager.GetDriver());
            action.MoveToElement(searchResult).Perform();
        }

        public static void ClickUsingJavaScript(By by)
        {
            IWebElement searchResult = new WaitDefinition().SetWait().Until(x => x.FindElement(by)); IJavaScriptExecutor executor = (IJavaScriptExecutor)DriverManager.GetDriver();
            executor.ExecuteScript("arguments[0].click();", searchResult);
        }
    }
}
