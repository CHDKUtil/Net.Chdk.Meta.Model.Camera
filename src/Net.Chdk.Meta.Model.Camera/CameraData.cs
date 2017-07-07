﻿using Net.Chdk.Model.Software;

namespace Net.Chdk.Meta.Model.Camera
{
    public abstract class CameraData<TCamera, TModel, TCard>
        where TCamera : CameraData<TCamera, TModel, TCard>
        where TModel : CameraModelData
        where TCard : CardData
    {
        public TModel[] Models { get; set; }
        public SoftwareEncodingInfo Encoding { get; set; }
        public TCard Card { get; set; }
        public BootData Boot { get; set; }
    }
}
