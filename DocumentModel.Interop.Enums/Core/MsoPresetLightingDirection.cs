namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the location of lighting on an extruded (three-dimensional) shape relative to the shape.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msopresetlightingdirection?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoPresetLightingDirection))]
public enum PresetLightingDirection
{
  /// <summary>
  /// Specifies the location of lighting on an extruded (three-dimensional) shape relative to the shape.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetLightingDirection.msoPresetLightingDirectionMixed))]
  Mixed = -2,
  /// <summary>
  /// Lighting comes from the top left.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetLightingDirection.msoLightingTopLeft))]
  TopLeft = 1,
  /// <summary>
  /// Lighting comes from the top.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetLightingDirection.msoLightingTop))]
  Top = 2,
  /// <summary>
  /// Lighting comes from the top right.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetLightingDirection.msoLightingTopRight))]
  TopRight = 3,
  /// <summary>
  /// Lighting comes from the left.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetLightingDirection.msoLightingLeft))]
  Left = 4,
  /// <summary>
  /// No lighting.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetLightingDirection.msoLightingNone))]
  None = 5,
  /// <summary>
  /// Lighting comes from the right.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetLightingDirection.msoLightingRight))]
  Right = 6,
  /// <summary>
  /// Lighting comes from the bottom left.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetLightingDirection.msoLightingBottomLeft))]
  BottomLeft = 7,
  /// <summary>
  /// Lighting comes from the bottom.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetLightingDirection.msoLightingBottom))]
  Bottom = 8,
  /// <summary>
  /// Lighting comes from the bottom right.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetLightingDirection.msoLightingBottomRight))]
  BottomRight = 9
}
