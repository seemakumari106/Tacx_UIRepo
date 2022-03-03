using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.UIFramework.Elements
{
    public class SeleniumElement : ISeleniumElement
    {
        /// <summary>
        /// Gets the <see cref="IWebElement"/> object
        /// </summary>
        public IWebElement TypedElement { get; }

        /// <summary>
        /// Gets the web element
        /// </summary>
        public IWebElement WebElement => TypedElement;

        public SeleniumElement(IWebElement element)
        {
            TypedElement = element;
        }

        public string Text => TypedElement.Text;

        public bool IsEnabled => TypedElement.Enabled;

        public bool IsVisible => TypedElement.Displayed;
    }
}
