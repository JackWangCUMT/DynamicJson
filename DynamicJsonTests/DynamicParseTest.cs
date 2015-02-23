using DynamicJson;
using Xunit;
using Xunit.Should;

namespace DynamicJsonTests
{
    public class DynamicParseTest : JsonResourceBase
    {
        [Fact]
        public void ParseImage_ShouldReturnImageObject()
        {
            string json = GetJson("Widget.json");

            var image = DynamicParse.Parse(json);

            image.Name.ShouldBe("sun1");
            image.Src.ShouldBe("Images/Sun.png");
            image.HOffset.ShouldBe(250);
            image.VOffset.ShouldBe(200);
            image.Alignment.ShouldBe("center");
        }
    }
}