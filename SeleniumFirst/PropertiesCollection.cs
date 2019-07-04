
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    //abychom nemuseli mít "nahardcoděné" typy v metodách, je lepší použít výčtový typ
    enum PropertyType
    {
        Id,
        Name,
        LinkText,
        CssName,
        ClassName
    }


    class PropertiesCollection
    {
               //auto implemented property
        public static IWebDriver driver { get; set; }
    }
}
