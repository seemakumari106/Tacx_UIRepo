using OpenQA.Selenium;
using System;

namespace Automation.UIFramework.Operations
{
    public class BrowserOperations
    {
        /// <summary>
        /// Field to hold the <see cref="IWebDriver"/>
        /// </summary>
        private readonly IWebDriver _browser;

        /// <summary>
        /// Gets the current browser Url
        /// </summary>
        public string CurrentUrl => _browser.Url;

        /// <summary>
        /// Gets the browser title
        /// </summary>
        public string BrowserTitle => _browser.Title;

        /// <summary>
        /// Construct <see cref="BrowserOperations"/>
        /// </summary>
        /// <param name="browser"></param>
        public BrowserOperations(IWebDriver browser)
        {
            _browser = browser;
        }

        /// <summary>
        /// Load the given uri in the browser
        /// </summary>
        /// <param name="uri"><see cref="Uri"/> to load</param>
        public void Load(Uri uri)
        {
            _browser.Navigate().GoToUrl(uri);
        }

        /// <summary>
        /// Load the given url in the browser
        /// </summary>
        /// <param name="url">Url to load</param>
        public void Load(string url)
        {
            _browser.Navigate().GoToUrl(url);
        }

        /// <summary>
        /// Navigate using Back button on browser
        /// </summary>
        public void GoToPreviousPage()
        {
            _browser.Navigate().Back();
        }

        /// <summary>
        /// Navigate using Forward button on browser
        /// </summary>
        public void GoToNextPage()
        {
            _browser.Navigate().Forward();
        }

        /// <summary>
        /// Refresh browser
        /// </summary>
        public void RefreshBrowser()
        {
            _browser.Navigate().Refresh();
        }

        /// <summary>
        /// Maximize window
        /// </summary>
        public void Maximize()
        {
            _browser.Manage().Window.Maximize();
        }

        /// <summary>
        /// Minimize window
        /// </summary>
        public void Minimize()
        {
            _browser.Manage().Window.Minimize();
        }

        /// <summary>
        /// Close the browser
        /// </summary>
        public void CloseBrowser()
        {
            _browser.Close();
        }

        /// <summary>
        /// Quit the browser
        /// </summary>
        public void QuitBrowser()
        {
            _browser.Quit();
        }
    }
}
