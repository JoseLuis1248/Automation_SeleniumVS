using Main.Browsers;
using Main.Pages;
using Main.Reader;
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

        [Given(@"Open ""(.*)"" page with browser ""(.*)""")]
        public void GivenOpenPageWithBrowser(string pageName, string browser)
        {
            string url = XMLreader.GetUrlByModule(pageName.ToLower());
            Browser.InitializeManually(browser);
            Browser.GoToPage(url);
        }


        #endregion

        #region WHEN SECTION

        [When(@"User writes a ""(.*)"" on search input")]
        public void WhenUserWritesAOnSearchInput(string textType)
        {
            string textToType = "";
            switch(textType)
            {
                case "Simple Text":
                    textToType = XMLreader.GetDataByTag("simpleText");
                    break;
            }
            Home.SearchInput().SendText(textToType);
        }


        [When(@"User clicks on ""(.*)""")]
        public void WhenUserClicksOn(string buttonName)
        {
            switch(buttonName)
            {
                case "Buscar con Google":
                    Home.SearchButton().Click();
                    break;
                case "Voy a tener suerte":
                    Home.IWillHaveLuckButton().Click();
                    break;
            }
        }

        [When(@"User press ""(.*)"" key on search input")]
        public void WhenUserPressKeyOnSearchInput(string key)
        {
            switch(key)
            {
                case "Enter":
                    Home.SearchInput().PressEnter();
                    break;
            }
        }

        #endregion

        #region THEN SECTION

        [Then(@"Page shows url ""(.*)""")]
        public void ThenPageShowsUrl(string pageName)
        {
            string actualUrl = Browser.driver.Url;
            string expectedUrl = "";
            switch(pageName)
            {
                case "Home":
                    expectedUrl = XMLreader.GetUrlByModule("home");
                    break;
                case "Doodles":
                    expectedUrl = XMLreader.GetUrlByModule("doodles");
                    break;
            }

            Assert.AreEqual(expectedUrl, actualUrl);
        }

        [Then(@"Page shows at least ""(.*)"" results")]
        public void ThenPageShowsAtLeastResults(int result)
        {
            int actualResults = SearchResults.SearchResult().GetNumberOfElements();
            int expectedResults = result;

            Assert.Greater(actualResults, expectedResults);
        }


        #endregion
    }
}
