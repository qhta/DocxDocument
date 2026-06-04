namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the location of lighting on an extruded (three-dimensional) shape relative to the shape.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msopresetlightingdirection?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoPresetLightingDirection")]
public enum PresetLightingDirection
{
  /// <summary>
  /// Specifies the location of lighting on an extruded (three-dimensional) shape relative to the shape.
  /// </summary>
  [InteropEnumValue("msoPresetLightingDirectionMixed")]
  Mixed = -2,
  /// <summary>
  /// Lighting comes from the top left.
  /// </summary>
  [InteropEnumValue("msoLightingTopLeft")]
  TopLeft = 1,
  /// <summary>
  /// Lighting comes from the top.
  /// </summary>
  [InteropEnumValue("msoLightingTop")]
  Top = 2,
  /// <summary>
  /// Lighting comes from the top right.
  /// </summary>
  [InteropEnumValue("msoLightingTopRight")]
  TopRight = 3,
  /// <summary>
  /// Lighting comes from the left.
  /// </summary>
  [InteropEnumValue("msoLightingLeft")]
  Left = 4,
  /// <summary>
  /// No lighting.
  /// </summary>
  [InteropEnumValue("msoLightingNone")]
  None = 5,
  /// <summary>
  /// Lighting comes from the right.
  /// </summary>
  [InteropEnumValue("msoLightingRight")]
  Right = 6,
  /// <summary>
  /// Lighting comes from the bottom left.
  /// </summary>
  [InteropEnumValue("msoLightingBottomLeft")]
  BottomLeft = 7,
  /// <summary>
  /// Lighting comes from the bottom.
  /// </summary>
  [InteropEnumValue("msoLightingBottom")]
  Bottom = 8,
  /// <summary>
  /// Lighting comes from the bottom right.
  /// </summary>
  [InteropEnumValue("msoLightingBottomRight")]
  BottomRight = 9
}
