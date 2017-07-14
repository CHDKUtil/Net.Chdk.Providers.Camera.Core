using Net.Chdk.Model.CameraModel;

namespace Net.Chdk.Providers.Camera
{
    public sealed class CameraModelsInfo
    {
        public CameraModelInfo[] Models { get; set; }
        public string CardType { get; set; }
        public string CardSubtype { get; set; }
        public string BootFileSystem { get; set; }
    }
}
