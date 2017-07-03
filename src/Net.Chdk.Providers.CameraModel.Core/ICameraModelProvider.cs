using Net.Chdk.Model.Camera;

namespace Net.Chdk.Providers.CameraModel
{
    public interface ICameraModelProvider
    {
        CameraModelsInfo GetCameraModels(CameraInfo cameraInfo);
    }
}
