/* Test automation using C# & Selenium. Set of examples. Created by Alex L. 
   SetUp - TearDown example*/

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AlexTest01_Se_Cs
{
    public class BaseClass01
    {
        public IWebDriver driver;

        [OneTimeSetUp]
        public void TestInit()
        {
            // Runs before tests.
            // Using Chrome browser
            driver = new ChromeDriver();

            // Opening page
            driver.Url = "http://www.google.com";
        }

        [OneTimeTearDown]
        public void TestCleanup()
        {
            // Runs after tests.
            //Closing browser
            driver.Quit();
        }
    }
}
