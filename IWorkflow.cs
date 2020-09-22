using System.Collections.Generic;

namespace ultimate_csharp_mastery
{
    public interface IWorkflow
    {
        IEnumerable<IActivity> GetActivities();
        void RegisterActivity(IActivity activity);
    }
}