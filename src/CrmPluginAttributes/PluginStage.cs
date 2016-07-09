namespace CrmPluginAttributes
{
    /// <summary>
    /// Eventing pipeline stage of execution
    /// </summary>
    public enum PluginStage
    {
        /// <summary>
        /// Pre validation
        /// </summary>
        PreValidation = 10,

        /// <summary>
        /// Pre operation (CRM 2011 only)
        /// </summary>
        PreOperation = 20,

        /// <summary>
        /// Post operation (CRM 2011 only)
        /// </summary>
        PostOperation = 40,

        /// <summary>
        /// Post operation (CRM4 only)
        /// </summary>
        PostOperationDeprecated = 50
    }
}
