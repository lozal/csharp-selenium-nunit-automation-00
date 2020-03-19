/* Test automation using C# & Selenium. Set of examples. Created by Alex L. 
   Getting Page’s Title example*/

using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace AlexTest01_Se_Cs
{
    [TestFixture]
    public class TestClass01
    {
        [Test]
        public void TestTitleChrome()
        {
            // Using Chrome browser
            IWebDriver driver = new ChromeDriver();

            // Opening page
            driver.Url= "http://www.google.com";
            string myTitle = driver.Title;
            string myUrl = driver.Url;
            
            // Printing Title name and URL on Console
            Console.WriteLine("The Title is " + myTitle);
            Console.WriteLine("URL: " + myUrl);

            //Closing browser
            driver.Quit();
        }

        [Test]
        public void TestTitleFF()
        {
            // Using Firefox browser
            IWebDriver driver = new FirefoxDriver();

            // Opening page
            driver.Url = "http://www.google.com";
            string myTitle = driver.Title;
            string myUrl = driver.Url;

            // Printing Title name and URL on Console
            Console.WriteLine("The Title is " + myTitle);
            Console.WriteLine("URL: " + myUrl);

            //Closing browser
            driver.Quit();
        }
    }
}
