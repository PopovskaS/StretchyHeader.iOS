using Newtonsoft.Json;

namespace StretchyHeader.iOS
{
    public class DataModel
    {
        [JsonProperty("headerImage")]
        public string HeaderResource { get; set; }

		public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
