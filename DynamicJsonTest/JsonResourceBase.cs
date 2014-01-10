using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace DynamicJsonTest
{
    public class JsonResourceBase
    {
        private static Stream GetResourceStream(string resourceName)
        {
            var resource =
                Assembly.GetExecutingAssembly()
                        .GetManifestResourceStream("DynamicJsonTest." + resourceName);

            Debug.Assert(resource != null, "resource != null");

            return resource;
        }

        protected string GetJson(string resourse)
        {
            using (var reader = new StreamReader(GetResourceStream(resourse)))
            {
                var json = reader.ReadToEnd();
                return json;
            }
        }
    }
}