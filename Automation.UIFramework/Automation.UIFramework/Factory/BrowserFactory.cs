using Automation.UIFramework.Browser;
using Unity;
using Unity.Lifetime;

namespace Automation.UIFramework.Factory
{
    public class BrowserFactory : IBrowserFactory
    {
        /// <summary>
        /// Gets the default browser name
        /// </summary
        private static readonly string DefaultBrowserName = "chrome";

        /// <summary>
        /// Field to hold the container object
        /// </summary>
        private static readonly IUnityContainer BrowserContainer;

        /// <summary>
        /// Field to hold the <see cref="IBrowser"/> for selenium
        /// </summary>
        private static IBrowser _browser;

        /// <summary>
        /// Field to hold the <see cref="IBrowser"/> for Angular js
        /// </summary>
        private static IBrowser _ngBrowser;

        /// <summary>
        /// Static constructor
        /// </summary>
        static BrowserFactory()
        {
            BrowserContainer = new UnityContainer();
            BrowserContainer.RegisterType<IBrowser, ChromeBrowser>("chrome", new ContainerControlledLifetimeManager());
            BrowserContainer.RegisterType<IBrowser, FirefoxBrowser>("firefox", new ContainerControlledLifetimeManager());
        }

        /// <summary>
        /// Start Browser
        /// </summary>
        public void StartBrowser()
        {
            StartBrowser(DefaultBrowserName);
        }

        /// <summary>
        /// Start Browser
        /// </summary>
        /// <param name="browserName">Browser to start</param>
        public void StartBrowser(string browserName)
        {
            _browser = GetBrowser(browserName);
            _ngBrowser = new NgBrowser(_browser);
        }

        /// <summary>
        /// Stop Browser
        /// </summary>
        public void StopBrowser()
        {
            _browser.Browser.Quit();
        }

        /// <summary>
        /// Gets the default <see cref="IBrowser"/> object
        /// </summary>
        /// <returns><see cref="IBrowser"/></returns>
        public IBrowser GetBrowser()
        {
            return _browser;
        }

        /// <summary>
        /// Get <see cref="NgBrowser"/> object
        /// </summary>
        /// <returns><see cref="IBrowser"/> for <see cref="NgBrowser"/></returns>
        public IBrowser GetNgBrowser()
        {
            return _ngBrowser;
        }

        /// <summary>
        /// Gets the browse identified by given name
        /// </summary>
        /// <param name="name">Browse same</param>
        /// <returns><see cref="IBrowser"/></returns>
        public IBrowser GetBrowser(string name)
        {
            return BrowserContainer.Resolve<IBrowser>(name);
        }

    }
}
