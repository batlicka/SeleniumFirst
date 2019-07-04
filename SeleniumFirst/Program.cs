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

        [SetUp] //tato metoda je zavolána okamžite, poté co zvlolíme runtes
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver();
            PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
            Console.WriteLine("opened url");
        }

        [Test]
        public void ExecuteTest()
        {
            ExcelLib.PopulateInCollection(@"c:\Users\vagunda\Documents\testDataDrivenSelen.xlsx");

            //login to application
            LoginPageObject pageLogin = new LoginPageObject();

            //inputs bez excell file
            EAPageObject pageEA = pageLogin.Login("execute", "automation");
            pageEA.FillUserForm("KK", "Kartik", "Automation");

            //inputs from excel file
            //EAPageObject pageEA = pageLogin.Login(ExcelLib.ReadData(1, "UserName"), ExcelLib.ReadData(1, "Password"));
            //pageEA.FillUserForm(ExcelLib.ReadData(1, "Initial"), ExcelLib.ReadData(1, "MiddleName"), ExcelLib.ReadData(1, "FirstName"));

            //Initialize page
            //EAPageObject pageEA = new EAPageObject();

        }

        [Test]
        public void NextTest()
        {
            Console.Write("next method");
        }

        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Close();
            Console.WriteLine("close test");
        }
    }
}
//Data Driven Testing with excel  - download "ExcelDataReader"
//http://executeautomation.com/blog/?s=LINQ