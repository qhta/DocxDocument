namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the location of lighting on an extruded (three-dimensional) shape relative to the shape.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msopresetlightingdirection?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoPresetLightingDirection")]
public enum PresetLightingDirection
{
  /// <summary>
  /// Specifies the location of lighting on an extruded (three-dimensional) shape relative to the shape.
  /// </summary>
  [OfficeInteropEnumValue("msoPresetLightingDirectionMixed")]
  Mixed = -2,
  /// <summary>
  /// Lighting comes from the top left.
  /// </summary>
  [OfficeInteropEnumValue("msoLightingTopLeft")]
  TopLeft = 1,
  /// <summary>
  /// Lighting comes from the top.
  /// </summary>
  [OfficeInteropEnumValue("msoLightingTop")]
  Top = 2,
  /// <summary>
  /// Lighting comes from the top right.
  /// </summary>
  [OfficeInteropEnumValue("msoLightingTopRight")]
  TopRight = 3,
  /// <summary>
  /// Lighting comes from the left.
  /// </summary>
  [OfficeInteropEnumValue("msoLightingLeft")]
  Left = 4,
  /// <summary>
  /// No lighting.
  /// </summary>
  [OfficeInteropEnumValue("msoLightingNone")]
  None = 5,
  /// <summary>
  /// Lighting comes from the right.
  /// </summary>
  [OfficeInteropEnumValue("msoLightingRight")]
  Right = 6,
  /// <summary>
  /// Lighting comes from the bottom left.
  /// </summary>
  [OfficeInteropEnumValue("msoLightingBottomLeft")]
  BottomLeft = 7,
  /// <summary>
  /// Lighting comes from the bottom.
  /// </summary>
  [OfficeInteropEnumValue("msoLightingBottom")]
  Bottom = 8,
  /// <summary>
  /// Lighting comes from the bottom right.
  /// </summary>
  [OfficeInteropEnumValue("msoLightingBottomRight")]
  BottomRight = 9
}
