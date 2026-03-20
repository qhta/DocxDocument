namespace DocumentModel.Interop;

/// <summary>
/// Represents a shape's three-dimensional formatting.
/// </summary>
public partial interface ThreeDFormat : InteropObject
{
  /// <summary>
  /// The depth.
  /// </summary>
  public float Depth { get; set; }

  /// <summary>
  /// The extrusion color.
  /// </summary>
  public ColorFormat ExtrusionColor { get; }

  /// <summary>
  /// The extrusion color type.
  /// </summary>
  //public Core.MsoExtrusionColorType ExtrusionColorType { get; set; }

  /// <summary>
  /// The perspective.
  /// </summary>
  //public Core.MsoTriState Perspective { get; set; }

  /// <summary>
  /// The preset extrusion direction.
  /// </summary>
  //public Core.MsoPresetExtrusionDirection PresetExtrusionDirection { get; }

  /// <summary>
  /// The preset lighting direction.
  /// </summary>
  //public Core.MsoPresetLightingDirection PresetLightingDirection { get; set; }

  /// <summary>
  /// The preset lighting softness.
  /// </summary>
  //public Core.MsoPresetLightingSoftness PresetLightingSoftness { get; set; }

  /// <summary>
  /// The preset material.
  /// </summary>
  //public Core.MsoPresetMaterial PresetMaterial { get; set; }

  /// <summary>
  /// The preset three dformat.
  /// </summary>
  //public Core.MsoPresetThreeDFormat PresetThreeDFormat { get; }

  /// <summary>
  /// The rotation x.
  /// </summary>
  public float RotationX { get; set; }

  /// <summary>
  /// The rotation y.
  /// </summary>
  public float RotationY { get; set; }

  /// <summary>
  /// The visible.
  /// </summary>
  //public Core.MsoTriState Visible { get; set; }

  /// <summary>
  /// The preset lighting.
  /// </summary>
  //public Core.MsoLightRigType PresetLighting { get; set; }

  /// <summary>
  /// The z.
  /// </summary>
  public float Z { get; set; }

  /// <summary>
  /// The bevel top type.
  /// </summary>
  //public Core.MsoBevelType BevelTopType { get; set; }

  /// <summary>
  /// The bevel top inset.
  /// </summary>
  public float BevelTopInset { get; set; }

  /// <summary>
  /// The bevel top depth.
  /// </summary>
  public float BevelTopDepth { get; set; }

  /// <summary>
  /// The bevel bottom type.
  /// </summary>
  //public Core.MsoBevelType BevelBottomType { get; set; }

  /// <summary>
  /// The bevel bottom inset.
  /// </summary>
  public float BevelBottomInset { get; set; }

  /// <summary>
  /// The bevel bottom depth.
  /// </summary>
  public float BevelBottomDepth { get; set; }

  /// <summary>
  /// The preset camera.
  /// </summary>
  //public Core.MsoPresetCamera PresetCamera { get; }

  /// <summary>
  /// The rotation z.
  /// </summary>
  public float RotationZ { get; set; }

  /// <summary>
  /// The contour width.
  /// </summary>
  public float ContourWidth { get; set; }

  /// <summary>
  /// The contour color.
  /// </summary>
  public ColorFormat ContourColor { get; }

  /// <summary>
  /// The field of view.
  /// </summary>
  public float FieldOfView { get; set; }

  /// <summary>
  /// The project text.
  /// </summary>
  //public Core.MsoTriState ProjectText { get; set; }

  /// <summary>
  /// The light angle.
  /// </summary>
  public float LightAngle { get; set; }
}
