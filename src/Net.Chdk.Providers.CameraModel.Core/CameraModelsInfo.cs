using Net.Chdk.Model.CameraModel;

namespace Net.Chdk.Providers.CameraModel
{
    public sealed class CameraModelsInfo
    {
        public CameraModelInfo[] Models { get; set; }
        public string CardType { get; set; }
        public string BootFileSystem { get; set; }
    }
}
