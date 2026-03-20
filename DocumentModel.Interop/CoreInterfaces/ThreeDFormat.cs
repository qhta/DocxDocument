
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `ThreeDFormat` interface.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat?view=office-pia
/// </remarks>
public partial interface ThreeDFormat: InteropObject
{
  /// <summary>
  /// Gets or sets the `Depth` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.depth?view=office-pia
  /// </remarks>
  public float Depth { get; set; }
  /// <summary>
  /// Gets the `ExtrusionColor` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.extrusioncolor?view=office-pia
  /// </remarks>
  public ColorFormat ExtrusionColor { get; }
  /// <summary>
  /// Gets or sets the `ExtrusionColorType` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.extrusioncolortype?view=office-pia
  /// </remarks>
  public MsoExtrusionColorType ExtrusionColorType { get; set; }
  /// <summary>
  /// Gets or sets the `Perspective` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.perspective?view=office-pia
  /// </remarks>
  public MsoTriState Perspective { get; set; }
  /// <summary>
  /// Gets the `PresetExtrusionDirection` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.presetextrusiondirection?view=office-pia
  /// </remarks>
  public MsoPresetExtrusionDirection PresetExtrusionDirection { get; }
  /// <summary>
  /// Gets or sets the `PresetLightingDirection` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.presetlightingdirection?view=office-pia
  /// </remarks>
  public MsoPresetLightingDirection PresetLightingDirection { get; set; }
  /// <summary>
  /// Gets or sets the `PresetLightingSoftness` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.presetlightingsoftness?view=office-pia
  /// </remarks>
  public MsoPresetLightingSoftness PresetLightingSoftness { get; set; }
  /// <summary>
  /// Gets or sets the `PresetMaterial` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.presetmaterial?view=office-pia
  /// </remarks>
  public MsoPresetMaterial PresetMaterial { get; set; }
  /// <summary>
  /// Gets the `PresetThreeDFormat` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.presetthreedformat?view=office-pia
  /// </remarks>
  public MsoPresetThreeDFormat PresetThreeDFormat { get; }
  /// <summary>
  /// Gets or sets the `RotationX` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.rotationx?view=office-pia
  /// </remarks>
  public float RotationX { get; set; }
  /// <summary>
  /// Gets or sets the `RotationY` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.rotationy?view=office-pia
  /// </remarks>
  public float RotationY { get; set; }
  /// <summary>
  /// Gets or sets the `Visible` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.visible?view=office-pia
  /// </remarks>
  public MsoTriState Visible { get; set; }
  /// <summary>
  /// Gets or sets the `PresetLighting` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.presetlighting?view=office-pia
  /// </remarks>
  public MsoLightRigType PresetLighting { get; set; }
  /// <summary>
  /// Gets or sets the `Z` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.z?view=office-pia
  /// </remarks>
  public float Z { get; set; }
  /// <summary>
  /// Gets or sets the `BevelTopType` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.beveltoptype?view=office-pia
  /// </remarks>
  public MsoBevelType BevelTopType { get; set; }
  /// <summary>
  /// Gets or sets the `BevelTopInset` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.beveltopinset?view=office-pia
  /// </remarks>
  public float BevelTopInset { get; set; }
  /// <summary>
  /// Gets or sets the `BevelTopDepth` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.beveltopdepth?view=office-pia
  /// </remarks>
  public float BevelTopDepth { get; set; }
  /// <summary>
  /// Gets or sets the `BevelBottomType` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.bevelbottomtype?view=office-pia
  /// </remarks>
  public MsoBevelType BevelBottomType { get; set; }
  /// <summary>
  /// Gets or sets the `BevelBottomInset` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.bevelbottominset?view=office-pia
  /// </remarks>
  public float BevelBottomInset { get; set; }
  /// <summary>
  /// Gets or sets the `BevelBottomDepth` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.bevelbottomdepth?view=office-pia
  /// </remarks>
  public float BevelBottomDepth { get; set; }
  /// <summary>
  /// Gets the `PresetCamera` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.presetcamera?view=office-pia
  /// </remarks>
  public MsoPresetCamera PresetCamera { get; }
  /// <summary>
  /// Gets or sets the `RotationZ` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.rotationz?view=office-pia
  /// </remarks>
  public float RotationZ { get; set; }
  /// <summary>
  /// Gets or sets the `ContourWidth` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.contourwidth?view=office-pia
  /// </remarks>
  public float ContourWidth { get; set; }
  /// <summary>
  /// Gets the `ContourColor` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.contourcolor?view=office-pia
  /// </remarks>
  public ColorFormat ContourColor { get; }
  /// <summary>
  /// Gets or sets the `FieldOfView` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.fieldofview?view=office-pia
  /// </remarks>
  public float FieldOfView { get; set; }
  /// <summary>
  /// Gets or sets the `ProjectText` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.projecttext?view=office-pia
  /// </remarks>
  public MsoTriState ProjectText { get; set; }
  /// <summary>
  /// Gets or sets the `LightAngle` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.lightangle?view=office-pia
  /// </remarks>
  public float LightAngle { get; set; }
}
