using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Interfaces.Tacx.Dashboard
{
    public interface IDashboard
    {
        string LastCreatedWorkoutName { get; }
        void CreateWorkOut(string name);
        void NavigateToRecentlyCreatedWorkout();
        void SignOut();
    }
}
