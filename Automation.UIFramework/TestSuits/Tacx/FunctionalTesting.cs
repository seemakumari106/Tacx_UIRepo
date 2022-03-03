using API.Interfaces.Tacx.Dashboard;
using API.Interfaces.Tacx.Home;
using API.Interfaces.Tacx.Login;
using API.Tacx.Dashboard;
using API.Tacx.Home;
using API.Tacx.Login;
using AventStack.ExtentReports;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSuits.Report;

namespace TestSuits.Tacx
{
    [TestFixture]
    public class FunctionalTesting : TacxTestBase
    {
        private readonly ILoginPage _loginPageOperations;
        private readonly IHomePage _homePageOperations;
        private readonly IDashboard _dashboardOperations;

        public FunctionalTesting()
        {
            _loginPageOperations = new LoginPageOperations();
            _homePageOperations = new HomePageOperations();
            _dashboardOperations = new DashboardOperations();
        }

        [Test]
        public void TestCase()
        {
            _homePageOperations.SignIn();
            _loginPageOperations.CreateNewAccount("Seema", "seema@gmail.com", "Thurakku1!");
            Assert.AreEqual("https://cloud.tacx.com/#/dashboard", _browserOperations.CurrentUrl, "Url does not match");
            Reporter.LogToReport(Status.Pass, "Browser URL Verified");
            _dashboardOperations.CreateWorkOut("TestWorkout");
            _dashboardOperations.NavigateToRecentlyCreatedWorkout();

            Assert.AreEqual("TestWorkout", _dashboardOperations.LastCreatedWorkoutName, "Workout creation failed");
            Reporter.LogToReport(Status.Pass, "Workout created");
            _dashboardOperations.SignOut();
        }
    }
}
