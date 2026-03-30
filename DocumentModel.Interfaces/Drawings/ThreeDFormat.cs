namespace DocumentModel.Drawings;

/// <summary>
/// Represents a shape's three-dimensional formatting.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.threedformat?view=word-pia"/>
public partial interface ThreeDFormat : IModelObject
{
  /// <summary>
  /// Returns or sets the depth of the shape's extrusion. Can be a value from – 600 through 9600 (positive values
  /// produce an extrusion whose front face is the original shape; negative values produce an extrusion whose back
  /// face is the original shape).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.threedformat.depth?view=word-pia"/>
  public float Depth { get; set; }

  /// <summary>
  /// Returns a ColorFormat object that represents the color of the shape's extrusion.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.threedformat.extrusioncolor?view=word-pia"/>
  public ColorFormat ExtrusionColor { get; }

  /// <summary>
  /// Returns or sets a value that indicates whether the extrusion color is based on the extruded shape's fill (the
  /// front face of the extrusion) and automatically changes when the shape's fill changes, or whether the extrusion
  /// color is independent of the shape's fill.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.threedformat.extrusioncolortype?view=word-pia"/>
  public ExtrusionColorType ExtrusionColorType { get; set; }

  /// <summary>
  /// MsoTrue if the extrusion appears in perspective— that is, if the walls of the extrusion narrow toward a
  /// vanishing point. MsoFalse if the extrusion is a parallel, or orthographic, projection— that is, if the walls
  /// don't narrow toward a vanishing point.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.threedformat.perspective?view=word-pia"/>
  public TriState Perspective { get; set; }

  /// <summary>
  /// Returns the direction taken by the extrusion's sweep path leading away from the extruded shape (the front face
  /// of the extrusion).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.threedformat.presetextrusiondirection?view=word-pia"/>
  public PresetExtrusionDirection PresetExtrusionDirection { get; }

  /// <summary>
  /// Returns or sets the position of the light source relative to the extrusion.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.threedformat.presetlightingdirection?view=word-pia"/>
  public PresetLightingDirection PresetLightingDirection { get; set; }

  /// <summary>
  /// Returns or sets the intensity of the extrusion lighting.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.threedformat.presetlightingsoftness?view=word-pia"/>
  public PresetLightingSoftness PresetLightingSoftness { get; set; }

  /// <summary>
  /// Returns or sets the extrusion surface material.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.threedformat.presetmaterial?view=word-pia"/>
  public PresetMaterial PresetMaterial { get; set; }

  /// <summary>
  /// Returns the preset extrusion format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.threedformat.presetthreedformat?view=word-pia"/>
  public PresetThreeDFormat PresetThreeDFormat { get; }

  /// <summary>
  /// Returns or sets the rotation of the extruded shape around the x-axis in degrees. Can be a value from – 90
  /// through 90. A positive value indicates upward rotation; a negative value indicates downward rotation.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.threedformat.rotationx?view=word-pia"/>
  public float RotationX { get; set; }

  /// <summary>
  /// Returns or sets the rotation of the extruded shape around the y-axis, in degrees. Can be a value from – 90
  /// through 90. A positive value indicates rotation to the left; a negative value indicates rotation to the right.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.threedformat.rotationy?view=word-pia"/>
  public float RotationY { get; set; }

  /// <summary>
  /// True if the specified object, or the formatting applied to it, is visible.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.threedformat.visible?view=word-pia"/>
  public TriState Visible { get; set; }

  /// <summary>
  /// Returns or sets an BevelType constant that represents the lighting preset. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.threedformat.presetlighting?view=word-pia"/>
  public LightRigType PresetLighting { get; set; }

  /// <summary>
  /// Returns or sets a Single that represents the z-axis for the shape. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.threedformat.z?view=word-pia"/>
  public float Z { get; set; }

  /// <summary>
  /// Returns or sets an PresetCamera constant that represents the bevel type for the top bevel. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.threedformat.beveltoptype?view=word-pia"/>
  public BevelType BevelTopType { get; set; }

  /// <summary>
  /// Returns or sets a Single that represents the inset size for the top bevel. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.threedformat.beveltopinset?view=word-pia"/>
  public float BevelTopInset { get; set; }

  /// <summary>
  /// Returns or sets a Single that represents the depth of the top bevel. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.threedformat.beveltopdepth?view=word-pia"/>
  public float BevelTopDepth { get; set; }

  /// <summary>
  /// Returns or sets an PresetCamera constant that represents the bevel type for the bottom bevel. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.threedformat.bevelbottomtype?view=word-pia"/>
  public BevelType BevelBottomType { get; set; }

  /// <summary>
  /// Returns or sets a Single that represents the inset size for the bottom bevel. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.threedformat.bevelbottominset?view=word-pia"/>
  public float BevelBottomInset { get; set; }

  /// <summary>
  /// Returns or sets a Single that represents the depth of the bottom bevel. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.threedformat.bevelbottomdepth?view=word-pia"/>
  public float BevelBottomDepth { get; set; }

  /// <summary>
  /// Returns an PresetCamera constant that represents the camera presets. Read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.threedformat.presetcamera?view=word-pia"/>
  public PresetCamera PresetCamera { get; }

  /// <summary>
  /// Returns or sets a Single that represents z-axis rotation of the camera. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.threedformat.rotationz?view=word-pia"/>
  public float RotationZ { get; set; }

  /// <summary>
  /// Returns or sets a Single that represents the width of the contour of a shape. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.threedformat.contourwidth?view=word-pia"/>
  public float ContourWidth { get; set; }

  /// <summary>
  /// Returns or sets a ColorFormat object that represents color of the contour of a shape. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.threedformat.contourcolor?view=word-pia"/>
  public ColorFormat ContourColor { get; }

  /// <summary>
  /// Returns or sets a Single that represents the amount of perspective for a shape. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.threedformat.fieldofview?view=word-pia"/>
  public float FieldOfView { get; set; }

  /// <summary>
  /// Returns or sets an TriState constant that represents whether text on a shape rotates with shape. msoTrue
  /// rotates the text. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.threedformat.projecttext?view=word-pia"/>
  public TriState ProjectText { get; set; }

  /// <summary>
  /// Returns or sets a Single that represents angle of the lighting. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.threedformat.lightangle?view=word-pia"/>
  public float LightAngle { get; set; }
}
