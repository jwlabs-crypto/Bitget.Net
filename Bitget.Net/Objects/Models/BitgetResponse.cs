﻿using CryptoExchange.Net.Converters;
using Newtonsoft.Json;

namespace Bitget.Net.Objects.Models
{
    internal class BitgetResponse<T>
    {
        public string Code { get; set; } = string.Empty;
        [JsonProperty("msg")]
        public string? Message { get; set; }
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime RequestTime { get; set; }
        public T? Data { get; set; }
    }
}
