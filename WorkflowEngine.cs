namespace ultimate_csharp_mastery
{
    public class WorkflowEngine
    {
        public void Run(Workflow workflow)
        {
            foreach (var activity in workflow.Activities)
                activity.Execute();
        }
    }
}