using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class Program
    {

        IWebDriver driver = new ChromeDriver();
        static void Main(string[] args)
        {
            //IWebDriver driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("http://www.google.com");
            //Console.WriteLine("opened URL");

            ////find element
            //IWebElement element = driver.FindElement(By.Name("q"));

            //element.SendKeys("executeautomation");
            //Console.WriteLine("executeautomation");
        }

        [SetUp] //tato metoda je zavolána okamžite, poté co zvlolíme runtest
        public void Initialize()
        {
            driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=a&Password=a&Login=Login ");
            Console.WriteLine("opened url");
        }

        [Test]
        public void ExecuteTest()
        {
            //Title
            SelenimumSetMethods.SelectDropDown(driver, "TitleId", "Mr.", "Id");

            //Initial
            SelenimumSetMethods.EnterText(driver, "Initial", "executeautomation", "Id");

            Console.WriteLine("the value from my title is:" + SeleniumGetMethod.GetTextFromDropDown(driver, "TitleId", "Id"));

            Console.WriteLine("the value from my title is:" + SeleniumGetMethod.GetText(driver, "Initial", "Name"));
            //Click
            SelenimumSetMethods.Click(driver, "Save", "Name");
        }

        [Test]
        public void NextTest()
        {
            Console.Write("next method");
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
            Console.WriteLine("close test");
        }
    }
}
