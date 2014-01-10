using Newtonsoft.Json;

namespace DynamicJson
{
    public class DynamicParse
    {
        public static Image Parse(string json)
        {
            dynamic jsonObject = JsonConvert.DeserializeObject<dynamic>(json);
            dynamic imageObject = jsonObject.widget.web.image;

            return JsonConvert.DeserializeObject<Image>(imageObject.ToString());
        }
    }
}