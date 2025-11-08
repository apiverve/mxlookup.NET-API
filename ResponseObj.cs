using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Mx data
    /// </summary>
    public class Mx
    {
        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("exchange")]
        public string Exchange { get; set; }

    }
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("mx")]
        public Mx[] Mx { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
