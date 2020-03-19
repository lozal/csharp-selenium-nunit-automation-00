/* Test automation using C# & Selenium. Set of examples. Created by Alex L. 
   Explicit Wait example*/

using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace AlexTest01_Se_Cs
{
    [TestFixture]
    public class TestClass05
    {
        [Test]
        public void TestExpWait()
        {
            IWebDriver driver = new ChromeDriver();

            // Opening page
            driver.Url = "http://the-internet.herokuapp.com/dynamic_loading/2";
            Console.WriteLine("Page opened!");

            // Clicking start button
            driver.FindElement(By.XPath("//button[contains(text(),'Start')]")).Click();

            // Waiting for Hello World! text
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//h4[contains(text(),'Hello World!')]")));

            //Finding for Hello World! element
            IWebElement element = driver.FindElement(By.XPath("//h4[contains(text(),'Hello World!')]"));

            // Checking if the element is displayed
            Assert.IsTrue(element.Displayed);
            Assert.IsTrue(driver.PageSource.Contains("Hello World!"), "Hello World! text is not present on the page.");
            Console.WriteLine("Element found!");
            Console.WriteLine("Test complete");

            //Closing browser
            driver.Quit();
        }
    }
}
