using Automation.UIFramework.Elements;
using Automation.UIFramework.Finders;
using Automation.UIFramework.ObjectRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectRepository.Tacx.Home
{
    public class HomePageObjectsMap : MapBase<HomePageObjectsMap>
    {     
        private HomePageObjectsMap()
        { }

        public ISeleniumElement SignInButton => seleniumElementIdentifier.Id("next-button");
    }
}
