using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.UIFramework.Browser
{
    public class FirefoxBrowser : BrowserBase, IBrowser
    {
        /// <summary>
        /// Gets the browse object
        /// </summary>
        public override IWebDriver Browser { get; }

        /// <summary>
        /// Construct <see cref="FirefoxBrowser"/>
        /// </summary>
        public FirefoxBrowser()
        {
            Browser = new FirefoxDriver();
        }
    }
}
