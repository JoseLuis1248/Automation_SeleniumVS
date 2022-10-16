using Main.Browsers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Elements
{
    public class Button : ElementBase
    {
        public Button(string xpath)
        {
            webElement = Browser.FindElement(xpath);
        }

        public void Click()
        {
            this.webElement.Click();
        }

    }
}
