
namespace DocumentModel.Interop.Core;

public interface ThreeDFormat: InteropObject
{
  void IncrementRotationX(float Increment);
  void IncrementRotationY(float Increment);
  void ResetRotation();
  void SetThreeDFormat(MsoPresetThreeDFormat PresetThreeDFormat);
  void SetExtrusionDirection(MsoPresetExtrusionDirection PresetExtrusionDirection);
  float Depth { get; set; }
  ColorFormat ExtrusionColor { get; }
  MsoExtrusionColorType ExtrusionColorType { get; set; }
  MsoTriState Perspective { get; set; }
  MsoPresetExtrusionDirection PresetExtrusionDirection { get; }
  MsoPresetLightingDirection PresetLightingDirection { get; set; }
  MsoPresetLightingSoftness PresetLightingSoftness { get; set; }
  MsoPresetMaterial PresetMaterial { get; set; }
  MsoPresetThreeDFormat PresetThreeDFormat { get; }
  float RotationX { get; set; }
  float RotationY { get; set; }
  MsoTriState Visible { get; set; }
  void SetPresetCamera(MsoPresetCamera PresetCamera);
  void IncrementRotationZ(float Increment);
  void IncrementRotationHorizontal(float Increment);
  void IncrementRotationVertical(float Increment);
  MsoLightRigType PresetLighting { get; set; }
  float Z { get; set; }
  MsoBevelType BevelTopType { get; set; }
  float BevelTopInset { get; set; }
  float BevelTopDepth { get; set; }
  MsoBevelType BevelBottomType { get; set; }
  float BevelBottomInset { get; set; }
  float BevelBottomDepth { get; set; }
  MsoPresetCamera PresetCamera { get; }
  float RotationZ { get; set; }
  float ContourWidth { get; set; }
  ColorFormat ContourColor { get; }
  float FieldOfView { get; set; }
  MsoTriState ProjectText { get; set; }
  float LightAngle { get; set; }
}