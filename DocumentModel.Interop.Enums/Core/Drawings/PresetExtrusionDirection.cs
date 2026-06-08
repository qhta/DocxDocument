namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the direction that the extrusion's sweep path takes away from the extruded shape (the front face of
/// the extrusion).
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msopresetextrusiondirection?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoPresetExtrusionDirection")]
public enum PresetExtrusionDirection
{
  /// <summary>
  /// Specifies the direction that the extrusion's sweep path takes away from the extruded shape (the front face of
  /// the extrusion).
  /// </summary>
  [InteropEnumValue("msoPresetExtrusionDirectionMixed")]
  Mixed = -2,
  /// <summary>
  /// Bottom right.
  /// </summary>
  [InteropEnumValue("msoExtrusionBottomRight")]
  BottomRight = 1,
  /// <summary>
  /// Bottom.
  /// </summary>
  [InteropEnumValue("msoExtrusionBottom")]
  Bottom = 2,
  /// <summary>
  /// Bottom left.
  /// </summary>
  [InteropEnumValue("msoExtrusionBottomLeft")]
  BottomLeft = 3,
  /// <summary>
  /// Right.
  /// </summary>
  [InteropEnumValue("msoExtrusionRight")]
  Right = 4,
  /// <summary>
  /// No extrusion.
  /// </summary>
  [InteropEnumValue("msoExtrusionNone")]
  None = 5,
  /// <summary>
  /// Left.
  /// </summary>
  [InteropEnumValue("msoExtrusionLeft")]
  Left = 6,
  /// <summary>
  /// Top right.
  /// </summary>
  [InteropEnumValue("msoExtrusionTopRight")]
  TopRight = 7,
  /// <summary>
  /// Top.
  /// </summary>
  [InteropEnumValue("msoExtrusionTop")]
  Top = 8,
  /// <summary>
  /// Top left.
  /// </summary>
  [InteropEnumValue("msoExtrusionTopLeft")]
  TopLeft = 9
}
