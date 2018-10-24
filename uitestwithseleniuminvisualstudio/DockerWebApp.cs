using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace uitestwithseleniuminvisualstudio
{
    [TestClass]
    public class DockerWebApp
    {
        [TestMethod]
        public void Shoud_I_Do_Click_In_CounterButton()
        {
            using (ChromeDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("http://localhost:8000");
                driver.FindElement(By.Id("buttonCounter")).Click();
                driver.Quit();
            }
        }

        [TestMethod]
        public void Shoud_I_Test_If_Counter_Has_Value()
        {
            int stopValue = 100;
            using (ChromeDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("http://localhost:8000");
                for (int i = 1; i <= stopValue; i++)
                {
                    driver.FindElement(By.Id("buttonCounter")).Click();
                }
                string currentCounter = driver.FindElement(By.Id("textCounter")).GetAttribute("value");
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
                driver.Quit();
                Assert.AreEqual(currentCounter, stopValue.ToString());
            }
        }
    }
}
