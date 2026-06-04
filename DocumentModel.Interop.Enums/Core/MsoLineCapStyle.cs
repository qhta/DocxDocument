namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the type of line cap.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msolinecapstyle?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoLineCapStyle))]
public enum LineCapStyle
{
  /// <summary>
  /// Specifies a mixture of line caps.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLineCapStyle.msoLineCapMixed))]
  Mixed = -2,
  /// <summary>
  /// Specifies a squared-off line cap.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLineCapStyle.msoLineCapSquare))]
  Square = 1,
  /// <summary>
  /// Specifies a rounded line cap.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLineCapStyle.msoLineCapRound))]
  Round = 2,
  /// <summary>
  /// Specifies a flat line cap.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLineCapStyle.msoLineCapFlat))]
  Flat = 3
}
