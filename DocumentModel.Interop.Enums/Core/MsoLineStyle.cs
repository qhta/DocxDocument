namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the style for a line.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msolinestyle?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoLineStyle")]
public enum LineStyle
{
  /// <summary>
  /// Not supported.
  /// </summary>
  [OfficeInteropEnumValue("msoLineStyleMixed")]
  StyleMixed = -2,
  /// <summary>
  /// Single line.
  /// </summary>
  [OfficeInteropEnumValue("msoLineSingle")]
  Single = 1,
  /// <summary>
  /// Two thin lines.
  /// </summary>
  [OfficeInteropEnumValue("msoLineThinThin")]
  ThinThin = 2,
  /// <summary>
  /// Thick line next to thin line. For horizontal lines, thick line is below thin line. For vertical lines, thick
  /// line is to the right of the thin line.
  /// </summary>
  [OfficeInteropEnumValue("msoLineThinThick")]
  ThinThick = 3,
  /// <summary>
  /// Thick line next to thin line. For horizontal lines, thick line is above thin line. For vertical lines, thick
  /// line is to the left of the thin line.
  /// </summary>
  [OfficeInteropEnumValue("msoLineThickThin")]
  ThickThin = 4,
  /// <summary>
  /// Thick line with a thin line on each side.
  /// </summary>
  [OfficeInteropEnumValue("msoLineThickBetweenThin")]
  ThickBetweenThin = 5
}
