using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class mx
{
    [JsonProperty("priority")]
    public int priority { get; set; }

    [JsonProperty("exchange")]
    public string exchange { get; set; }

}

public class data
{
    [JsonProperty("domain")]
    public string domain { get; set; }

    [JsonProperty("mx")]
    public mx[] mx { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
