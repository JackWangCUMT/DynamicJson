using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace DynamicJsonTests
{
    public class JsonResourceBase
    {
        private static Stream GetResourceStream(string resourceName)
        {
            var resource =
                Assembly.GetExecutingAssembly()
                        .GetManifestResourceStream("DynamicJsonTests." + resourceName);

            Debug.Assert(resource != null, "resource != null");

            return resource;
        }

        protected string GetJson(string resource)
        {
            using (var reader = new StreamReader(GetResourceStream(resource)))
            {
                var json = reader.ReadToEnd();
                return json;
            }
        }
    }
}