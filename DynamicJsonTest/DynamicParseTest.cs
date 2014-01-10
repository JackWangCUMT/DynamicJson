using DynamicJson;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynamicJsonTest
{
    [TestClass]
    public class DynamicParseTest : JsonResourceBase
    {
        [TestMethod]
        public void ParseImage_ShouldReturnImageObject()
        {
            string json = GetJson("Widget.json");

            var image = DynamicParse.Parse(json);

            Assert.AreEqual("sun1", image.Name);
            Assert.AreEqual("Images/Sun.png", image.Src);
            Assert.AreEqual(250, image.HOffset);
            Assert.AreEqual(200, image.VOffset);
            Assert.AreEqual("center", image.Alignment);
        }
    }
}