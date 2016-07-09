using System;

namespace CrmPluginAttributes
{
    /// <summary>
    /// Metadata about plugin step image parameters
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter)]
    public sealed class ImageParametersAttribute : FilteringAttributesAttribute
    {
        public ImageParametersAttribute(string[] include, string[] exclude)
            : base(include, exclude)
        {
        }

        public ImageParametersAttribute(params string[] include)
            : base(include)
        {
        }
    }
}
