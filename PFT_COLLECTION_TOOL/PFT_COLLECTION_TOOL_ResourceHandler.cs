using System.Reflection;
using System.Resources;

namespace Cerner.PFT_COLLECTION_TOOL
{
    internal static class ResourceHandler
    {
        private static ResourceManager rm = null;

        public static ResourceManager Resources
        {
            get
            {
                if (rm == null)
                {
                    rm = new ResourceManager("Cerner.PFT_COLLECTION_TOOL.StringResources", Assembly.GetExecutingAssembly());
                }
                return rm;
            }
        }
    }
}