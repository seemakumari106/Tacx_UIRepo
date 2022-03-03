using API.Interfaces.Tacx.Home;
using ObjectRepository.Tacx.Home;

namespace API.Tacx.Home
{
    public class HomePageOperations : IHomePage
    {
        public void SignIn()
        {
            HomePageActions.Instance.ClickSigninButton();
        }
    }
}
