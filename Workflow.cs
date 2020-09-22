
using System.Collections.Generic;

namespace ultimate_csharp_mastery
{
    public class Workflow : IWorkflow
    {
        public readonly IList<IActivity> _activities;

        public Workflow()
        {
            _activities = new List<IActivity>();
        }

        public void RegisterActivity(IActivity activity)
        {
            _activities.Add(activity);
        }

        public IEnumerable<IActivity> GetActivities()
        {
            return _activities;
        }
    }
}