using Net.Chdk.Model.Camera;
using Net.Chdk.Model.CameraModel;

namespace Net.Chdk.Providers.CameraModel
{
    public interface ICameraModelProvider
    {
        CameraModelInfo[] GetCameraModels(CameraInfo cameraInfo);
    }
}
