using Automation.UIFramework.ObjectRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectRepository.Tacx.Workouts
{
    public class WorkoutsActions : ActionsBase<WorkoutsActions>
    {
        private WorkoutsActions() { }

        public WorkoutsActions ClickMyWorkoutsButton()
        {
            elementOperations.Click(WorkoutsMap.Instance.MyWorkoutsButton).Perform();
            return this;
        }

        public WorkoutsActions ClickWorkoutsOverviewButton()
        {
            elementOperations.Click(WorkoutsMap.Instance.WorkoutsOverviewButton).Perform();
            return this;
        }
    }
}
