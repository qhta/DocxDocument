
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the range
/// marked by error bars.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlerrorbartype?view=office-pia` for Office interop details.
/// </remarks>
public enum ErrorBarType
{
  /// <summary>
  /// Range is set by fixed values or cell values.
  /// </summary>
  Custom = -4114,
  /// <summary>
  /// Fixed-length error bars.
  /// </summary>
  FixedValue = 1,
  /// <summary>
  /// Percentage of range to be covered by the error bars.
  /// </summary>
  Percent = 2,
  /// <summary>
  /// Shows range for specified number of standard deviations.
  /// </summary>
  StDev = -4155,
  /// <summary>
  /// Shows standard error range.
  /// </summary>
  StError = 4
}
