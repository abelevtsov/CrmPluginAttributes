using System;

namespace CrmPluginAttributes
{
    /// <summary>
    /// Information about service method operationa over CRM for build operations graph
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = true)]
    public class CrmServiceOperationAttribute : Attribute
    {
        public CrmServiceOperationAttribute(int order, string entityLogicalName, OrganizationServiceOperation operation, params string[] columns)
        {
            Order = order;
            EntityLogicalName = entityLogicalName;
            Operation = operation;
            Columns = columns;
        }

        public string EntityLogicalName { get; set; }

        public OrganizationServiceOperation Operation { get; set; }

        public string[] Columns { get; set; }

        public int Order { get; set; }
    }
}
