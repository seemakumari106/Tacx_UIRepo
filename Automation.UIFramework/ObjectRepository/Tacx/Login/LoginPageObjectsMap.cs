using Automation.UIFramework.Elements;
using Automation.UIFramework.ObjectRepository;

namespace ObjectRepository.Tacx.Login
{
   public class LoginPageObjectsMap : MapBase<LoginPageObjectsMap>
    {
        private LoginPageObjectsMap()
        { }

        public ISeleniumElement CreateOneButton => seleniumElementIdentifier.XPath("//*[@id='login-create-account']//*[@id='lnkCreateAccount']");
        public ISeleniumElement UserNameTextBox => seleniumElementIdentifier.Id("username");
        public ISeleniumElement PasswordTextBox => seleniumElementIdentifier.Id("password");
        public ISeleniumElement NameTextBox => seleniumElementIdentifier.Id("name");
        public ISeleniumElement EmailTextBox => seleniumElementIdentifier.Id("email");
        public ISeleniumElement ReTypeEmailTextBox => seleniumElementIdentifier.Id("emailMatch");
        public ISeleniumElement ReTypePasswordTextBox => seleniumElementIdentifier.Id("passwordMatch");
        public ISeleniumElement GlobalOptionCheckBox => seleniumElementIdentifier.Id("globalOptIn");
        public ISeleniumElement TermsOfUseCheckBox => seleniumElementIdentifier.Id("termsOfUse");
        public ISeleniumElement ConfirmAgeCheckBox => seleniumElementIdentifier.Id("confirmAge");
        public ISeleniumElement CreateAccountButton => seleniumElementIdentifier.Id("submitBtn");
    }
}
