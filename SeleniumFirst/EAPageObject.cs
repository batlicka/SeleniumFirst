using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class EAPageObject
    {
        public EAPageObject()
        {
            //inicializace page object v rámci daného i web driveru
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        //deklarace objektů v určité stránce
        [FindsBy(How = How.Id, Using = "TitleID")]
        public IWebElement dropDownID { get; set; }

        [FindsBy(How = How.Name, Using = "Initial")]
        public IWebElement txtInitial { get; set; }

        [FindsBy(How = How.Name, Using = "FirstName")]
        public IWebElement txtFirstName { get; set; }

        [FindsBy(How = How.Name, Using = "FirstName")]
        public IWebElement txtMiddleName { get; set; }


        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement btnSave { get; set; }

        public void FillUserForm(string initial, string middleName, string firstName)
        {
            //použité extension metody
            txtInitial.EnterText(initial);
            txtFirstName.EnterText(firstName);
            txtMiddleName.EnterText(firstName);
            btnSave.Clicks();
            
            
            //použité selenium metody wrapped in user custom methods
            //SelenimumSetMethods.EnterText(txtInitial, initial);
            //SelenimumSetMethods.EnterText(txtFirstName, firstName);
            //SelenimumSetMethods.EnterText(txtMiddleName, middleName);
            //SelenimumSetMethods.Clicks(btnSave);

            //použité přímo selenium metody
            //txtInitial.SendKeys(initial);
            //txtFirstName.SendKeys(firstName);
            //txtMiddleName.SendKeys(middleName);
            //btnSave.Click();
        }
    }
}
