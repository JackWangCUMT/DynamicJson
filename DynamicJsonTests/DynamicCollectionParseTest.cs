using DynamicJson;
using Xunit;
using Xunit.Should;

namespace DynamicJsonTests
{
    public class DynamicCollectionParseTest : JsonResourceBase
    {
        [Fact]
        public void ParseImageCollection_ShouldReturnImageObject()
        {
            string json = GetJson("WidgetCollection.json");

            var image = DynamicCollectionParse.Parse(json);

            image[0].ImageName.ShouldBe("sun1");
            image[0].Source.ShouldBe("Images/Sun.png");
        }
    }
}