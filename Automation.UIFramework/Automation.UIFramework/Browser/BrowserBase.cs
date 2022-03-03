using Automation.UIFramework.Operations;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.UIFramework.Browser
{
    public abstract class BrowserBase
    {
        private BrowserOperations _browserOperations;

        /// <summary>
        /// Protected constructor
        /// </summary>
        protected BrowserBase()
        {
        }

        /// <summary>
        /// Gets the browse object
        /// </summary>
        public abstract IWebDriver Browser { get; }

        /// <summary>
        /// Gets the <see cref="Operations.BrowserOperations"/> object
        /// </summary>
        public BrowserOperations BrowserOperations => _browserOperations ?? (_browserOperations = new BrowserOperations(Browser));
    }
}
