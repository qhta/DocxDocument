
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `ThreeDFormat` class.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat?view=office-pia"/>
public partial class ThreeDFormat: InteropObject
{
  /// <summary>
  /// Gets or sets the `Depth` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.depth?view=office-pia"/>
  public float Depth { get; set; }
  /// <summary>
  /// Gets the `ExtrusionColor` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.extrusioncolor?view=office-pia"/>
  public ColorFormat ExtrusionColor { get; }
  /// <summary>
  /// Gets or sets the `ExtrusionColorType` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.extrusioncolortype?view=office-pia"/>
  public ExtrusionColorType ExtrusionColorType { get; set; }
  /// <summary>
  /// Gets or sets the `Perspective` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.perspective?view=office-pia"/>
  public TriState Perspective { get; set; }
  /// <summary>
  /// Gets the `PresetExtrusionDirection` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.presetextrusiondirection?view=office-pia"/>
  public PresetExtrusionDirection PresetExtrusionDirection { get; }
  /// <summary>
  /// Gets or sets the `PresetLightingDirection` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.presetlightingdirection?view=office-pia"/>
  public PresetLightingDirection PresetLightingDirection { get; set; }
  /// <summary>
  /// Gets or sets the `PresetLightingSoftness` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.presetlightingsoftness?view=office-pia"/>
  public PresetLightingSoftness PresetLightingSoftness { get; set; }
  /// <summary>
  /// Gets or sets the `PresetMaterial` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.presetmaterial?view=office-pia"/>
  public PresetMaterial PresetMaterial { get; set; }
  /// <summary>
  /// Gets the `PresetThreeDFormat` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.presetthreedformat?view=office-pia"/>
  public PresetThreeDFormat PresetThreeDFormat { get; }
  /// <summary>
  /// Gets or sets the `RotationX` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.rotationx?view=office-pia"/>
  public float RotationX { get; set; }
  /// <summary>
  /// Gets or sets the `RotationY` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.rotationy?view=office-pia"/>
  public float RotationY { get; set; }
  /// <summary>
  /// Gets or sets the `Visible` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.visible?view=office-pia"/>
  public TriState Visible { get; set; }
  /// <summary>
  /// Gets or sets the `PresetLighting` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.presetlighting?view=office-pia"/>
  public LightRigType PresetLighting { get; set; }
  /// <summary>
  /// Gets or sets the `Z` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.z?view=office-pia"/>
  public float Z { get; set; }
  /// <summary>
  /// Gets or sets the `BevelTopType` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.beveltoptype?view=office-pia"/>
  public BevelType BevelTopType { get; set; }
  /// <summary>
  /// Gets or sets the `BevelTopInset` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.beveltopinset?view=office-pia"/>
  public float BevelTopInset { get; set; }
  /// <summary>
  /// Gets or sets the `BevelTopDepth` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.beveltopdepth?view=office-pia"/>
  public float BevelTopDepth { get; set; }
  /// <summary>
  /// Gets or sets the `BevelBottomType` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.bevelbottomtype?view=office-pia"/>
  public BevelType BevelBottomType { get; set; }
  /// <summary>
  /// Gets or sets the `BevelBottomInset` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.bevelbottominset?view=office-pia"/>
  public float BevelBottomInset { get; set; }
  /// <summary>
  /// Gets or sets the `BevelBottomDepth` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.bevelbottomdepth?view=office-pia"/>
  public float BevelBottomDepth { get; set; }
  /// <summary>
  /// Gets the `PresetCamera` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.presetcamera?view=office-pia"/>
  public PresetCamera PresetCamera { get; }
  /// <summary>
  /// Gets or sets the `RotationZ` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.rotationz?view=office-pia"/>
  public float RotationZ { get; set; }
  /// <summary>
  /// Gets or sets the `ContourWidth` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.contourwidth?view=office-pia"/>
  public float ContourWidth { get; set; }
  /// <summary>
  /// Gets the `ContourColor` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.contourcolor?view=office-pia"/>
  public ColorFormat ContourColor { get; }
  /// <summary>
  /// Gets or sets the `FieldOfView` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.fieldofview?view=office-pia"/>
  public float FieldOfView { get; set; }
  /// <summary>
  /// Gets or sets the `ProjectText` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.projecttext?view=office-pia"/>
  public TriState ProjectText { get; set; }
  /// <summary>
  /// Gets or sets the `LightAngle` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.lightangle?view=office-pia"/>
  public float LightAngle { get; set; }


  #region methods

/// <summary>
  /// Invokes `IncrementRotationX`.
  /// </summary>
  /// <param name="increment">The `Increment` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.incrementrotationx?view=office-pia"/>
  public void IncrementRotationX(float increment) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `IncrementRotationY`.
  /// </summary>
  /// <param name="increment">The `Increment` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.incrementrotationy?view=office-pia"/>
  public void IncrementRotationY(float increment) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `ResetRotation`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.resetrotation?view=office-pia"/>
  public void ResetRotation() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SetThreeDFormat`.
  /// </summary>
  /// <param name="presetThreeDFormat">The `PresetThreeDFormat` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.setthreedformat?view=office-pia"/>
  public void SetThreeDFormat(PresetThreeDFormat presetThreeDFormat) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SetExtrusionDirection`.
  /// </summary>
  /// <param name="presetExtrusionDirection">The `PresetExtrusionDirection` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.setextrusiondirection?view=office-pia"/>
  public void SetExtrusionDirection(PresetExtrusionDirection presetExtrusionDirection) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SetPresetCamera`.
  /// </summary>
  /// <param name="presetCamera">The `PresetCamera` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.setpresetcamera?view=office-pia"/>
  public void SetPresetCamera(PresetCamera presetCamera) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `IncrementRotationZ`.
  /// </summary>
  /// <param name="increment">The `Increment` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.incrementrotationz?view=office-pia"/>
  public void IncrementRotationZ(float increment) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `IncrementRotationHorizontal`.
  /// </summary>
  /// <param name="increment">The `Increment` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.incrementrotationhorizontal?view=office-pia"/>
  public void IncrementRotationHorizontal(float increment) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `IncrementRotationVertical`.
  /// </summary>
  /// <param name="increment">The `Increment` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.incrementrotationvertical?view=office-pia"/>
  public void IncrementRotationVertical(float increment) { throw new NotImplementedException(); }

  #endregion methods
}

