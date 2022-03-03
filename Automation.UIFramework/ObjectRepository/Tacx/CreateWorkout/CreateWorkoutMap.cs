using Automation.UIFramework.Elements;
using Automation.UIFramework.ObjectRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectRepository.Tacx.CreateWorkout
{
    public class CreateWorkoutMap : MapBase<CreateWorkoutMap>
    {
        private CreateWorkoutMap() { }

        public ISeleniumElement PowerWorkoutButon => seleniumElementIdentifier.XPath("//*[@id='main-content']/div[3]/div/div/section[1]/div/button[2]");
        public ISeleniumElement DistanceButton => seleniumElementIdentifier.XPath("//*[@id='main-content']/div[3]/div/div/section[2]/div/button[2]");
        public ISeleniumElement ContinueButton => seleniumElementIdentifier.XPath("//*[@id='main-content']/div[3]/div/div/section[3]/button");
        public ISeleniumElement DistanceIncrementButton => seleniumElementIdentifier.XPath("//*[@id='duration-group']/div[2]/button[1]");
        public ISeleniumElement DistanceDecrementButton => seleniumElementIdentifier.XPath("//*[@id='duration-group']/div[2]/button[2]");
        public ISeleniumElement DistanceValue => seleniumElementIdentifier.XPath("//*[@id='duration-group']/div[1]/span[1]");
        public ISeleniumElement SaveButton => seleniumElementIdentifier.XPath("//*[@id='main-content']/div[3]/div/div/div/md-toolbar[1]/div/button[10]");
    }
}
