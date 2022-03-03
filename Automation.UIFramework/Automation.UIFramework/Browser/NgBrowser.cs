using OpenQA.Selenium;
using Protractor;

namespace Automation.UIFramework.Browser
{
    public class NgBrowser : BrowserBase, IBrowser
    {
        /// <summary>
        /// Gets the <see cref="IWebDriver"/> for browser
        /// </summary>
        public override IWebDriver Browser { get; }

        /// <summary>
        /// Construct <see cref="NgBrowser"/>
        /// </summary>
        /// <param name="browser"><see cref="IBrowser"/> object</param>
        public NgBrowser(IBrowser browser)
        {
            Browser = new NgWebDriver(browser.Browser);
        }
    }
}
