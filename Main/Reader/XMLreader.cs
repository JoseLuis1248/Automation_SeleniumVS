using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Main.Reader
{
    public static class XMLreader
    {
        public static string GetUrlByModule(string module)
        {
            string url = GetDataByPrjFolderXmlAndTag("Main", "Configurations", "URLs", module);
            return url;
        }

        public static string GetExplicitWait()
        {
            string expWait = GetDataByPrjFolderXmlAndTag("Main", "Configurations", "Configuration", "explicitWait");
            return expWait;
        }

        public static string GetImplicitWait()
        {
            string impWait = GetDataByPrjFolderXmlAndTag("Main", "Configurations", "Configuration", "implicitWait");
            return impWait;
        }

        public static string GetBrowser()
        {
            string browser = GetDataByPrjFolderXmlAndTag("Main", "Configurations", "Configuration", "browser");
            return browser;
        }

        public static string GetDataByTag(string tag)
        {
            DirectoryInfo directory = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
            string projectPath = directory.Parent.Parent.FullName;
            string xmlPath = projectPath + @"\Data\Data.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlPath);
            string elem = doc.GetElementsByTagName(tag)[0].InnerXml;

            return elem;
        }

        public static string GetDataByPrjFolderXmlAndTag(string prj, string folder, string xmlName, string tag)
        {
            DirectoryInfo directory = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
            string projectPath = directory.Parent.Parent.Parent.FullName;
            string xmlPath = projectPath + @"\\" + prj + @"\\" + folder + @"\\" + xmlName + ".xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlPath);
            string elem = doc.GetElementsByTagName(tag)[0].InnerXml;

            return elem;
        }
    }
}
