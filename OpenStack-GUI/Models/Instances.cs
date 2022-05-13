using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenStack_GUI.Models
{
    class Instances
    {
        public CreateInstanceModel instance { get; set; }
    }

    public class CreateInstanceModel
    {
        [JsonProperty("instanceName")]
        public string Name { get; set; }

        [JsonProperty("imageName")]
        public string ImageName { get; set; }

        [JsonProperty("ipAddress")]
        public string IPAddress { get; set; }

        [JsonProperty("flavor")]
        public string Flavor { get; set; }

        [JsonProperty("keyPair")]
        public string KeyPair { get; set; }

        [JsonProperty("Status")]
        public string Status { get; set; }

        [JsonProperty("availabilityZone")]
        public string AvailabilityZone { get; set; }

        [JsonProperty("task")]
        public string Task { get; set; }

        [JsonProperty("powerState")]
        public string PowerState { get; set; }

        [JsonProperty("age")]
        public string Age { get; set; }

    }

    public class Private
    {
        public int version { get; set; }
        public string addr { get; set; }

        [JsonProperty("OS-EXT-IPS:type")]
        public string OSEXTIPSType { get; set; }

        [JsonProperty("OS-EXT-IPS-MAC:mac_addr")]
        public string OSEXTIPSMACMacAddr { get; set; }
    }

    public class Shared
    {
        public int version { get; set; }
        public string addr { get; set; }

        [JsonProperty("OS-EXT-IPS:type")]
        public string OSEXTIPSType { get; set; }

        [JsonProperty("OS-EXT-IPS-MAC:mac_addr")]
        public string OSEXTIPSMACMacAddr { get; set; }
    }
}
