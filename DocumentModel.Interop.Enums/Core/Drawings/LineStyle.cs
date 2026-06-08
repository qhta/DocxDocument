namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the style for a line.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msolinestyle?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoLineStyle")]
public enum LineStyle
{
  /// <summary>
  /// Not supported.
  /// </summary>
  [InteropEnumValue("msoLineStyleMixed")]
  StyleMixed = -2,
  /// <summary>
  /// Single line.
  /// </summary>
  [InteropEnumValue("msoLineSingle")]
  Single = 1,
  /// <summary>
  /// Two thin lines.
  /// </summary>
  [InteropEnumValue("msoLineThinThin")]
  ThinThin = 2,
  /// <summary>
  /// Thick line next to thin line. For horizontal lines, thick line is below thin line. For vertical lines, thick
  /// line is to the right of the thin line.
  /// </summary>
  [InteropEnumValue("msoLineThinThick")]
  ThinThick = 3,
  /// <summary>
  /// Thick line next to thin line. For horizontal lines, thick line is above thin line. For vertical lines, thick
  /// line is to the left of the thin line.
  /// </summary>
  [InteropEnumValue("msoLineThickThin")]
  ThickThin = 4,
  /// <summary>
  /// Thick line with a thin line on each side.
  /// </summary>
  [InteropEnumValue("msoLineThickBetweenThin")]
  ThickBetweenThin = 5
}
