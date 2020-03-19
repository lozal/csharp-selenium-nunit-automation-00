/* Test automation using C# & Selenium. Set of examples. Created by Alex L. 
   Assert example*/

using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AlexTest01_Se_Cs
{
    [TestFixture]
    public class TestClass03
    {
        [Test]
        public void TestTitleAssert()
        {
            IWebDriver driver = new ChromeDriver();

            // Opening page
            driver.Url = "http://www.google.com";
            string myTitle = driver.Title;

            // Checking if the title is matching
            Assert.AreEqual(myTitle, "Google", "Title is not matching");

            // Printing Title name on Console
            Console.WriteLine("The Title is " + myTitle);
            
            //Closing browser
            driver.Quit();
        }
    }
}
