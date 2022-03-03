using Automation.UIFramework.Browser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.UIFramework.Factory
{
    public interface IBrowserFactory
    {
        /// <summary>
        /// Gets the default browser
        /// </summary>
        /// <returns><see cref="IBrowser"/></returns>
        IBrowser GetBrowser();
        /// <summary>
        /// Gets the <see cref="NgBrowser"/> browser
        /// </summary>
        /// <returns><see cref="IBrowser"/></returns>
        IBrowser GetNgBrowser();
        /// <summary>
        /// Start Browser
        /// </summary>
        void StartBrowser();

        /// <summary>
        /// Start Browser
        /// </summary>
        void StartBrowser(string browserName);

        /// <summary>
        /// Stop Browser
        /// </summary>
        void StopBrowser();
    }
}
