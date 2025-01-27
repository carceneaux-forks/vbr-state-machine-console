﻿using Newtonsoft.Json;

namespace vbr_state_machine_console.Models.Settings.Monitoring
{
    public class SobrPerformanceTier
    {
        [JsonProperty("GbWarningLevel")]
        public int GbWarningLevel { get; set; }

        [JsonProperty("GbCriticalLevel")]
        public int GbCriticalLevel { get; set; }
    }
}
