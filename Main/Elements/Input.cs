using Main.Browsers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Elements
{
    public class Input : ElementBase
    {
        public Input(string xpath)
        {
            webElement = Browser.FindElement(xpath);
        }

        public void SendText(string text)
        {
            this.webElement.SendKeys(text);
        }

        public void PressEnter()
        {
            this.webElement.SendKeys(Keys.Enter);
        }
    }
}
