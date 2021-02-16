using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocceerStats
{

    public class SentimentRequest
    {
        [JsonProperty(PropertyName = "documents")]
        public List<Document> Documents { get; set; }
    }

    public class Document
    {
        public string language { get; set; }
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }
    }

}
