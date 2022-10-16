using Main.Browsers;
using Main.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Pages
{
    public static class Home
    {
        // Xpaths
        private static string searchButtonPath = "//body[1]/div[1]/div[3]/form[1]/div[1]/div[1]/div/center[1]/input[1]";
        
        public static Button SearchButton()
        {
            return new Button(searchButtonPath);
        }

    }
}
