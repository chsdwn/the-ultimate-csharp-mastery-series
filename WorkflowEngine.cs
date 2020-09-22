using System;

namespace ultimate_csharp_mastery
{
    public class WorkflowEngine
    {
        public void Run(IWorkflow workflow)
        {
            foreach (var activity in workflow.GetActivities())
            {
                try
                {
                    activity.Execute();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}