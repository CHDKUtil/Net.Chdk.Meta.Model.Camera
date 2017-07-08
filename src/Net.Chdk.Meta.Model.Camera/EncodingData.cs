using Net.Chdk.Json;
using Newtonsoft.Json;

namespace Net.Chdk.Meta.Model.Camera
{
    public sealed class EncodingData
    {
        public string Name { get; set; }

        [JsonConverter(typeof(HexStringJsonConverter), "x8")]
        public uint? Data { get; set; }
    }
}
