using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace SeleniumFirst
{
    //custom methods
    class SelenimumSetMethods
    {
        //zde budou definovány všechny akce, které chceme provádět na stránce

        //Enter text                 // instance web drv, identifikator, zadavana hodnota, typ prvku name/id       
        public static void EnterText(IWebDriver driver, string element, string value, string elementtype)
        {
            if(elementtype== "Id")
                driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementtype == "Name")           
                driver.FindElement(By.Name(element)).SendKeys(value);
        }

        //click into a button, chceckbox
        public static void Click(IWebDriver driver, string element, string elementtype)
        {
            if (elementtype == "Id")
                driver.FindElement(By.Id(element)).Click();
            if(elementtype == "Name")
                driver.FindElement(By.Name(element)).Click();
        }

        //selecting drop down control
        public static void SelectDropDown(IWebDriver driver, string element, string value, string elementtype)
        {
            if (elementtype == "Id")
                new SelectElement(driver.FindElement(By.Id(element))).SelectByText(value);
            if (elementtype == "Name")
                new SelectElement(driver.FindElement(By.Name(element))).SelectByText(value);
        }
    }
}
