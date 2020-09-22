
using System.Collections.Generic;

namespace ultimate_csharp_mastery
{
    public class Workflow
    {
        public readonly IList<IActivity> Activities;

        public Workflow()
        {
            Activities = new List<IActivity>();
        }

        public void RegisterActivity(IActivity activity)
        {
            Activities.Add(activity);
        }
    }
}