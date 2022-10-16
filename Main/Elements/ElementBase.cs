using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Elements
{
    public abstract class ElementBase
    {
        public IWebElement webElement;

        public Boolean IsEnabled()
        {
            return this.webElement.Enabled;
        }
    }
}
