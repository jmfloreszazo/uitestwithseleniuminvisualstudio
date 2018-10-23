using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace uitestwithseleniuminvisualstudio
{
    [TestClass]
    public class WebApp
    {
        [TestMethod]
        public void Shoud_I_Do_Click_In_Increment()
        {
            using (ChromeDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("https://localhost:44330/counter");
                driver.FindElement(By.Id("Increment")).Click();
                driver.Quit();
            }
        }

        [TestMethod]
        public void Shoud_I_Test_If_CurrentCounter_Has_Value()
        {
            int stopValue = 100;
            using (ChromeDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("https://localhost:44330/counter");
                for (int i = 1; i <= stopValue; i++)
                {
                    driver.FindElement(By.Id("Increment")).Click();
                }
                string currentCounter = driver.FindElement(By.Id("CurrentCounter")).Text;
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
                driver.Quit();
                Assert.AreEqual(currentCounter, stopValue.ToString());
            }
        }
    }
}
