using System;

namespace CrmPluginAttributes
{
    /// <summary>
    /// Metadata about how target plugin step must be installed in CRM
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public sealed class PluginStepAttribute : Attribute
    {
        public PluginStepAttribute(
            string entityLogicalName,
            string pluginMessageName,
            PluginStage stage = PluginStage.PostOperation,
            PluginExecutionMode executionMode = PluginExecutionMode.Synchronous,
            int rank = 1)
        {
            PluginMessageName = pluginMessageName;
            EntityLogicalName = entityLogicalName;
            Stage = stage;
            ExecutionMode = executionMode;
            Rank = rank;
            Enabled = true;
        }

        public string PluginMessageName { get; set; }

        public string EntityLogicalName { get; set; }

        public PluginStage Stage { get; set; }

        public PluginExecutionMode ExecutionMode { get; set; }

        public int Rank { get; set; }

        public bool DeleteAsyncOperationIfSuccessful { get; set; }

        public string UnsecureConfig { get; set; }

        public bool Enabled { get; set; }
    }
}
