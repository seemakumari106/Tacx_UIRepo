using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Automation.UIFramework.Browser
{
    public class ChromeBrowser : BrowserBase, IBrowser
    {
        /// <summary>
        /// Gets the browse object
        /// </summary>
        public override IWebDriver Browser { get; }

        /// <summary>
        /// Construct <see cref="ChromeBrowser"/>
        /// </summary>
        public ChromeBrowser()
        {
            Browser = new ChromeDriver();
        }
    }
}
