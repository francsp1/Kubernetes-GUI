using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenStack_GUI.Models
{
    //public class Images
    //{
    //    [JsonProperty("images")]
    //    public List<Image> ImageList { get; set; }

    //    [JsonProperty("schema")]
    //    public string Schema { get; set; }

    //    [JsonProperty("first")]
    //    public string First { get; set; }

    //    [JsonProperty("next", NullValueHandling = NullValueHandling.Ignore)]
    //    public string Next { get; set; }

    //}

    //public class Image
    //{
    //    [JsonProperty("status")]
    //    public string Status { get; set; }

    //    [JsonProperty("name")]
    //    public string Name { get; set; }

    //    [JsonProperty("tags")]
    //    public List<object> Tags { get; set; }

    //    [JsonProperty("container_format")]
    //    public string ContainerFormat { get; set; }

    //    [JsonProperty("created_at")]
    //    public DateTimeOffset CreatedAt { get; set; }

    //    [JsonProperty("disk_format")]
    //    public string DiskFormat { get; set; }

    //    [JsonProperty("updated_at")]
    //    public DateTimeOffset UpdatedAt { get; set; }

    //    [JsonProperty("visibility")]
    //    public string Visibility { get; set; }

    //    [JsonProperty("self")]
    //    public string Self { get; set; }

    //    [JsonProperty("min_disk")]
    //    public long MinDisk { get; set; }

    //    [JsonProperty("protected")]
    //    public bool Protected { get; set; }

    //    [JsonProperty("id")]
    //    public Guid Id { get; set; }

    //    [JsonProperty("file")]
    //    public string File { get; set; }

    //    [JsonProperty("checksum")]
    //    public string Checksum { get; set; }

    //    [JsonProperty("os_hash_algo")]
    //    public string OsHashAlgo { get; set; }

    //    [JsonProperty("os_hash_value")]
    //    public string OsHashValue { get; set; }

    //    [JsonProperty("os_hidden")]
    //    public bool OsHidden { get; set; }

    //    [JsonProperty("owner")]
    //    public string Owner { get; set; }

    //    [JsonProperty("size", NullValueHandling = 0)]
    //    public long Size { get; set; }

    //    [JsonProperty("min_ram")]
    //    public long MinRam { get; set; }

    //    [JsonProperty("schema")]
    //    public string Schema { get; set; }

    //    [JsonProperty("virtual_size")]
    //    public object VirtualSize { get; set; }

    //    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    //    public string Description { get; set; }

    //    [JsonProperty("hw_rng_model", NullValueHandling = NullValueHandling.Ignore)]
    //    public string HwRngModel { get; set; }

    //    public override string ToString()
    //    {
    //        return this.Name.ToString();
    //    }
    //}

    [Serializable]
    public class CreateImageModel
    {
        [JsonProperty("disk_format")]
        public string DiskFormat { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Desccription { get; set; }

        [JsonProperty("protected")]
        public bool Protected { get; set; }

        [JsonProperty("visibility")]
        public string Visibility { get; set; }

        [JsonProperty("container_format")]
        public string ContainerFormat { get; set; }

        [JsonProperty("min_ram")]
        public int MinimumRam { get; set; }

        [JsonProperty("min_disk")]
        public int MinimumDisk { get; set; }
    }


    public class UpdateImageModel
    {
        public List<UpdateImageField> updateImageField { get; set; } 

        public UpdateImageModel()
        {
            this.updateImageField = new List<UpdateImageField>();
        }
    }

    public class UpdateImageField
    {
        public string op { get; set; }
        public string path { get; set; }
        public object value { get; set; }
    }

}
