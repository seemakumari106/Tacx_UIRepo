using Automation.UIFramework.ObjectRepository;

namespace ObjectRepository.Tacx.Login
{
    public class LoginPageActions : ActionsBase<LoginPageActions>
    {
        private LoginPageActions() { }

        public LoginPageActions ClickCreateOneButton()
        {
            elementOperations.Click(LoginPageObjectsMap.Instance.CreateOneButton).Perform();
            return this;
        }

        public LoginPageActions EnterUserName(string userName)
        {
            elementOperations.SendKeys(LoginPageObjectsMap.Instance.UserNameTextBox, userName).Perform();
            return this;
        }

        public LoginPageActions EnterEmail(string email)
        {
            elementOperations.SendKeys(LoginPageObjectsMap.Instance.EmailTextBox, email).Perform();
            return this;
        }

        public LoginPageActions ReEnterEmail(string email)
        {
            elementOperations.SendKeys(LoginPageObjectsMap.Instance.ReTypeEmailTextBox, email).Perform();
            return this;
        }

        public LoginPageActions EnterPassword(string password)
        {
            elementOperations.SendKeys(LoginPageObjectsMap.Instance.PasswordTextBox, password).Perform();
            return this;
        }

        public LoginPageActions ReEnterPassword(string password)
        {
            elementOperations.SendKeys(LoginPageObjectsMap.Instance.ReTypePasswordTextBox, password).Perform();
            return this;
        }

        public LoginPageActions CheckGlobalOptionCheckBox()
        {
            elementOperations.Click(LoginPageObjectsMap.Instance.GlobalOptionCheckBox).Perform();
            return this;
        }

        public LoginPageActions CheckTermsOfUseCheckBox()
        {
            elementOperations.Click(LoginPageObjectsMap.Instance.TermsOfUseCheckBox).Perform();
            return this;
        }

        public LoginPageActions CheckConfirmAgeCheckBox()
        {
            elementOperations.Click(LoginPageObjectsMap.Instance.ConfirmAgeCheckBox).Perform();
            return this;
        }

        public LoginPageActions ClickCreateAccountButton()
        {
            elementOperations.Click(LoginPageObjectsMap.Instance.CreateAccountButton).Perform();
            return this;
        }
    }
}
