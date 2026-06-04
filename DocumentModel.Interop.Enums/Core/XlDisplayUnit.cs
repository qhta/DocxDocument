
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Indicates numeric
/// units of measurement.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xldisplayunit?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.XlDisplayUnit))]
public enum DisplayUnit
{
  /// <summary>
  /// Specifies units of hundreds.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlDisplayUnit.xlHundreds))]
  Hundreds = -2,
  /// <summary>
  /// Specifies units of thousands.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlDisplayUnit.xlThousands))]
  Thousands = -3,
  /// <summary>
  /// Specifies units of tens of thousands.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlDisplayUnit.xlTenThousands))]
  TenThousands = -4,
  /// <summary>
  /// Specifies units of hundreds of thousands.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlDisplayUnit.xlHundredThousands))]
  HundredThousands = -5,
  /// <summary>
  /// Specifies units of millions.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlDisplayUnit.xlMillions))]
  Millions = -6,
  /// <summary>
  /// Specifies units of tens of millions.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlDisplayUnit.xlTenMillions))]
  TenMillions = -7,
  /// <summary>
  /// Specifies units of hundreds of millions.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlDisplayUnit.xlHundredMillions))]
  HundredMillions = -8,
  /// <summary>
  /// Specifies units of thousands of millions.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlDisplayUnit.xlThousandMillions))]
  ThousandMillions = -9,
  /// <summary>
  /// Specifies units of millions of millions.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlDisplayUnit.xlMillionMillions))]
  MillionMillions = -10,
  /// <summary>
  /// Specifies custom units.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlDisplayUnit.xlDisplayUnitCustom))]
  DisplayUnitCustom = -4114,
  /// <summary>
  /// No units are displayed.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlDisplayUnit.xlDisplayUnitNone))]
  DisplayUnitNone = -4142
}
