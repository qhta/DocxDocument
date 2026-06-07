
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Indicates numeric
/// units of measurement.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xldisplayunit?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.XlDisplayUnit")]
public enum DisplayUnit
{
  /// <summary>
  /// Specifies units of hundreds.
  /// </summary>
  [InteropEnumValue("xlHundreds")]
  Hundreds = -2,
  /// <summary>
  /// Specifies units of thousands.
  /// </summary>
  [InteropEnumValue("xlThousands")]
  Thousands = -3,
  /// <summary>
  /// Specifies units of tens of thousands.
  /// </summary>
  [InteropEnumValue("xlTenThousands")]
  TenThousands = -4,
  /// <summary>
  /// Specifies units of hundreds of thousands.
  /// </summary>
  [InteropEnumValue("xlHundredThousands")]
  HundredThousands = -5,
  /// <summary>
  /// Specifies units of millions.
  /// </summary>
  [InteropEnumValue("xlMillions")]
  Millions = -6,
  /// <summary>
  /// Specifies units of tens of millions.
  /// </summary>
  [InteropEnumValue("xlTenMillions")]
  TenMillions = -7,
  /// <summary>
  /// Specifies units of hundreds of millions.
  /// </summary>
  [InteropEnumValue("xlHundredMillions")]
  HundredMillions = -8,
  /// <summary>
  /// Specifies units of thousands of millions.
  /// </summary>
  [InteropEnumValue("xlThousandMillions")]
  ThousandMillions = -9,
  /// <summary>
  /// Specifies units of millions of millions.
  /// </summary>
  [InteropEnumValue("xlMillionMillions")]
  MillionMillions = -10,
  /// <summary>
  /// Specifies custom units.
  /// </summary>
  [InteropEnumValue("xlDisplayUnitCustom")]
  DisplayUnitCustom = -4114,
  /// <summary>
  /// No units are displayed.
  /// </summary>
  [InteropEnumValue("xlDisplayUnitNone")]
  DisplayUnitNone = -4142
}
