using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.UIFramework.Elements
{
    public interface ISeleniumElement
    {
        /// <summary>
        /// Gets the web element object
        /// </summary>
        IWebElement WebElement { get; }

        string Text { get; }

        bool IsEnabled { get; }

        bool IsVisible { get; }
    }
}
