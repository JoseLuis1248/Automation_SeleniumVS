using Main.Reader;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Browsers
{
    public static class Browser
    {
        public static IWebDriver driver;
        public static double implicitWait = Convert.ToDouble(XMLreader.GetImplicitWait());
        public static double explicitWait = Convert.ToDouble(XMLreader.GetExplicitWait());

        public static void Initialize()
        {            
            switch (XMLreader.GetBrowser())
            {
                case "Chrome":
                    driver = new ChromeDriver();
                    break;
                case "Firefox":
                    driver = new FirefoxDriver();
                    break;
                case "Edge":
                    driver = new EdgeDriver();
                    break;
            }
            
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(implicitWait);
        }

        public static void GoToPage(string page)
        {
            driver.Navigate().GoToUrl(page);
        }

        public static IWebElement FindElement(string path)
        {
            if (explicitWait > 0)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(explicitWait));
                return wait.Until(drv => drv.FindElement(By.XPath(path)));

            }
            return driver.FindElement(By.XPath(path));
        }

        public static void CloseBrowser()
        {
            driver.Close();
        }
    }
}
