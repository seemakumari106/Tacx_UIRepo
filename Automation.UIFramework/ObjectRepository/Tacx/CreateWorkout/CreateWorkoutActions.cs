using Automation.UIFramework.ObjectRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectRepository.Tacx.CreateWorkout
{
    public class CreateWorkoutActions : ActionsBase<CreateWorkoutActions>
    {
        private CreateWorkoutActions() { }

        public CreateWorkoutActions ClickPowerButton()
        {
            elementOperations.Click(CreateWorkoutMap.Instance.PowerWorkoutButon).Perform();
            return this;
        }

        public CreateWorkoutActions ClickDistanceButton()
        {
            elementOperations.Click(CreateWorkoutMap.Instance.DistanceButton).Perform();
            return this;
        }

        public CreateWorkoutActions ClickContinueButton()
        {
            elementOperations.Click(CreateWorkoutMap.Instance.ContinueButton).Perform();
            return this;
        }

        public CreateWorkoutActions ClickIncrementButton()
        {
            elementOperations.Click(CreateWorkoutMap.Instance.DistanceIncrementButton).Perform();
            return this;
        }

        public CreateWorkoutActions ClickSaveButton()
        {
            elementOperations.Click(CreateWorkoutMap.Instance.SaveButton).Perform();
            return this;
        }
    }
}
