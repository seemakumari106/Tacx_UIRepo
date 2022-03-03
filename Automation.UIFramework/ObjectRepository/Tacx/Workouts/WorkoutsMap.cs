using Automation.UIFramework.Elements;
using Automation.UIFramework.ObjectRepository;

namespace ObjectRepository.Tacx.Workouts
{
    public class WorkoutsMap : MapBase<WorkoutsMap>
    {
        private WorkoutsMap() { }

        public ISeleniumElement WorkoutsOverviewButton => seleniumElementIdentifier.XPath("//*[@id='workouts-overview-page']/filterbar/div/div/div/md-menu[1]/button");
        public ISeleniumElement MyWorkoutsButton => seleniumElementIdentifier.XPath("//*[@id='menu_container_15']/md-menu-content/md-menu-item[1]/button");
        public ISeleniumElement LatestWorkOutNameLabel => seleniumElementIdentifier.XPath("//*[@id='workouts-cards']/div/md-card/md-card-content/a/div/div[1]/div[2]/div[1]/h4/div");

    }
}
