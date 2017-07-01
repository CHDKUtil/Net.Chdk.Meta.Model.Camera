using Net.Chdk.Model.Software;

namespace Net.Chdk.Meta.Model.Camera
{
    public sealed class CameraData
    {
        public CameraModelData[] Models { get; set; }
        public SoftwareEncodingInfo Encoding { get; set; }
    }
}
