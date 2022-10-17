using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Elements
{
    public class ElementGroupBase
    {
        public IWebElement[] webElements;

        public int GetNumberOfElements()
        {
            return this.webElements.Length;
        }
    }
}