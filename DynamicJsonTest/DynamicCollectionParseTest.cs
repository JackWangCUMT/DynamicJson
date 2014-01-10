using DynamicJson;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynamicJsonTest
{
    [TestClass]
    public class DynamicCollectionParseTest : JsonResourceBase
    {
        [TestMethod]
        public void ParseImageCollection_ShouldReturnImageObject()
        {
            string json = GetJson("WidgetCollection.json");

            var image = DynamicCollectionParse.Parse(json);

            Assert.AreEqual("sun1", image[0].ImageName);
            Assert.AreEqual("Images/Sun.png", image[0].Source);
        }
    }
}