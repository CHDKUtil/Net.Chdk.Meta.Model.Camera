using Net.Chdk.Model.Software;

namespace Net.Chdk.Meta.Model.Camera
{
    public abstract class CameraData<TCamera, TModel>
        where TCamera : CameraData<TCamera, TModel>
        where TModel : CameraModelData
    {
        public TModel[] Models { get; set; }
        public SoftwareEncodingInfo Encoding { get; set; }
        public CardData Card { get; set; }
        public BootData Boot { get; set; }
    }
}
