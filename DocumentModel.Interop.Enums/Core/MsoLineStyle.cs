namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the style for a line.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msolinestyle?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoLineStyle))]
public enum LineStyle
{
  /// <summary>
  /// Not supported.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLineStyle.msoLineStyleMixed))]
  StyleMixed = -2,
  /// <summary>
  /// Single line.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLineStyle.msoLineSingle))]
  Single = 1,
  /// <summary>
  /// Two thin lines.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLineStyle.msoLineThinThin))]
  ThinThin = 2,
  /// <summary>
  /// Thick line next to thin line. For horizontal lines, thick line is below thin line. For vertical lines, thick
  /// line is to the right of the thin line.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLineStyle.msoLineThinThick))]
  ThinThick = 3,
  /// <summary>
  /// Thick line next to thin line. For horizontal lines, thick line is above thin line. For vertical lines, thick
  /// line is to the left of the thin line.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLineStyle.msoLineThickThin))]
  ThickThin = 4,
  /// <summary>
  /// Thick line with a thin line on each side.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLineStyle.msoLineThickBetweenThin))]
  ThickBetweenThin = 5
}
