using Main.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Pages
{
    public static class SearchResults
    {
        // Xpaths
        private static string searchResult = "//div[@id='rso']/div";

        // Elements
        public static SearchResult SearchResult()
        {
            return new SearchResult(searchResult);
        }
    }
}
