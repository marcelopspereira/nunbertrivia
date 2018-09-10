using Newtonsoft.Json;

namespace api.Dto
{
    public class TriviaResponse
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }
        [JsonProperty("found")]
        public string Found { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }

    }
}