using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenStack_GUI.Models
{

    public class Volume
    {
        public CreateVolumesModel volume { get; set; }
    }

    [Serializable]
    public class CreateVolumesModel
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("availabilityZone")]
        public string AvailabilityZone { get; set; }

        [JsonProperty("bootable")]
        public string Bootable { get; set; }

    }



    public class RequestUpdateVolumeObject
    {
        public UpdateVolumeObject volume { get; set; }
    }

    public class UpdateVolumeObject
    {
        public string name { get; set; }
        public string description { get; set; }
        //public UpdateVolumeMetadataObject metadata { get; set; }
    }

    public class UpdateVolumeMetadataObject
    {
        public string name { get; set; }
    }

}
