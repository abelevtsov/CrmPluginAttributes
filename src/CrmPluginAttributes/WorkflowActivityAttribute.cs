using System;

namespace CrmPluginAttributes
{
    /// <summary>
    /// Metadata about custom workflow activity in CRM
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class WorkflowActivityAttribute : Attribute
    {
        public WorkflowActivityAttribute(string name, string workflowActivityGroupName)
        {
            Name = name;
            WorkflowActivityGroupName = " " + workflowActivityGroupName;
        }

        public string Name { get; set; }

        public string WorkflowActivityGroupName { get; set; }

        public string Description { get; set; }
    }
}
