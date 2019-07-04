using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class LoginPageObject
    {
        public LoginPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }
        //deklarace objektů v určité stránce
        [FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement btnLogin { get; set; }

        public EAPageObject Login(string userName, string password)
        {
            //použité přímo selenium metody
            txtUserName.SendKeys(userName);
            //pass
            txtPassword.SendKeys(password);
            //click button
            btnLogin.Submit();

            //použité extension methods
            ////user name
            //txtUserName.EnterText(userName);
            ////pass
            //txtPassword.EnterText(password);
            ////click
            //btnLogin.Clicks();

            return new EAPageObject();
        }
    }
}
