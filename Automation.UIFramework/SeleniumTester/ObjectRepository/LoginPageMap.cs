using Automation.UIFramework.Finders;

namespace SeleniumTester.ObjectRepository
{
    public sealed class LoginPageMap
    {
        private static LoginPageMap _instance = null;

        public static LoginPageMap Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new LoginPageMap();

                return _instance;
            }
        }

        private LoginPageMap()
        {

        }
        SeleniumElementIdentifier seleniumElementIdentifier = new SeleniumElementIdentifier();

        



    }
}
