
namespace DocumentModel.Interop.Core;

public partial interface ThreeDFormat: InteropObject
{
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
