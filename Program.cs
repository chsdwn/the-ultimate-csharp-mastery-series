using System;

namespace ultimate_csharp_mastery
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflow = new Workflow();
            workflow.RegisterActivity(new Copy());
            workflow.RegisterActivity(new Cut());
            workflow.RegisterActivity(new Delete());

            var workflowEngine = new WorkflowEngine();
            workflowEngine.Run(workflow);
        }
    }
}
