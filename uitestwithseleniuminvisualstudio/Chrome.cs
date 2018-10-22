using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace uitestwithseleniuminvisualstudio
{
    [TestClass]
    public class Chrome
    {
        [TestMethod]
        public void Shoud_Search()
        {
            using (ChromeDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("https://www.google.com/");
                driver.FindElement(By.Id("lst-ib")).Clear();
                driver.FindElement(By.Id("lst-ib")).SendKeys("Hello World! Sample");
                driver.FindElement(By.Id("lst-ib")).SendKeys(OpenQA.Selenium.Keys.Enter);
                driver.Quit();
            }
        }
    }
}
