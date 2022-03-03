using API.Interfaces.Tacx;
using API.Interfaces.Tacx.Home;
using API.Tacx.Home;
using Automation.UIFramework.Browser;
using Automation.UIFramework.Elements;
using Automation.UIFramework.Factory;
using Automation.UIFramework.Finders;
using Automation.UIFramework.Operations;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IBrowserFactory browserFactory = new BrowserFactory();
            BrowserOperations _browserOperations;

            browserFactory.StartBrowser();
            var browser = browserFactory.GetBrowser().Browser;
            _browserOperations = new BrowserOperations(browser);
            _browserOperations.Load("http://cloud.tacx.com/");
            _browserOperations.Maximize();

            IHomePage homePage = new HomePageOperations();

            homePage.SignIn();
        }
    }
}
