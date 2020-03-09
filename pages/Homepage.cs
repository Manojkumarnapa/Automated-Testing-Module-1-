using DemoProject.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.Pages
{
    class HomePage
    {
        public void NavigateToTM(IWebDriver driver)
        {
            // click on administration
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();

            //Wait for TM drop down click
            Sync.WaitForClickAction(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 1);

            // click on time and material
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")).Click();
        }
    }
}
