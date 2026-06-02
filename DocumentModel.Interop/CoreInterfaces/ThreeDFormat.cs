
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `ThreeDFormat` interface.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat?view=office-pia"/>
public partial interface IThreeDFormat: IInteropObject
{
  /// <summary>
  /// Gets or sets the `Depth` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.depth?view=office-pia"/>
  public float Depth { get; set; }
  /// <summary>
  /// Gets the `ExtrusionColor` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.extrusioncolor?view=office-pia"/>
  public ColorFormat ExtrusionColor { get; }
  /// <summary>
  /// Gets or sets the `ExtrusionColorType` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.extrusioncolortype?view=office-pia"/>
  public ExtrusionColorType ExtrusionColorType { get; set; }
  /// <summary>
  /// Gets or sets the `Perspective` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.perspective?view=office-pia"/>
  public TriState Perspective { get; set; }
  /// <summary>
  /// Gets the `PresetExtrusionDirection` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.presetextrusiondirection?view=office-pia"/>
  public PresetExtrusionDirection PresetExtrusionDirection { get; }
  /// <summary>
  /// Gets or sets the `PresetLightingDirection` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.presetlightingdirection?view=office-pia"/>
  public PresetLightingDirection PresetLightingDirection { get; set; }
  /// <summary>
  /// Gets or sets the `PresetLightingSoftness` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.presetlightingsoftness?view=office-pia"/>
  public PresetLightingSoftness PresetLightingSoftness { get; set; }
  /// <summary>
  /// Gets or sets the `PresetMaterial` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.presetmaterial?view=office-pia"/>
  public PresetMaterial PresetMaterial { get; set; }
  /// <summary>
  /// Gets the `PresetThreeDFormat` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.presetthreedformat?view=office-pia"/>
  public PresetThreeDFormat PresetThreeDFormat { get; }
  /// <summary>
  /// Gets or sets the `RotationX` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.rotationx?view=office-pia"/>
  public float RotationX { get; set; }
  /// <summary>
  /// Gets or sets the `RotationY` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.rotationy?view=office-pia"/>
  public float RotationY { get; set; }
  /// <summary>
  /// Gets or sets the `Visible` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.visible?view=office-pia"/>
  public TriState Visible { get; set; }
  /// <summary>
  /// Gets or sets the `PresetLighting` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.presetlighting?view=office-pia"/>
  public LightRigType PresetLighting { get; set; }
  /// <summary>
  /// Gets or sets the `Z` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.z?view=office-pia"/>
  public float Z { get; set; }
  /// <summary>
  /// Gets or sets the `BevelTopType` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.beveltoptype?view=office-pia"/>
  public BevelType BevelTopType { get; set; }
  /// <summary>
  /// Gets or sets the `BevelTopInset` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.beveltopinset?view=office-pia"/>
  public float BevelTopInset { get; set; }
  /// <summary>
  /// Gets or sets the `BevelTopDepth` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.beveltopdepth?view=office-pia"/>
  public float BevelTopDepth { get; set; }
  /// <summary>
  /// Gets or sets the `BevelBottomType` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.bevelbottomtype?view=office-pia"/>
  public BevelType BevelBottomType { get; set; }
  /// <summary>
  /// Gets or sets the `BevelBottomInset` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.bevelbottominset?view=office-pia"/>
  public float BevelBottomInset { get; set; }
  /// <summary>
  /// Gets or sets the `BevelBottomDepth` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.bevelbottomdepth?view=office-pia"/>
  public float BevelBottomDepth { get; set; }
  /// <summary>
  /// Gets the `PresetCamera` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.presetcamera?view=office-pia"/>
  public PresetCamera PresetCamera { get; }
  /// <summary>
  /// Gets or sets the `RotationZ` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.rotationz?view=office-pia"/>
  public float RotationZ { get; set; }
  /// <summary>
  /// Gets or sets the `ContourWidth` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.contourwidth?view=office-pia"/>
  public float ContourWidth { get; set; }
  /// <summary>
  /// Gets the `ContourColor` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.contourcolor?view=office-pia"/>
  public ColorFormat ContourColor { get; }
  /// <summary>
  /// Gets or sets the `FieldOfView` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.fieldofview?view=office-pia"/>
  public float FieldOfView { get; set; }
  /// <summary>
  /// Gets or sets the `ProjectText` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.projecttext?view=office-pia"/>
  public TriState ProjectText { get; set; }
  /// <summary>
  /// Gets or sets the `LightAngle` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.lightangle?view=office-pia"/>
  public float LightAngle { get; set; }
}

