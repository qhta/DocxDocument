namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the type of line cap.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msolinecapstyle?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoLineCapStyle")]
public enum LineCapStyle
{
  /// <summary>
  /// Specifies a mixture of line caps.
  /// </summary>
  [InteropEnumValue("msoLineCapMixed")]
  Mixed = -2,
  /// <summary>
  /// Specifies a squared-off line cap.
  /// </summary>
  [InteropEnumValue("msoLineCapSquare")]
  Square = 1,
  /// <summary>
  /// Specifies a rounded line cap.
  /// </summary>
  [InteropEnumValue("msoLineCapRound")]
  Round = 2,
  /// <summary>
  /// Specifies a flat line cap.
  /// </summary>
  [InteropEnumValue("msoLineCapFlat")]
  Flat = 3
}
