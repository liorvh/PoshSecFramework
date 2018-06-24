﻿using System;
using System.Net;

namespace PoshSec.Framework
{
    public class NetworkNode : INetworkNode
    {
        public string Name { get; set; }
        public IPAddress IpAddress { get; set; }
        public string MacAddress { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string ClientInstalled { get; set; }
        public int Alerts { get; set; }
        public DateTime LastScanned { get; set; }
    }
}