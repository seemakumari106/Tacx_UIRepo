using Automation.UIFramework.Elements;
using Automation.UIFramework.Factory;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.UIFramework.Operations
{
    public class ElementOperations
    {
        /// <summary>
        /// Field to hold the <see cref="IWebDriver"/>
        /// </summary>
        private readonly IWebDriver _browser;

        /// <summary>
        /// Field to hold the actions object
        /// </summary>
        private Actions _actions;

        /// <summary>
        /// Construct <see cref="ElementOperations"/>
        /// </summary>
        /// <param name="browser"><see cref="IWebDriver"/> to use for element actions</param>
        public ElementOperations()
        {
            _browser = new BrowserFactory().GetBrowser().Browser;
        }

        /// <summary>
        /// Click on element
        /// </summary>
        /// <returns><see cref="ElementOperations"/></returns>
        public ElementOperations Click()
        {
            InitializeActions();
            _actions.Click();
            return this;
        }

        /// <summary>
        /// Click on element
        /// </summary>
        /// <param name="element"><see cref="ISeleniumElement"/> to perform operations</param>
        /// <returns><see cref="ElementOperations"/></returns>
        public ElementOperations Click(ISeleniumElement element)
        {
            InitializeActions();
            _actions.Click(element.WebElement);
            return this;
        }

        /// <summary>
        /// Double click on element
        /// </summary>
        /// <returns><see cref="ElementOperations"/></returns>
        public ElementOperations DoubleClick()
        {
            InitializeActions();
            _actions.DoubleClick();
            return this;
        }

        /// <summary>
        /// Double click on element
        /// </summary>
        /// <param name="element"><see cref="ISeleniumElement"/> to perform operations</param>
        /// <returns><see cref="ElementOperations"/></returns>
        public ElementOperations DoubleClick(ISeleniumElement element)
        {
            InitializeActions();
            _actions.DoubleClick(element.WebElement);
            return this;
        }

        /// <summary>
        /// Right click on element
        /// </summary>
        /// <returns><see cref="ElementOperations"/></returns>
        public ElementOperations RightClick()
        {
            InitializeActions();
            _actions.ContextClick();
            return this;
        }

        /// <summary>
        /// Right click on element
        /// </summary>
        /// <param name="element"><see cref="ISeleniumElement"/> to perform operations</param>
        /// <returns><see cref="ElementOperations"/></returns>
        public ElementOperations RightClick(ISeleniumElement element)
        {
            InitializeActions();
            _actions.DoubleClick(element.WebElement);
            return this;
        }

        /// <summary>
        /// Hover on element
        /// </summary>
        /// <param name="element"><see cref="ISeleniumElement"/> to perform operations</param>
        /// <returns><see cref="ElementOperations"/></returns>
        public ElementOperations MoveToElement(ISeleniumElement element)
        {
            InitializeActions();
            _actions.MoveToElement(element.WebElement);
            return this;
        }

        /// <summary>
        /// Hover on element
        /// </summary>
        /// <param name="element"><see cref="ISeleniumElement"/> to perform operations</param>
        /// <param name="offsetX">Horizontal offset</param>
        /// <param name="offsetY">Vertical offset</param>
        /// <returns><see cref="ElementOperations"/></returns>
        public ElementOperations MoveToElement(ISeleniumElement element, int offsetX, int offsetY)
        {
            InitializeActions();
            _actions.MoveToElement(element.WebElement, offsetX, offsetY);
            return this;
        }

        /// <summary>
        /// Hover on element
        /// </summary>
        /// <param name="element"><see cref="ISeleniumElement"/> to perform operations</param>
        /// <param name="offsetX">Horizontal offset</param>
        /// <param name="offsetY">Vertical offset</param>
        /// <param name="offsetOrigin">Offset origin</param>
        /// <returns><see cref="ElementOperations"/></returns>
        public ElementOperations MoveToElement(ISeleniumElement element, int offsetX, int offsetY, MoveToElementOffsetOrigin offsetOrigin)
        {
            InitializeActions();
            _actions.MoveToElement(element.WebElement, offsetX, offsetY, offsetOrigin);
            return this;
        }

        /// <summary>
        /// Hover on element
        /// </summary>
        /// <returns><see cref="ElementOperations"/></returns>
        public ElementOperations MoveByOffset(int offsetX, int offsetY)
        {
            InitializeActions();
            _actions.MoveByOffset(offsetX, offsetY);
            return this;
        }

        /// <summary>
        /// Enter value
        /// </summary>
        /// <param name="input">Keys to send</param>
        /// <returns><see cref="ElementOperations"/></returns>
        public ElementOperations SendKeys(string input)
        {
            InitializeActions();
            _actions.SendKeys(input);
            return this;
        }

        /// <summary>
        /// Enter value
        /// </summary>
        /// <param name="element"><see cref="ISeleniumElement"/> to perform operations</param>
        /// <param name="input">Keys to send</param>
        /// <returns><see cref="ElementOperations"/></returns>
        public ElementOperations SendKeys(ISeleniumElement element, string input)
        {
            InitializeActions();
            _actions.SendKeys(element.WebElement, input);
            return this;
        }

        /// <summary>
        /// Key Up on element
        /// </summary>
        /// <param name="theKey">Keys to send</param>
        /// <returns><see cref="ElementOperations"/></returns>
        public ElementOperations KeyDown(string theKey)
        {
            InitializeActions();
            _actions.KeyUp(theKey);
            return this;
        }

        /// <summary>
        /// Key Up on element
        /// </summary>
        /// <param name="element"><see cref="ISeleniumElement"/> to perform operations</param>
        /// <param name="theKey">Keys to send</param>
        /// <returns><see cref="ElementOperations"/></returns>
        public ElementOperations KeyDown(ISeleniumElement element, string theKey)
        {
            InitializeActions();
            _actions.KeyDown(element.WebElement, theKey);
            return this;
        }

        /// <summary>
        /// Key Up on element
        /// </summary>
        /// <param name="theKey">Keys to send</param>
        /// <returns><see cref="ElementOperations"/></returns>
        public ElementOperations KeyUp(string theKey)
        {
            InitializeActions();
            _actions.KeyUp(theKey);
            return this;
        }

        /// <summary>
        /// Key Up on element
        /// </summary>
        /// <param name="element"><see cref="ISeleniumElement"/> to perform operations</param>
        /// <param name="theKey">Keys to send</param>
        /// <returns><see cref="ElementOperations"/></returns>
        public ElementOperations KeyUp(ISeleniumElement element, string theKey)
        {
            InitializeActions();
            _actions.KeyUp(element.WebElement, theKey);
            return this;
        }

        /// <summary>
        /// Drag drop source element to destination
        /// </summary>
        /// <param name="sourceElement">Source element to drag and drop</param>
        /// <param name="destinationElement">Element to drop source element</param>
        /// <returns><see cref="ElementOperations"/></returns>
        public ElementOperations DragDrop(ISeleniumElement sourceElement, ISeleniumElement destinationElement)
        {
            InitializeActions();
            _actions.DragAndDrop(sourceElement.WebElement, destinationElement.WebElement);
            return this;
        }

        /// <summary>
        /// Drag drop source element to destination
        /// </summary>
        /// <param name="element"><see cref="ISeleniumElement"/> to perform operations</param>
        /// <param name="offsetX">Horizontal offset to move</param>
        /// <param name="offsetY">Vertical offset to move</param>
        /// <returns><see cref="ElementOperations"/></returns>
        public ElementOperations DragDrop(ISeleniumElement element, int offsetX, int offsetY)
        {
            InitializeActions();
            _actions.DragAndDropToOffset(element.WebElement, offsetX, offsetY);
            return this;
        }

        /// <summary>
        /// Release the mouse key on the element
        /// </summary>
        /// <returns><see cref="ElementOperations"/></returns>
        public ElementOperations Release()
        {
            InitializeActions();
            _actions.Release();
            return this;
        }

        /// <summary>
        /// Release the mouse key on the element
        /// </summary>
        /// <param name="element"><see cref="ISeleniumElement"/> to perform operations</param>
        /// <returns><see cref="ElementOperations"/></returns>
        public ElementOperations Release(ISeleniumElement element)
        {
            InitializeActions();
            _actions.Release(element.WebElement);
            return this;
        }

        /// <summary>
        /// Perform the action
        /// </summary>
        public void Perform()
        {
            _actions.Build().Perform();
            _actions = null;
        }

        /// <summary>
        /// Initilize actions
        /// </summary>
        private void InitializeActions()
        {
            if (_actions != null)
            {
                return;
            }
            _actions = new Actions(_browser);
        }
    }
}
