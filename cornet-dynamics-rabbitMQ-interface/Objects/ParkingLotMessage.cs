﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cornet_dynamics_rabbitMQ_interface.Objects
{
    public class ParkingLotMessage
    {
        [JsonProperty("payload_bytes")]  
        public int payloadBytes { get; set; }
        [JsonProperty("redelivered")]
        public bool redelivered { get; set; }
        [JsonProperty("exchange")]
        public String exchange { get; set; }
        [JsonProperty("routing_key")]
        public String routingKey { get; set; }
        [JsonProperty("message_count")]
        public int messageCount { get; set; }
        [JsonProperty("properties")]
        public byte[] properties { get; set; }
        [JsonProperty("payload")]
        public String payload { get; set; }
        [JsonProperty("payload_encoding")]
        public String encoding { get; set; }
    }
}