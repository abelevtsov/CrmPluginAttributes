using System;
using System.Linq;

namespace CrmPluginAttributes
{
    /// <summary>
    /// Metadata about plugin step filtering attributes
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, Inherited = false)]
    public class FilteringAttributesAttribute : Attribute
    {
        public FilteringAttributesAttribute(string[] include, string[] exclude)
            : this(include)
        {
            ExcludeAttributes = exclude ?? new string[] { };
        }

        public FilteringAttributesAttribute(params string[] include)
        {
            IncludeAttributes = include;
            ExcludeAttributes = new string[] { };
        }

        public string[] Attributes => IncludeAttributes.Except(ExcludeAttributes).ToArray();

        private string[] IncludeAttributes { get; set; }

        private string[] ExcludeAttributes { get; set; }

        public override string ToString()
        {
            var str = string.Join(",", Attributes);
            return str == "*" ? string.Empty : str;
        }
    }
}
