using Newtonsoft.Json;
using System.IO;

namespace SPG_Automation.Utilities.Helpers
{
    public class ReadJSON
    {
        public static string PageUrlsFileName = "PageUrls.json";
        public static string ElementSelctorsFileName = "ElementSelectors.json";


        public static string ReadPageURLs(string pageName)
        {
            dynamic jsonFile = JsonConvert.DeserializeObject(File.ReadAllText(PageUrlsFileName));
            return jsonFile[pageName];
        }

        public static string ReadPageElementSelectors(string cssSelector)
        {
            dynamic jsonFile = JsonConvert.DeserializeObject(File.ReadAllText(ElementSelctorsFileName));
            return jsonFile[cssSelector];
        }
    }
}
