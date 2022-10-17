using Main.Browsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace TestHome.Steps
{
    [Binding]
    public sealed class Hooks
    {
        

        [BeforeScenario]
        public void BeforeScenario()
        {
            //TODO: implement logic that has to run before executing each scenario
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Browser.CloseBrowser();
        }
    }
}
