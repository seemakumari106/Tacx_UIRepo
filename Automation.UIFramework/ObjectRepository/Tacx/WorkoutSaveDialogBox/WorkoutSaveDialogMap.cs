using Automation.UIFramework.Elements;
using Automation.UIFramework.ObjectRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectRepository.Tacx.WorkoutSaveDialogBox
{
    public class WorkoutSaveDialogMap : MapBase<WorkoutSaveDialogMap>
    {
        private WorkoutSaveDialogMap() { }
        public ISeleniumElement TitleTextBox => seleniumElementIdentifier.XPath("//*[@id='input_10']");
        public ISeleniumElement DilgSaveButton => seleniumElementIdentifier.XPath("/html/body/div[3]/md-dialog/md-dialog-actions/button[2]");
    }
}
