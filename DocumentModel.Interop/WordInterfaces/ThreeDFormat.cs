namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a shape's three-dimensional formatting.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.threedformat?view=word-pia"/>
public partial interface ThreeDFormat : InteropObject
{
  /// <summary>
  /// The depth.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.threedformat.depth?view=word-pia"/>
  public float Depth { get; set; }

  /// <summary>
  /// The extrusion color.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.threedformat.extrusioncolor?view=word-pia"/>
  public ColorFormat ExtrusionColor { get; }

  /// <summary>
  /// The extrusion color type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.threedformat.extrusioncolortype?view=word-pia"/>
  public Core.MsoExtrusionColorType ExtrusionColorType { get; set; }

  /// <summary>
  /// The perspective.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.threedformat.perspective?view=word-pia"/>
  public Core.MsoTriState Perspective { get; set; }

  /// <summary>
  /// The preset extrusion direction.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.threedformat.presetextrusiondirection?view=word-pia"/>
  public Core.MsoPresetExtrusionDirection PresetExtrusionDirection { get; }

  /// <summary>
  /// The preset lighting direction.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.threedformat.presetlightingdirection?view=word-pia"/>
  public Core.MsoPresetLightingDirection PresetLightingDirection { get; set; }

  /// <summary>
  /// The preset lighting softness.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.threedformat.presetlightingsoftness?view=word-pia"/>
  public Core.MsoPresetLightingSoftness PresetLightingSoftness { get; set; }

  /// <summary>
  /// The preset material.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.threedformat.presetmaterial?view=word-pia"/>
  public Core.MsoPresetMaterial PresetMaterial { get; set; }

  /// <summary>
  /// The preset three dformat.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.threedformat.presetthreedformat?view=word-pia"/>
  public Core.MsoPresetThreeDFormat PresetThreeDFormat { get; }

  /// <summary>
  /// The rotation x.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.threedformat.rotationx?view=word-pia"/>
  public float RotationX { get; set; }

  /// <summary>
  /// The rotation y.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.threedformat.rotationy?view=word-pia"/>
  public float RotationY { get; set; }

  /// <summary>
  /// The visible.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.threedformat.visible?view=word-pia"/>
  public Core.MsoTriState Visible { get; set; }

  /// <summary>
  /// The preset lighting.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.threedformat.presetlighting?view=word-pia"/>
  public Core.MsoLightRigType PresetLighting { get; set; }

  /// <summary>
  /// The z.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.threedformat.z?view=word-pia"/>
  public float Z { get; set; }

  /// <summary>
  /// The bevel top type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.threedformat.beveltoptype?view=word-pia"/>
  public Core.MsoBevelType BevelTopType { get; set; }

  /// <summary>
  /// The bevel top inset.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.threedformat.beveltopinset?view=word-pia"/>
  public float BevelTopInset { get; set; }

  /// <summary>
  /// The bevel top depth.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.threedformat.beveltopdepth?view=word-pia"/>
  public float BevelTopDepth { get; set; }

  /// <summary>
  /// The bevel bottom type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.threedformat.bevelbottomtype?view=word-pia"/>
  public Core.MsoBevelType BevelBottomType { get; set; }

  /// <summary>
  /// The bevel bottom inset.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.threedformat.bevelbottominset?view=word-pia"/>
  public float BevelBottomInset { get; set; }

  /// <summary>
  /// The bevel bottom depth.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.threedformat.bevelbottomdepth?view=word-pia"/>
  public float BevelBottomDepth { get; set; }

  /// <summary>
  /// The preset camera.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.threedformat.presetcamera?view=word-pia"/>
  public Core.MsoPresetCamera PresetCamera { get; }

  /// <summary>
  /// The rotation z.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.threedformat.rotationz?view=word-pia"/>
  public float RotationZ { get; set; }

  /// <summary>
  /// The contour width.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.threedformat.contourwidth?view=word-pia"/>
  public float ContourWidth { get; set; }

  /// <summary>
  /// The contour color.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.threedformat.contourcolor?view=word-pia"/>
  public ColorFormat ContourColor { get; }

  /// <summary>
  /// The field of view.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.threedformat.fieldofview?view=word-pia"/>
  public float FieldOfView { get; set; }

  /// <summary>
  /// The project text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.threedformat.projecttext?view=word-pia"/>
  public Core.MsoTriState ProjectText { get; set; }

  /// <summary>
  /// The light angle.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.threedformat.lightangle?view=word-pia"/>
  public float LightAngle { get; set; }
}
