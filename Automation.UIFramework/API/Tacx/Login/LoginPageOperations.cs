using API.Interfaces.Tacx.Login;
using ObjectRepository.Tacx.Login;

namespace API.Tacx.Login
{
    public class LoginPageOperations : ILoginPage
    {
        public void CreateNewAccount(string userName,string email,string password)
        {
            LoginPageActions.Instance.ClickCreateOneButton()
                .EnterUserName(userName)
                .EnterEmail(email)
                .ReEnterEmail(email)
                .EnterPassword(password)
                .ReEnterPassword(password)
                .CheckGlobalOptionCheckBox()
                .CheckTermsOfUseCheckBox()
                .CheckConfirmAgeCheckBox()
                .ClickCreateAccountButton();

        }
    }
}
