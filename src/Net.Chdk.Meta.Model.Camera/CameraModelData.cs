using System.Collections.Generic;

namespace Net.Chdk.Meta.Model.Camera
{
    public sealed class CameraModelData
    {
        public string[] Names { get; set; }
        public string Platform { get; set; }
        public IDictionary<string, VersionData> Versions { get; set; }
        public IDictionary<string, RevisionData> Revisions { get; set; }
    }
}
