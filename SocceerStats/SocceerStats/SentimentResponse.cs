using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocceerStats
{

    public class SentimentResponse
    {
        [JsonProperty(PropertyName = "document")]
        public List<Sentiment> Sentiments { get; set; }
        public object[] errors { get; set; }
        public string modelVersion { get; set; }
    }

    public class Sentiment
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        public string sentiment { get; set; }
        [JsonProperty(PropertyName = "confidenceScores")]
        public Confidencescores ConfidenceScores { get; set; }
        public Sentence[] sentences { get; set; }
        public object[] warnings { get; set; }
    }

    public class Confidencescores
    {
        [JsonProperty(PropertyName = "positive")]
        public double Positive { get; set; }
        [JsonProperty(PropertyName = "neutral")]
        public double Neutral { get; set; }
        [JsonProperty(PropertyName = "negative")]
        public double Negative { get; set; }
    }

    public class Sentence
    {
        public string sentiment { get; set; }
        public Confidencescores1 confidenceScores { get; set; }
        public int offset { get; set; }
        public int length { get; set; }
        public string text { get; set; }
    }

    public class Confidencescores1
    {
        public float positive { get; set; }
        public float neutral { get; set; }
        public float negative { get; set; }
    }

}
