using Automation.UIFramework.Elements;
using Automation.UIFramework.ObjectRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectRepository.Tacx.Dasboard
{
    public class DashboardMap : MapBase<DashboardMap>
    {
        private DashboardMap() { }

        public ISeleniumElement CreateWorkoutButton => seleniumElementIdentifier.XPath("/html/body/section[3]/md-sidenav/div/md-content/ul[1]/sidenav-section/ul/li[4]/button");
        public ISeleniumElement ActivitiesButton => seleniumElementIdentifier.XPath("/html/body/section[3]/md-sidenav/div/md-content/ul[1]/sidenav-section/ul/li[3]/button");
        public ISeleniumElement WorkoutsButton => seleniumElementIdentifier.XPath("/html/body/section[3]/md-sidenav/div/md-content/ul[1]/sidenav-section/ul/li[2]/button");
        public ISeleniumElement SignOutButton => seleniumElementIdentifier.XPath("//*[@id='sidenav-profile-info']/div[3]");       
    }
}
