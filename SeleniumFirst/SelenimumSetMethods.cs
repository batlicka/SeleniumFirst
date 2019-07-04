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
    public static class SelenimumSetMethods
    {
        //zde budou definovány všechny akce, které chceme provádět na stránce

        //Enter text                 
        //this -> makes extended method for entering text in the control
        public static void EnterText( this IWebElement element, string value )
        {
            element.SendKeys(value);
        }

        //click into a button, chceckbox
        public static void Clicks(this IWebElement element)
        {
            element.Click();
        }

        //selecting drop down control
        public static void SelectDropDown(this IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);
        }
    }
}
