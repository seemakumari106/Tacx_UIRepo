using Automation.UIFramework.ObjectRepository;

namespace ObjectRepository.Tacx.WorkoutSaveDialogBox
{
    public class WorkoutSaveDialogActions : ActionsBase<WorkoutSaveDialogActions>
    {
        private WorkoutSaveDialogActions() { }

        public WorkoutSaveDialogActions EnterTitle(string title)
        {
            elementOperations.SendKeys(WorkoutSaveDialogMap.Instance.TitleTextBox, title).Perform();
            return this;
        }

        public WorkoutSaveDialogActions ClickSaveButton()
        {
            elementOperations.Click(WorkoutSaveDialogMap.Instance.DilgSaveButton).Perform();
            return this;
        }
    }
}
