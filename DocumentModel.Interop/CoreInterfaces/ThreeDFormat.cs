
namespace DocumentModel.Interop.Core;

public interface ThreeDFormat: InteropObject
{
  public void IncrementRotationX(float Increment);
  public void IncrementRotationY(float Increment);
  public void ResetRotation();
  public void SetThreeDFormat(MsoPresetThreeDFormat PresetThreeDFormat);
  public void SetExtrusionDirection(MsoPresetExtrusionDirection PresetExtrusionDirection);
  public float Depth { get; set; }
  public ColorFormat ExtrusionColor { get; }
  public MsoExtrusionColorType ExtrusionColorType { get; set; }
  public MsoTriState Perspective { get; set; }
  public MsoPresetExtrusionDirection PresetExtrusionDirection { get; }
  public MsoPresetLightingDirection PresetLightingDirection { get; set; }
  public MsoPresetLightingSoftness PresetLightingSoftness { get; set; }
  public MsoPresetMaterial PresetMaterial { get; set; }
  public MsoPresetThreeDFormat PresetThreeDFormat { get; }
  public float RotationX { get; set; }
  public float RotationY { get; set; }
  public MsoTriState Visible { get; set; }
  public void SetPresetCamera(MsoPresetCamera PresetCamera);
  public void IncrementRotationZ(float Increment);
  public void IncrementRotationHorizontal(float Increment);
  public void IncrementRotationVertical(float Increment);
  public MsoLightRigType PresetLighting { get; set; }
  public float Z { get; set; }
  public MsoBevelType BevelTopType { get; set; }
  public float BevelTopInset { get; set; }
  public float BevelTopDepth { get; set; }
  public MsoBevelType BevelBottomType { get; set; }
  public float BevelBottomInset { get; set; }
  public float BevelBottomDepth { get; set; }
  public MsoPresetCamera PresetCamera { get; }
  public float RotationZ { get; set; }
  public float ContourWidth { get; set; }
  public ColorFormat ContourColor { get; }
  public float FieldOfView { get; set; }
  public MsoTriState ProjectText { get; set; }
  public float LightAngle { get; set; }
}
