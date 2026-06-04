namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the direction that the extrusion's sweep path takes away from the extruded shape (the front face of
/// the extrusion).
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msopresetextrusiondirection?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoPresetExtrusionDirection))]
public enum PresetExtrusionDirection
{
  /// <summary>
  /// Specifies the direction that the extrusion's sweep path takes away from the extruded shape (the front face of
  /// the extrusion).
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetExtrusionDirection.msoPresetExtrusionDirectionMixed))]
  Mixed = -2,
  /// <summary>
  /// Bottom right.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetExtrusionDirection.msoExtrusionBottomRight))]
  BottomRight = 1,
  /// <summary>
  /// Bottom.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetExtrusionDirection.msoExtrusionBottom))]
  Bottom = 2,
  /// <summary>
  /// Bottom left.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetExtrusionDirection.msoExtrusionBottomLeft))]
  BottomLeft = 3,
  /// <summary>
  /// Right.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetExtrusionDirection.msoExtrusionRight))]
  Right = 4,
  /// <summary>
  /// No extrusion.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetExtrusionDirection.msoExtrusionNone))]
  None = 5,
  /// <summary>
  /// Left.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetExtrusionDirection.msoExtrusionLeft))]
  Left = 6,
  /// <summary>
  /// Top right.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetExtrusionDirection.msoExtrusionTopRight))]
  TopRight = 7,
  /// <summary>
  /// Top.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetExtrusionDirection.msoExtrusionTop))]
  Top = 8,
  /// <summary>
  /// Top left.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetExtrusionDirection.msoExtrusionTopLeft))]
  TopLeft = 9
}
