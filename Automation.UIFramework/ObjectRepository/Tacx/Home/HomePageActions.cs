using Automation.UIFramework.ObjectRepository;

namespace ObjectRepository.Tacx.Home
{
    public class HomePageActions : ActionsBase<HomePageActions>
    {        
        private HomePageActions()
        {

        }

        public HomePageActions ClickSigninButton()
        {
            elementOperations.Click(HomePageObjectsMap.Instance.SignInButton).Perform();
            return this;
        }

    }
}
