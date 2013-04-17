using Microsoft.Practices.Unity.Configuration;

namespace Unity.FactoryConfig
{
    public class FactoryConfigExtension : SectionExtension
    {
        public override void AddExtensions(SectionExtensionContext context)
        {
            context.AddElement<FactoryElement>("factory");
        }
    }
}
