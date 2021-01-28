using System;
using NUnit.Allure.Core;
using NUnit.Framework;
using TherapyBrandsModule.Pages.Widgets;

namespace TherapyBrandsModule.Tests.Section
{
    [TestFixture]
    [AllureNUnit]
    [Parallelizable]
    public class FirstSuite : BaseTest
    {
        [Test]
        [Parallelizable(ParallelScope.Self)]
        public void Test1()
        {
            TopMenu topMenu = new TopMenu();
            topMenu.AccessMenu(MenuOption.OUR_SERVICES);
        }

        [Test]
        [Parallelizable(ParallelScope.Self)]
        public void Test2()
        {
            TopMenu topMenu = new TopMenu();
            topMenu.AccessMenu(MenuOption.ABOUT);
        }
    }
}
