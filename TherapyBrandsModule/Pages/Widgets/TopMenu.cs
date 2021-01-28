using System;
using Allure.Commons;
using NUnit.Allure.Core;
using NUnit.Allure.Steps;
using OpenQA.Selenium;
using TherapyBrandsAutomation.CustomActions;

namespace TherapyBrandsModule.Pages.Widgets
{
    [AllureNUnit]
    public class TopMenu : BasePage
    {
        private readonly By ourServices = By.LinkText("Our Services");
        private readonly By about = By.LinkText("About");

        public TopMenu()
        {
        }

        [AllureStep("Accessing Menu {0}")]
        public TopMenu AccessMenu(MenuOption menuOption)
        {
            switch (menuOption)
            {
                case MenuOption.OUR_SERVICES:
                    Common.ClickUsingJavaScript(ourServices);
                    break;
                case MenuOption.ABOUT:
                    Common.ClickUsingJavaScript(about);
                    break;
            }
            
            return this;
        }
    }

    public enum MenuOption
    {
        OUR_SERVICES,
        ABOUT
    }
}
