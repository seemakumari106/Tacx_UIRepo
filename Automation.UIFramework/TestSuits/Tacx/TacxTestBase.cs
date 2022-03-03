using Automation.UIFramework.Factory;
using Automation.UIFramework.Operations;
using AventStack.ExtentReports;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSuits.Report;

namespace TestSuits.Tacx
{
    public class TacxTestBase
    {
        private readonly IBrowserFactory _browserFactory;

        protected BrowserOperations _browserOperations;

        string TacxUrl = "http://cloud.tacx.com/";

        public TestContext TestContext { get; set; }

        public TacxTestBase()
        {
            _browserFactory = new BrowserFactory();
            _browserFactory.StartBrowser();
            var browser = _browserFactory.GetBrowser().Browser;
            _browserOperations = new BrowserOperations(browser);

            var directory = TestContext.CurrentContext.WorkDirectory;
            Reporter.SetUpReport(directory, "TacxLoginFunctionalTest", "Functional test report");
        }

        [OneTimeSetUp]
        public void OneTimeSetup()
        {

        }

        [SetUp]
        public void Setup()
        {
            Reporter.CreateTest(TestContext.CurrentContext.Test.FullName);
            _browserOperations.Load(TacxUrl);
            _browserOperations.Maximize();
        }

        [TearDown]
        public void TearDown()
        {
            _browserOperations.QuitBrowser();
            var testStatus = TestContext.CurrentContext.Result.Outcome.Status;
            Status status;
            switch (testStatus)
            {
                case TestStatus.Failed:
                    status = Status.Fail;
                    Reporter.TestStatus(status.ToString());
                    break;
                case TestStatus.Inconclusive:
                    break;
                case TestStatus.Passed:
                    status = Status.Pass;
                    break;
                case TestStatus.Warning:
                    break;
                default:
                    break;
            }

        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            Reporter.FlushReport();
        }
    }
}
