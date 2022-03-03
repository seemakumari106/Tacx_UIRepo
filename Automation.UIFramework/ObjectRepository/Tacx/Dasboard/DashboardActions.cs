using Automation.UIFramework.ObjectRepository;

namespace ObjectRepository.Tacx.Dasboard
{
    public class DashboardActions : ActionsBase<DashboardActions>
    {
        private DashboardActions() { }

        public DashboardActions ClickCreateWorkoutButton()
        {
            elementOperations.Click(DashboardMap.Instance.CreateWorkoutButton).Perform();
            return this;
        }

        public DashboardActions ClickWorkoutsButton()
        {
            elementOperations.Click(DashboardMap.Instance.WorkoutsButton).Perform();
            return this;
        }

        public DashboardActions ClickSignOutButton()
        {
            elementOperations.Click(DashboardMap.Instance.SignOutButton).Perform();
            return this;
        }
    }
}
