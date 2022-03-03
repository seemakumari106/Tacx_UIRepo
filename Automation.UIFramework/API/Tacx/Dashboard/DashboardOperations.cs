using API.Interfaces.Tacx.Dashboard;
using Automation.UIFramework.Elements;
using ObjectRepository.Tacx.CreateWorkout;
using ObjectRepository.Tacx.Dasboard;
using ObjectRepository.Tacx.Workouts;
using ObjectRepository.Tacx.WorkoutSaveDialogBox;

namespace API.Tacx.Dashboard
{
    public class DashboardOperations : IDashboard
    {
        public string LastCreatedWorkoutName => new SeleniumElement(WorkoutsMap.Instance.LatestWorkOutNameLabel.WebElement).Text;
        public void CreateWorkOut(string name)
        {
            DashboardActions.Instance.ClickCreateWorkoutButton();
            CreateWorkoutActions.Instance.ClickPowerButton()
                .ClickDistanceButton()
                .ClickContinueButton();

            for (int i = 0; i < 20; i++)
            {
                CreateWorkoutActions.Instance.ClickIncrementButton();
            }
            CreateWorkoutActions.Instance.ClickSaveButton();

            WorkoutSaveDialogActions.Instance.EnterTitle(name)
                .ClickSaveButton();
        }

        public void NavigateToRecentlyCreatedWorkout()
        {
            DashboardActions.Instance.ClickWorkoutsButton();
            WorkoutsActions.Instance.ClickWorkoutsOverviewButton()
                .ClickMyWorkoutsButton();
        }

        public void SignOut()
        {
            DashboardActions.Instance.ClickSignOutButton();
        }
    }
}
