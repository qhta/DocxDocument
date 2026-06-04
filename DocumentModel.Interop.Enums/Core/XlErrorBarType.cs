
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the range
/// marked by error bars.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlerrorbartype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.XlErrorBarType))]
public enum ErrorBarType
{
  /// <summary>
  /// Range is set by fixed values or cell values.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlErrorBarType.xlErrorBarTypeCustom))]
  Custom = -4114,
  /// <summary>
  /// Fixed-length error bars.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlErrorBarType.xlErrorBarTypeFixedValue))]
  FixedValue = 1,
  /// <summary>
  /// Percentage of range to be covered by the error bars.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlErrorBarType.xlErrorBarTypePercent))]
  Percent = 2,
  /// <summary>
  /// Shows range for specified number of standard deviations.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlErrorBarType.xlErrorBarTypeStDev))]
  StDev = -4155,
  /// <summary>
  /// Shows standard error range.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlErrorBarType.xlErrorBarTypeStError))]
  StError = 4
}
