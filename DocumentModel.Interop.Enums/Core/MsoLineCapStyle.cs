namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the type of line cap.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msolinecapstyle?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoLineCapStyle")]
public enum LineCapStyle
{
  /// <summary>
  /// Specifies a mixture of line caps.
  /// </summary>
  [OfficeInteropEnumValue("msoLineCapMixed")]
  Mixed = -2,
  /// <summary>
  /// Specifies a squared-off line cap.
  /// </summary>
  [OfficeInteropEnumValue("msoLineCapSquare")]
  Square = 1,
  /// <summary>
  /// Specifies a rounded line cap.
  /// </summary>
  [OfficeInteropEnumValue("msoLineCapRound")]
  Round = 2,
  /// <summary>
  /// Specifies a flat line cap.
  /// </summary>
  [OfficeInteropEnumValue("msoLineCapFlat")]
  Flat = 3
}
