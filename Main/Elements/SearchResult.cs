using Main.Browsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Elements
{
    public class SearchResult : ElementGroupBase
    {
        public SearchResult(string commonXpath)
        {
            this.webElements = Browser.FindElements(commonXpath);
        }


    }
}
