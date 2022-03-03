using Automation.UIFramework.Operations;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.UIFramework.Browser
{
    public interface IBrowser
    {
        /// <summary>
        /// Gets the web driver for the browser
        /// </summary>
        IWebDriver Browser { get; }

        /// <summary>
        /// Gets the <see cref="Operations.BrowserOperations"/> object
        /// </summary>
        BrowserOperations BrowserOperations { get; }
    }
}
