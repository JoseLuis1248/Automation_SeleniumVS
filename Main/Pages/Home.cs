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
        private static string searchButton = "//body[1]/div[1]/div[3]/form[1]/div[1]/div[1]/div/center[1]/input[1]";
        private static string searchInput = "//body/div[1]/div[3]/form[1]/div[1]/div[1]/div[1]/div[1]/div[2]/input[1]";
        private static string iWillHaveLuckButton = "//body/div[1]/div[3]/form[1]/div[1]/div[1]/div/center[1]/input[2]";

        // Elements
        public static Button SearchButton()
        {
            return new Button(searchButton);
        }

        public static Input SearchInput()
        {
            return new Input(searchInput);
        }

        public static Button IWillHaveLuckButton()
        {
            return new Button(iWillHaveLuckButton);
        }
    }
}
