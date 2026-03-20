
namespace DocumentModel.Interop.Core;

public partial interface ThreeDFormat
{
  public void IncrementRotationX(float Increment);
  public void IncrementRotationY(float Increment);
  public void ResetRotation();
  public void SetThreeDFormat(MsoPresetThreeDFormat PresetThreeDFormat);
  public void SetExtrusionDirection(MsoPresetExtrusionDirection PresetExtrusionDirection);
  public void SetPresetCamera(MsoPresetCamera PresetCamera);
  public void IncrementRotationZ(float Increment);
  public void IncrementRotationHorizontal(float Increment);
  public void IncrementRotationVertical(float Increment);
}
