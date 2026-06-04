namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the direction that the extrusion's sweep path takes away from the extruded shape (the front face of
/// the extrusion).
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msopresetextrusiondirection?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoPresetExtrusionDirection")]
public enum PresetExtrusionDirection
{
  /// <summary>
  /// Specifies the direction that the extrusion's sweep path takes away from the extruded shape (the front face of
  /// the extrusion).
  /// </summary>
  [OfficeInteropEnumValue("msoPresetExtrusionDirectionMixed")]
  Mixed = -2,
  /// <summary>
  /// Bottom right.
  /// </summary>
  [OfficeInteropEnumValue("msoExtrusionBottomRight")]
  BottomRight = 1,
  /// <summary>
  /// Bottom.
  /// </summary>
  [OfficeInteropEnumValue("msoExtrusionBottom")]
  Bottom = 2,
  /// <summary>
  /// Bottom left.
  /// </summary>
  [OfficeInteropEnumValue("msoExtrusionBottomLeft")]
  BottomLeft = 3,
  /// <summary>
  /// Right.
  /// </summary>
  [OfficeInteropEnumValue("msoExtrusionRight")]
  Right = 4,
  /// <summary>
  /// No extrusion.
  /// </summary>
  [OfficeInteropEnumValue("msoExtrusionNone")]
  None = 5,
  /// <summary>
  /// Left.
  /// </summary>
  [OfficeInteropEnumValue("msoExtrusionLeft")]
  Left = 6,
  /// <summary>
  /// Top right.
  /// </summary>
  [OfficeInteropEnumValue("msoExtrusionTopRight")]
  TopRight = 7,
  /// <summary>
  /// Top.
  /// </summary>
  [OfficeInteropEnumValue("msoExtrusionTop")]
  Top = 8,
  /// <summary>
  /// Top left.
  /// </summary>
  [OfficeInteropEnumValue("msoExtrusionTopLeft")]
  TopLeft = 9
}
