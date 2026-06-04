
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Indicates numeric
/// units of measurement.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xldisplayunit?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("XlDisplayUnit")]
public enum DisplayUnit
{
  /// <summary>
  /// Specifies units of hundreds.
  /// </summary>
  [OfficeInteropEnumValue("xlHundreds")]
  Hundreds = -2,
  /// <summary>
  /// Specifies units of thousands.
  /// </summary>
  [OfficeInteropEnumValue("xlThousands")]
  Thousands = -3,
  /// <summary>
  /// Specifies units of tens of thousands.
  /// </summary>
  [OfficeInteropEnumValue("xlTenThousands")]
  TenThousands = -4,
  /// <summary>
  /// Specifies units of hundreds of thousands.
  /// </summary>
  [OfficeInteropEnumValue("xlHundredThousands")]
  HundredThousands = -5,
  /// <summary>
  /// Specifies units of millions.
  /// </summary>
  [OfficeInteropEnumValue("xlMillions")]
  Millions = -6,
  /// <summary>
  /// Specifies units of tens of millions.
  /// </summary>
  [OfficeInteropEnumValue("xlTenMillions")]
  TenMillions = -7,
  /// <summary>
  /// Specifies units of hundreds of millions.
  /// </summary>
  [OfficeInteropEnumValue("xlHundredMillions")]
  HundredMillions = -8,
  /// <summary>
  /// Specifies units of thousands of millions.
  /// </summary>
  [OfficeInteropEnumValue("xlThousandMillions")]
  ThousandMillions = -9,
  /// <summary>
  /// Specifies units of millions of millions.
  /// </summary>
  [OfficeInteropEnumValue("xlMillionMillions")]
  MillionMillions = -10,
  /// <summary>
  /// Specifies custom units.
  /// </summary>
  [OfficeInteropEnumValue("xlDisplayUnitCustom")]
  DisplayUnitCustom = -4114,
  /// <summary>
  /// No units are displayed.
  /// </summary>
  [OfficeInteropEnumValue("xlDisplayUnitNone")]
  DisplayUnitNone = -4142
}
