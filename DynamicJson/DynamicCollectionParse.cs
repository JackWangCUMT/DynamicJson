using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DynamicJson
{
    public class DynamicCollectionParse
    {
        public static NewImage[] Parse(string json)
        {
            dynamic jsonObject = JsonConvert.DeserializeObject<dynamic>(json);

            var images = new List<NewImage>();

            foreach (dynamic imgObject in jsonObject.widget.web.image)
            {
                dynamic image = JValue.Parse(imgObject.ToString());

                images.Add(
                    new NewImage
                        {
                            ImageName = image.name,
                            Source = image.src
                        }
                    );
            }

            return images.ToArray();
        }
    }
}