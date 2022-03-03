using Automation.UIFramework.Elements;
using Automation.UIFramework.Factory;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Protractor;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.UIFramework.Finders
{
    public class SeleniumElementIdentifier
    {
        /// <summary>
        /// Field to hold the _WebBrowser object
        /// </summary>
        private readonly IWebDriver _browser;
        /// <summary>
        /// Field to hold the ng browser driver
        /// </summary>
        private readonly IWebDriver _ngBrowser;

        private readonly DefaultWait<IWebDriver> _fluentWait;        

        /// <summary>
        /// Construct <see cref="SeleniumElementIdentifier"/>
        /// </summary>
        public SeleniumElementIdentifier()
        {
            _browser = new BrowserFactory().GetBrowser().Browser;
            _ngBrowser = new BrowserFactory().GetNgBrowser().Browser;

            _fluentWait = new DefaultWait<IWebDriver>(_browser);
            _fluentWait.Timeout = TimeSpan.FromSeconds(60);
            _fluentWait.PollingInterval = TimeSpan.FromMilliseconds(250);
            _fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            _fluentWait.Message = "Element to be searched not found";
        }

        /// <summary>
        /// Sets the name
        /// </summary>
        /// <param name="name">Element name</param>
        /// <returns><see cref="SeleniumElementIdentifier"/></returns>
        public ISeleniumElement Name(string name)
        {
            return new SeleniumElement(_fluentWait.Until(driver=>driver.FindElement(By.Name(name))));
        }

        /// <summary>
        /// Sets the Id
        /// </summary>
        /// <param name="id">Element name</param>
        /// <returns><see cref="SeleniumElementIdentifier"/></returns>
        public ISeleniumElement Id(string id)
        {
            return new SeleniumElement(_fluentWait.Until(driver => driver.FindElement(By.Id(id))));
        }

        /// <summary>
        /// Sets the class name
        /// </summary>
        /// <param name="className">Element class name</param>
        /// <returns><see cref="SeleniumElementIdentifier"/></returns>
        public ISeleniumElement ClassName(string className)
        {
            return new SeleniumElement(_fluentWait.Until(driver => driver.FindElement(By.ClassName(className))));
        }

        /// <summary>
        /// Sets the tag name
        /// </summary>
        /// <param name="tagName">Element name</param>
        /// <returns><see cref="SeleniumElementIdentifier"/></returns>
        public ISeleniumElement TagName(string tagName)
        {
            return new SeleniumElement(_fluentWait.Until(driver => driver.FindElement(By.TagName(tagName))));
        }

        /// <summary>
        /// Sets the link text
        /// </summary>
        /// <param name="linkText">Link text</param>
        /// <returns><see cref="SeleniumElementIdentifier"/></returns>
        public ISeleniumElement LinkText(string linkText)
        {
            return new SeleniumElement(_fluentWait.Until(driver => driver.FindElement(By.LinkText(linkText))));
        }

        /// <summary>
        /// Sets the partial link text
        /// </summary>
        /// <param name="partialLinkText">Partial link text value</param>
        /// <returns><see cref="SeleniumElementIdentifier"/></returns>
        public ISeleniumElement PartialLinkText(string partialLinkText)
        {
            return new SeleniumElement(_fluentWait.Until(driver => driver.FindElement(By.PartialLinkText(partialLinkText))));
        }

        /// <summary>
        /// Sets the xpath locator
        /// </summary>
        /// <param name="xpath">Element xpath</param>
        /// <returns><see cref="SeleniumElementIdentifier"/></returns>
        public ISeleniumElement XPath(string xpath)
        {
            return new SeleniumElement(_fluentWait.Until(driver => driver.FindElement(By.XPath(xpath))));
        }

        /// <summary>
        /// Sets the css locator
        /// </summary>
        /// <param name="cssSelector">Css value</param>
        /// <returns><see cref="SeleniumElementIdentifier"/></returns>
        public ISeleniumElement CssSelector(string cssSelector)
        {
            return new SeleniumElement(_fluentWait.Until(driver => driver.FindElement(By.CssSelector(cssSelector))));
        }

        /// <summary>
        /// Sets the binding locator
        /// </summary>
        /// <param name="binding">Binding value</param>
        /// <returns><see cref="SeleniumElementIdentifier"/></returns>
        public ISeleniumElement Binding(string binding)
        {
            return new SeleniumElement(_fluentWait.Until(driver => driver.FindElement(NgBy.Binding(binding))));
        }

        /// <summary>
        /// Sets the exact binding locator
        /// </summary>
        /// <param name="exactBinding">Exact binding value</param>
        /// <returns><see cref="SeleniumElementIdentifier"/></returns>
        public ISeleniumElement ExactBinding(string exactBinding)
        {
            return new SeleniumElement(_fluentWait.Until(driver => driver.FindElement(NgBy.ExactBinding(exactBinding))));
        }

        /// <summary>
        /// Sets the model locator
        /// </summary>
        /// <param name="model">Model value</param>
        /// <returns><see cref="SeleniumElementIdentifier"/></returns>
        public ISeleniumElement Model(string model)
        {
            return new SeleniumElement(_fluentWait.Until(driver => driver.FindElement(NgBy.Model(model))));

        }

        /// <summary>
        /// Sets the selected option locator
        /// </summary>
        /// <param name="selectedOption">Selected option value</param>
        /// <returns><see cref="SeleniumElementIdentifier"/></returns>
        public ISeleniumElement SelectedOption(string selectedOption)
        {
            return new SeleniumElement(_fluentWait.Until(driver => driver.FindElement(NgBy.SelectedOption(selectedOption))));
        }

        /// <summary>
        /// Sets the repeater locator
        /// </summary>
        /// <param name="repeater">Repeater value</param>
        /// <returns><see cref="SeleniumElementIdentifier"/></returns>
        public ISeleniumElement Repeater(string repeater)
        {
            return new SeleniumElement(_fluentWait.Until(driver => driver.FindElement(NgBy.Repeater(repeater))));
        }

        /// <summary>
        /// Sets the exact repeater locator
        /// </summary>
        /// <param name="exactRepeater">Exact repeater value</param>
        /// <returns><see cref="SeleniumElementIdentifier"/></returns>
        public ISeleniumElement ExactRepeater(string exactRepeater)
        {
            return new SeleniumElement(_fluentWait.Until(driver => driver.FindElement(NgBy.ExactRepeater(exactRepeater))));
        }
    }
}
