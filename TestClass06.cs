/* Test automation using C# & Selenium. Set of examples. Created by Alex L. 
   SetUp - TearDown example*/

using System;
using NUnit.Framework;

namespace AlexTest01_Se_Cs
{
    [TestFixture]
    public class TestClass06 : BaseClass01 
    {
        [Test]
        public void TestTitle()
        {
            string myTitle = driver.Title;
            // Printing Title name on Console
            Console.WriteLine("The Title is " + myTitle);
        }
        [Test]
        public void TestUrl()
        {
            string myUrl = driver.Url;
            // Printing URL on Console
            Console.WriteLine("URL: " + myUrl);
        }
    }
}
