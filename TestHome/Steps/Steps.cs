using Main.Browsers;
using Main.Pages;
using Main.Reader;
using Main.Static;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace TestHome.Steps
{
    [Binding]
    public sealed class Steps
    {
        #region GIVEN SECTION

        [Given(@"Open ""(.*)"" page")]
        public void GivenOpenPage(string pageName)
        {
            Browser.Initialize();
            string url = XMLreader.GetUrlByModule(pageName.ToLower());
            Browser.GoToPage(url);
        }

        #endregion

        #region WHEN SECTION

        [When(@"User clicks on ""(.*)""")]
        public void WhenUserClicksOn(string buttonName)
        {
            switch(buttonName)
            {
                case "Buscar con Google":
                    Home.SearchButton().Click();
                    break;
            }
        }

        #endregion

        #region THEN SECTION

        [Then(@"Page shows url ""(.*)""")]
        public void ThenPageShowsUrl(string pageName)
        {
            string actualUrl = Browser.driver.Url;
            string expectedUrl = XMLreader.GetUrlByModule(pageName.ToLower());

            Assert.AreEqual(expectedUrl, actualUrl);
        }

        #endregion
    }
}
