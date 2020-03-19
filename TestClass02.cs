/* Test automation using C# & Selenium. Set of examples. Created by Alex L. 
   Login page & Thread.Sleep Method example*/

using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace AlexTest01_Se_Cs
{
    [TestFixture]
    public class TestClass02
    {
        [Test]
        public void TestFirefox()
        {
            IWebDriver driver = new ChromeDriver();
            
            // Opening page
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/login");
            driver.Manage().Window.Maximize();

            // Sending username and password: tomsmith / SuperSecretPassword!
            driver.FindElement(By.Id("username")).SendKeys("tomsmith");
            driver.FindElement(By.CssSelector("input[name=password]")).SendKeys("SuperSecretPassword!");
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();

            // This method suspends the current thread for the specified amount of time.
            Thread.Sleep(5000);
           
            //Closing browser
            driver.Quit();
        }
    }
}
